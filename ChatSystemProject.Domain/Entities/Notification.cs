using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystemProject.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public Guid ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public virtual Chat Chat { get; set; }

        public Guid SenderId { get; set; }
        [ForeignKey(nameof(SenderId))]
        public virtual User Sender { get; set; }

        public Guid RecieverId { get; set; }
        [ForeignKey(nameof(RecieverId))]
        public virtual User Reciever { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
