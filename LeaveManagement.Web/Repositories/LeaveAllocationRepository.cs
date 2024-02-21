using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;


namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>,ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper,
            IEmailSender emailSender) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypedId, int period)
        {
            return await _context.LeaveAllocations.AnyAsync(s => s.EmployeeId == employeeId
                                                                 && s.LeaveTypeId == leaveTypedId
                                                                 && s.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations =await _context.LeaveAllocations
                .Include(q=>q.LeaveType)
                .Where(q => q.EmployeeId == employeeId).ToListAsync();
            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.leaveAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);
            return employeeAllocationModel; 
        }

        public async Task<LeaveAllocationVM> GetEmployeeAllocation(int id)
        {
            var allocation = await _context.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);
            if(allocation == null)
            {
                return null;
            }
            var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

            var model = _mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));
            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();
            var employeeWithNewAllocations = new List<Employee>();
            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;
                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberofDays = leaveType.DefaultDays

                }
                );
                employeeWithNewAllocations.Add(employee);
            }
                await AddRangeAsync(allocations);

                foreach (var employee in employeeWithNewAllocations)
                {
                   
                   await _emailSender.SendEmailAsync(employee.Email,$"Leave allocation Posted for {period}", $"Your {leaveType.Name} "+
                       $"has been posted for the period of {period}. You have been given {leaveType.DefaultDays}");

                }
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocations = await GetAsync(model.Id);
            if (leaveAllocations == null)
            {
                return false;
            }
            leaveAllocations.Period = model.Period;
            leaveAllocations.NumberofDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocations);
            return true;
          
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await _context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
