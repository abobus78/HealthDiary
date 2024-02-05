namespace HealthDiary.Entities
{
    public class PhysicalProfile : BaseEntity
    {
        public decimal Metabolism { get; set; }
        public decimal StaticWeight { get; set; }
        public decimal LoseWeight { get; set; }
        public decimal GainWeight { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
