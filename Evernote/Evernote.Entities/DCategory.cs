using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    [Table("Categories")]
    public class DCategory : EntityBase
    {
        [Required, StringLength(50)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public virtual List<DNote> Notes { get; set; }

        public DCategory()
        {
            Notes = new List<DNote>();
        }
    }
}
