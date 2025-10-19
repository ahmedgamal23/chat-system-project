using ChatSystemProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystemProject.Domain.Entities
{
    public class MessageReaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReactionPath { get; set; }
        public ReactionType ReactionType { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public int MessageId { get; set; }
        [ForeignKey(nameof(MessageId))]
        public Message Message { get; set; }
    }
}
