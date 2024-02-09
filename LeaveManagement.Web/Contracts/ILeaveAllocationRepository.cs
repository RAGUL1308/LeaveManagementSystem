using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
    {
        public Task LeaveAllocation(int leaveTypeId);
        public Task<bool> AllocationExists(string employeeId, int leaveTypedId, int period);
        public Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        public Task<LeaveAllocationVM> GetEmployeeAllocation(int id);
        public Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
