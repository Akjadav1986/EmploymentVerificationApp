using EmploymentVerificationApi.Models;

namespace EmploymentVerificationApi.Repository
{
    public interface IEmployeeRepository
    {
        List<VerifyEmployeeModel> GetAllEmployee();
        bool ValidateEmployee(VerifyEmployeeModel verifyEmployeeModel);
        string VerifyCode(string code);
    }
}
