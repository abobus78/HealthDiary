using Microsoft.AspNetCore.SignalR;
using HealthDiary.Dto.CaloryCalculator;

namespace HealthDiary.Interfaces
{
    public interface ICalculateCaloriesService
    {
        Task CalculateUserParams(int userID, CalculateMetabolismDto humanParameteres);

        Task UpdateUserParams(int userID, CalculateMetabolismDto humanParameteres);
/*        Task CalculateLoseWeightCalories();
        Task CalculateGainWeightCalories();*/
    }
}
