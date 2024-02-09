using LeaveManagement.Web.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name="Number of days")]
        [Required]
        [Range(1,50,ErrorMessage ="Invalid Number")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        [Required]
        public int Period { get; set; }

        public LeaveTypeVM? leaveType { get; set; }
    }
}