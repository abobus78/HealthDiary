using HealthDiary.Dto.User;
using HealthDiary.Entities;

namespace HealthDiary.Interfaces
{
    public interface IRegistrationService
    {
        Task Registration(RegistrationDto newUser);
        Task<User> Login(LoginDto login);
    }
}
