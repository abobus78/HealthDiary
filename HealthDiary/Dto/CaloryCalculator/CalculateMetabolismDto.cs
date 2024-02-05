namespace HealthDiary.Dto.CaloryCalculator
{
    public class CalculateMetabolismDto
    {
        public ActivityDto Activity { get; set; }
        public LoseWeightDto LoseWeight { get; set; }
        public GainWeightDto GainWeight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
    }
}
