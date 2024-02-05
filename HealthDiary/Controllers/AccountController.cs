using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using HealthDiary.Interfaces;
using HealthDiary.Dto.User;
using HealthDiary.Entities;
using HealthDiary.Helpers;

namespace HealthDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;
        public AccountController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }
        
        [HttpGet("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            bool response = Validation.NameValidator(loginDto.Email) && Validation.NameValidator(loginDto.Password) ? true : false;

            int statusCode = response && await _registrationService.Login(loginDto) != null ? 200 : 400;

            return StatusCode(statusCode);

        }

        [HttpPost("Register")]
        public async Task<ActionResult> Registration(RegistrationDto registrationDto)
        {
            bool response = Validation.NameValidator(registrationDto.FirstName) && Validation.NameValidator(registrationDto.LastName)
                 && Validation.NameValidator(registrationDto.Email) && Validation.NameValidator(registrationDto.Password) ? true : false;

            int statusCode = response ? 200 : 400;

            await _registrationService.Registration(registrationDto);

            return StatusCode(statusCode);
        }


    }
}