using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is required.")]
        public string EmployeeName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Leave type is required.")]
        public string LeaveType { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Reason is required.")]
        public string Reason { get; set; } = string.Empty;

        [RegularExpression("^(Pending|Approved|Rejected)$", ErrorMessage = "Status must be Pending, Approved, or Rejected.")]
        public string Status { get; set; } = "Pending";
    }
}