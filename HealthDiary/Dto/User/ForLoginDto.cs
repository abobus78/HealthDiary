namespace HealthDiary.Dto.User
{
    public class ForLoginDto
    {
        public bool IsLoggedIn { get; set; }
        public int Code { get; set; }
        public string Status {  get; set; }
        public ForLoginDto()
        {
            IsLoggedIn = false;
            Status = string.Empty;
            Code = 0;
        }
    }
}
