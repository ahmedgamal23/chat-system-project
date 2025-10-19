using System.ComponentModel.DataAnnotations.Schema;


namespace ChatSystemProject.Domain.Entities
{
    public class BlockedUser
    {
        public int Id { get; set; }

        public Guid BlockedUserId { get; set; }
        [ForeignKey(nameof(BlockedUserId))]
        public virtual User BlockedUserEntity { get; set; }

        public Guid BlockedByUserId { get; set; }
        [ForeignKey(nameof(BlockedByUserId))]
        public virtual User BlockedByUser { get; set; }

        public DateTime BlockedAt { get; set; }
    }
}
