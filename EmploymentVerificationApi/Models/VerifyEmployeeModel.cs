namespace EmploymentVerificationApi.Models
{
    public class VerifyEmployeeModel
    {       
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }

    public class VerificationResponse
    {
        public int EmployeeId { get; set; }
        public bool IsVerified { get; set; }

    }
}
