using HealthDiary.Dto.CaloryCalculator;

namespace HealthDiary.Helpers
{
    public class Calculation
    {
        public static decimal MetabolismCalculation(CalculateMetabolismDto calculateMetabolismDto) => 
            (calculateMetabolismDto.Weight * 10 + calculateMetabolismDto.Height * 6.25m - calculateMetabolismDto.Age * 5) + 5;
    }
}
