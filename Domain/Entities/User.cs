using System;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public Guid? TenantId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
