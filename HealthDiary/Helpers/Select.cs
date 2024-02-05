using HealthDiary.Dto.CaloryCalculator;

namespace HealthDiary.Helpers
{
    public static class Select
    {
        public static decimal GetActivityFromUser(CalculateMetabolismDto activityDto)
        {
            ActivityDto activity = activityDto.Activity;
            return activity switch
            {
                ActivityDto.Min => 1.2m,
                ActivityDto.Basic => 1.55m,
                ActivityDto.Max => 1.9m,
                _ => throw new ArgumentException("Invalid activity level."),
            };
        }

        public static decimal GetLoseWeight(CalculateMetabolismDto loseWeightDto)
        {
            LoseWeightDto loseWeight = loseWeightDto.LoseWeight;
            return loseWeight switch
            {
                LoseWeightDto.Low => 250m,
                LoseWeightDto.Medium => 500m,
                LoseWeightDto.High => 750m,
                LoseWeightDto.Extremal => 1000m,
                _ => 0m
            };
        }
        public static decimal GetGainWeight(CalculateMetabolismDto gainWeightDto)
        {
            GainWeightDto gainWeight = gainWeightDto.GainWeight;
            return gainWeight switch
            {
                GainWeightDto.Low => 250m,
                GainWeightDto.Medium => 500m,
                GainWeightDto.High => 750m,
                GainWeightDto.Extremal => 1000m,
                _ => 0m
            };
        }
    }
}
