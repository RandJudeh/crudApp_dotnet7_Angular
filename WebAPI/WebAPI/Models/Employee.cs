namespace WebAPI.Models
{
    public class Employee
    {
        public int ?EmployeeId { get; set; } = 0;
        public string EmployeeName { get; set; } = "";
        public string Department { get; set; } = "";
        public string DateOfJoining { get; set; } = "";
        public string PhotoFileName { get; set; } = "";
    }
}
