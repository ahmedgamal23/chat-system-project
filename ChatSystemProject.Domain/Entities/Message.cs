using ChatSystemProject.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSystemProject.Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public virtual Chat Chat { get; set; }

        public Guid SenderId { get; set; }
        [ForeignKey(nameof(SenderId))]
        public virtual User Sender { get; set; }

        public string? Text { get; set; }

        public DateTime SentAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public FileType MessageType { get; set; }
        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<Attachment> Attachments { get; set; } = new HashSet<Attachment>();
        public virtual ICollection<MessageReaction> MessageReactions { get; set; } = new HashSet<MessageReaction>();
        public virtual ICollection<MessageStatus> MessageStatuses { get; set; } = new HashSet<MessageStatus>();
    }
}
