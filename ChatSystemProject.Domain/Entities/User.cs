using Microsoft.AspNetCore.Identity;

namespace ChatSystemProject.Domain.Entities
{
    public class User: IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ImageProfilePath { get; set; } = string.Empty;
        public UserStatus UserStatus { get; set; }
        public virtual ICollection<ChatParticipants> ChatParticipants { get; set; } = new HashSet<ChatParticipants>();
        public virtual ICollection<Message> Messages { get; set; }  = new HashSet<Message>();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastSeen { get; set; }
    }
}
