using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;
        private readonly IHttpContextAccessor _httpContext;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IEmailSender _emailSender;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public LeaveRequestRepository(ApplicationDbContext context,
            IMapper mapper, 
            UserManager<Employee> userManager,
            IHttpContextAccessor httpContext,
            ILeaveAllocationRepository leaveAllocationRepository,
            IEmailSender emailSender
            ) : base(context)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _httpContext = httpContext;
            _leaveAllocationRepository = leaveAllocationRepository;
            _emailSender = emailSender;
        }

        public async Task CancelLeaveRequest(int leaveRequestId)
        {

            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Cancelled = true;
            await UpdateAsync(leaveRequest);

            var user = await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId);
            await _emailSender.SendEmailAsync(user.Email, $"Leave Request Cancelled", $"Your Leave Request from" +
               $"{leaveRequest.StartDate} to {leaveRequest.EndDate} has been Cancelled Successfully");

        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;
            if (approved)
            {
                var allocation = await _leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                var daysrequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumberofDays -= daysrequested;

              await  _leaveAllocationRepository.UpdateAsync(allocation);
            }
           await  UpdateAsync(leaveRequest);
            var user = await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId);
            var approvalStatus = approved ? "Approval" : "Declined";
            await _emailSender.SendEmailAsync(user.Email, $"Leave Request {approvalStatus}",$"Your Leave Request from"+
                $"{leaveRequest.StartDate} to {leaveRequest.EndDate} has been {approvalStatus}");
        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await _userManager.GetUserAsync(_httpContext?.HttpContext?.User);
            var leaveAllocation = await _leaveAllocationRepository.GetEmployeeAllocation(user.Id, model.LeaveTypeId);
            if(leaveAllocation  == null)
            {
                return false;
            }
            int daysRequested = (int)(model.EndDate.Value - model.StartDate.Value).TotalDays;
            if(daysRequested > leaveAllocation.NumberofDays)
            {
                return false;
            }
            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);

           await _emailSender.SendEmailAsync(user.Email, "Leave Request Submitted Successfully", $"Your Leave Request from" +
                $"{leaveRequest.StartDate} to {leaveRequest.EndDate} has been submitted for approval");
            return true;

        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
            var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                LeaveRequests = _mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };
            foreach(var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }
            return model;
        }

        public async Task<List<LeaveRequest>> GetAllSync(string employeeId)
        {
            return await _context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id)
        {
            var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == id);
            if (leaveRequests == null)
            {
                return null;
            }
            var model = _mapper.Map<LeaveRequestVM>(leaveRequests);
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(leaveRequests?.RequestingEmployeeId));
            return model;
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await _userManager.GetUserAsync(_httpContext?.HttpContext?.User);
            var allocations = (await _leaveAllocationRepository.GetEmployeeAllocations(user.Id)).leaveAllocations;
            var requests = _mapper.Map<List<LeaveRequestVM>>(await GetAllSync(user.Id));
            var model = new EmployeeLeaveRequestViewVM(allocations, requests);
            return model;
        }
    }
}
