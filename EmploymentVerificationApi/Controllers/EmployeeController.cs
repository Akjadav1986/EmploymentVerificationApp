using EmploymentVerificationApi.Models;
using EmploymentVerificationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerificationApi.Controllers
{    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }
        [Route("api/verify-employment")]
        [HttpPost]
        public IActionResult VerifyEmployee([FromBody]VerifyEmployeeModel verifyEmployeeModel)
        {
            var result = _employeeRepository.ValidateEmployee(verifyEmployeeModel);
            if (result)
            {
                var isVerify = _employeeRepository.VerifyCode(verifyEmployeeModel.VerificationCode);
                return Ok(isVerify);
            }
            else
            {
                return Ok("Not Verified");
            }
        }
    }
}
