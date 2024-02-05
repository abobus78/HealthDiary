using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using HealthDiary.Context;
using HealthDiary.Dto.User;
using HealthDiary.Entities;
using HealthDiary.Interfaces;
using HealthDiary.IGenericRepositories;

namespace HealthDiary.Service
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IGenericRepo<User> _accountRepo;
        public RegistrationService(IGenericRepo<User> accountRepo)
        {
            _accountRepo = accountRepo;
        }
        public async Task Registration(RegistrationDto newUser)
        {
                User user = new User
                {
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Email = newUser.Email,
                    Password = newUser.Password,
                };
            await _accountRepo.AddAsync(user);
        }
        public async Task<User> Login(LoginDto login)
        {
            return await _accountRepo.GetAllAsyncQuery().FirstOrDefaultAsync(x => x.Email == login.Email && x.Password == login.Password);
        }
    }
}
