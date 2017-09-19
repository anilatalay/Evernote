using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    [Table("Comments")]
    public class DComment : EntityBase
    {
        [Required, StringLength(300)]
        public string Text { get; set; }

        public virtual DNote Note { get; set; }
        public virtual DUser User { get; set; }
    }
}
