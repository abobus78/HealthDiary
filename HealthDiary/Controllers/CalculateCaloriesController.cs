using HealthDiary.Dto.CaloryCalculator;
using HealthDiary.Helpers;
using HealthDiary.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HealthDiary.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace HealthDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateCaloriesController : ControllerBase
    {
        private readonly ICalculateCaloriesService _calculateCaloriesService;
        public CalculateCaloriesController(ICalculateCaloriesService calculateCaloriesService)
        {
            _calculateCaloriesService = calculateCaloriesService;
        }

        [HttpPost("CalorieCalculator")]
        public async Task<ActionResult> CalculateUserParams(int userID, CalculateMetabolismDto humanParameteres)
        {
            bool response = Validation.ParamsValidator(humanParameteres.Height) && Validation.ParamsValidator(humanParameteres.Weight) && Validation.IntParamsValidator(humanParameteres.Age) ? true : false;
            
            int statusCode = response ? 200 : 400;
            
            await _calculateCaloriesService.CalculateUserParams(userID, humanParameteres);

            return StatusCode(statusCode);
        }

        [HttpPost("UpdateCalories")]
        public async Task<ActionResult> UpdateUserParams(int userID, CalculateMetabolismDto humanParameteres)
        {
            bool response = Validation.ParamsValidator(humanParameteres.Height) && Validation.ParamsValidator(humanParameteres.Weight) && Validation.IntParamsValidator(humanParameteres.Age) ? true : false;

            int statusCode = response ? 200 : 400;

            await _calculateCaloriesService.UpdateUserParams(userID, humanParameteres);

            return StatusCode(statusCode);
        }
    }
}
