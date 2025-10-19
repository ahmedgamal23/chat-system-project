using ChatSystemProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystemProject.Domain.Entities
{
    public class MessageStatus
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        [ForeignKey(nameof(MessageId))]
        public virtual Message Message { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public MessageType Status { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
