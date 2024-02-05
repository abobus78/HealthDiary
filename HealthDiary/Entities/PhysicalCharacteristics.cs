namespace HealthDiary.Entities
{
    public class PhysicalCharacteristics : BaseEntity
    {
        public decimal Height { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
