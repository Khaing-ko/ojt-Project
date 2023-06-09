namespace TodoApi.Models
{
    public class EmployeeResult : BaseModel
    {
        public long Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeAddress { get; set; } = string.Empty;
        public int? EmpDepartmentId { get; set; }
        public string? EmpDepartmentName { get; set; }
    }
}