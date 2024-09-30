using EmploymentVerificationApi.Models;
using System.Collections.Generic;

namespace EmploymentVerificationApi.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public List<VerifyEmployeeModel> GetAllEmployee()
        {
            List<VerifyEmployeeModel> employees = new List<VerifyEmployeeModel>();
            employees.Add(new VerifyEmployeeModel() { EmployeeId=1001, CompanyName= "Microsoft(P).Ltd", VerificationCode="123789"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=2001, CompanyName= "Samsung(P).Ltd", VerificationCode="741258"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=3001, CompanyName="Alpha(P).Ltd", VerificationCode="852963"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=4001, CompanyName="Microsoft(P).Ltd", VerificationCode="321456"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=5001, CompanyName="Google(P).Ltd", VerificationCode="951753"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=6001, CompanyName="Facebook(P).Ltd", VerificationCode="357159"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=2002, CompanyName="Samsung(P).Ltd", VerificationCode="852456"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=2003, CompanyName= "Samsung(P).Ltd", VerificationCode="971358"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=3002, CompanyName= "Alpha(P).Ltd", VerificationCode="426851"});
            employees.Add(new VerifyEmployeeModel() { EmployeeId=5002, CompanyName= "Google(P).Ltd", VerificationCode="964125"});
            return employees;
        }

        public bool ValidateEmployee(VerifyEmployeeModel verifyEmployeeModel)
        {
            var employee = GetAllEmployee()
                .Where(x => x.EmployeeId == verifyEmployeeModel.EmployeeId 
                && x.CompanyName == verifyEmployeeModel.CompanyName).Count() > 0;

            return employee;
        }

        public string VerifyCode(string code)
        {
            var isVerify = GetAllEmployee().Where(x=>x.VerificationCode==code).Count() > 0;
            return isVerify ? "Verified" : "Not Verified";
        }
    }
}
