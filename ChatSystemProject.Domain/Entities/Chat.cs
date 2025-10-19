using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSystemProject.Domain.Entities
{
    public class Chat
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsGroup { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Message> Messages { get; set; } = new HashSet<Message>();
        public virtual ICollection<ChatParticipants> ChatParticipants { get; set; } = new HashSet<ChatParticipants>();
    }
}
