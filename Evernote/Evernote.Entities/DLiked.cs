using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evernote.Entities
{
    [Table("Likes")]
    public class DLiked
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual DNote Note{ get; set; }
        public virtual DUser User { get; set; }
    }
}
