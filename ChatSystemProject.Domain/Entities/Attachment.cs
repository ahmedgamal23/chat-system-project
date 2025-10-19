using ChatSystemProject.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSystemProject.Domain.Entities
{
    public class Attachment
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        [ForeignKey(nameof(MessageId))]
        public virtual Message Message { get; set; }

        public string FilePath { get; set; } = string.Empty;
        public FileType FileType { get; set; }
        public double Size { get; set; }
    }
}
