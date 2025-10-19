using ChatSystemProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystemProject.Domain.Entities
{
    public class UserStatus
    {
        public int Id { get; set; }
        public UserStatusType UserStatusType { get; set; }
        public DateTime StatusAt { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
