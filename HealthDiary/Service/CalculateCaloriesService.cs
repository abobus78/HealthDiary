using HealthDiary.Dto.CaloryCalculator;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using HealthDiary.Context;
using HealthDiary.Dto.CaloryCalculator;
using HealthDiary.Entities;
using HealthDiary.Interfaces;
using static HealthDiary.Entities.User;
using HealthDiary.Dto;
using HealthDiary.Helpers;
using HealthDiary.IGenericRepositories;
using Microsoft.Extensions.FileProviders.Physical;

namespace HealthDiary.Service
{
    public class CalculateCaloriesService : ICalculateCaloriesService
    {
        private readonly IGenericRepo<PhysicalProfile> _physicalHealthProfileRepository;
        private readonly IGenericRepo<User> _userRepository;
        public CalculateCaloriesService(IGenericRepo<PhysicalProfile> physicalHealthProfileRepository, IGenericRepo<User> userRepository)
        {
            _physicalHealthProfileRepository = physicalHealthProfileRepository;
            _userRepository = userRepository;
        }
        public async Task CalculateUserParams(int userID, CalculateMetabolismDto humanParameteres)
        {
            var physicalHealthProfile = new PhysicalProfile();
            physicalHealthProfile.UserID = userID;
            bool userExist = physicalHealthProfile != null ? true : false;

            if (userExist)
            {
                physicalHealthProfile.StaticWeight = Calculation.MetabolismCalculation(humanParameteres) * Select.GetActivityFromUser(humanParameteres);
                physicalHealthProfile.LoseWeight = Calculation.MetabolismCalculation(humanParameteres) * Select.GetActivityFromUser(humanParameteres) - Select.GetLoseWeight(humanParameteres);
                physicalHealthProfile.GainWeight = Calculation.MetabolismCalculation(humanParameteres) * Select.GetActivityFromUser(humanParameteres) + Select.GetGainWeight(humanParameteres);

            }
            await _physicalHealthProfileRepository.AddAsync(physicalHealthProfile);

        }

        public async Task UpdateUserParams(int userID, CalculateMetabolismDto humanParameteres)
        {
            var user = await _userRepository.GetByIdAsync(userID);
            var physicalHealthProfile = _physicalHealthProfileRepository.GetAllAsyncQuery().FirstOrDefault(x => x.UserID == userID);
            bool userExist = user != null ? true : false;

            if (userExist)
            {
                physicalHealthProfile.UserID = userID;
                physicalHealthProfile.StaticWeight = Calculation.MetabolismCalculation(humanParameteres) * Select.GetActivityFromUser(humanParameteres);
                physicalHealthProfile.LoseWeight = Calculation.MetabolismCalculation(humanParameteres) * Select.GetActivityFromUser(humanParameteres) - Select.GetLoseWeight(humanParameteres);
                physicalHealthProfile.GainWeight = Calculation.MetabolismCalculation(humanParameteres) * Select.GetActivityFromUser(humanParameteres) + Select.GetGainWeight(humanParameteres);

            }
            await _physicalHealthProfileRepository.Update(physicalHealthProfile);

        }

    }

}
