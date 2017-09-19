using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    [Table("Notes")]
    public class DNote : EntityBase
    {
        [Required, StringLength(60)]
        public string Title { get; set; }

        [Required, StringLength(2000)]
        public string Text { get; set; }
        public bool IsDraft { get; set; }
        public int LikeCount { get; set; }
        public int CategoryId { get; set; }

        public virtual DUser User { get; set; }
        public virtual  List<DComment> Comments { get; set; }
        public virtual DCategory Category { get; set; }
        public List<DLiked> Likes { get; set; }
    }
}
