using System.Collections.Generic;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    public class DNote : EntityBase
    {
        public string Title { get; set; }
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
