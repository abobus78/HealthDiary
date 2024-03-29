﻿namespace HealthDiary.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public PhysicalCharacteristics? PhysicalCharacteristics { get; set; }
        public PhysicalProfile? PhysicalProfile { get; set; }
    }
}
