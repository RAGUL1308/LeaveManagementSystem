namespace LeaveManagement.Web.Models
{
    public class EmployeeAllocationVM :EmployeeListVM
    {
        public List<LeaveAllocationVM> leaveAllocations { get; set; }
    }
}
