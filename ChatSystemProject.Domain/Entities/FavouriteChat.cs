using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystemProject.Domain.Entities
{
    public class FavouriteChat
    {
        public int Id { get; set; }
        public Guid ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public virtual Chat Chat { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        public DateTime FavoritedAt { get; set; }
    }
}
