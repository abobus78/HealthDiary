namespace HealthDiary.Helpers
{
    public class Validation
    {
        public static bool NameValidator(string name) => string.IsNullOrEmpty(name) ? false : true;
        public static bool ParamsValidator(decimal aboba) => decimal.IsPositive(aboba) ? true : false;
        public static bool IntParamsValidator(int abobus) => int.IsPositive(abobus) ? true : false;
    }
}
