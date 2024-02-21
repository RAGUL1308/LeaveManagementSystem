using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }

        [Display(Name ="First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Date Of Joined")]
        [DisplayFormat(DataFormatString="{0:yyyy:MM:dd}")]
        [DataType(DataType.Date)]
        public DateTime DateofJoined{ get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}
