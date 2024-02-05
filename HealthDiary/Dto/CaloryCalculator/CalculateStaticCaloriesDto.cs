namespace HealthDiary.Dto.CaloryCalculator
{
    public class CalculateStaticCaloriesDto
    {
        public string Email { get; set; }
        public decimal Metabolism { get; set; }
        public ActivityDto Activity { get; set; }
    }
}
