namespace HealthDiary.Dto.User
{
    public class CreateUserDto
    {
        public bool isCreated { get; set; }
        public string Status { get; set; }
        public int Code { get; set; }
        public CreateUserDto() 
        {
            isCreated = false;
            Status = string.Empty;
            Code = 0;
        }

    }
}
