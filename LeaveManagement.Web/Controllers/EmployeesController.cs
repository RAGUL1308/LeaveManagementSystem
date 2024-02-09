using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public EmployeesController(UserManager<Employee> userManager , IMapper mapper,ILeaveAllocationRepository leaveAllocationRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }
        // GET: EmployeeController
        public async Task<IActionResult> Index()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var model = _mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeeController/ViewAllocations/5
        public async  Task<IActionResult> ViewAllocations(string id)
        {
            var model =await _leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }


        // GET: EmployeeController/Edit/5
        public async Task<IActionResult> EditAllocation(int id)
        {

            var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
            {
                return NotFound();
            }
          
            return View(model);
        }

        // POST: EmployeeController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    if(await _leaveAllocationRepository.UpdateEmployeeAllocation(model)==true)
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                    }
                }
                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty,"An Error has occured");
               
            }
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(model.EmployeeId));
            model.leaveType = _mapper.Map<LeaveTypeVM>(await _leaveAllocationRepository.GetAsync(model.LeaveTypeId));

            return View(model);
        }
       
    }
}
