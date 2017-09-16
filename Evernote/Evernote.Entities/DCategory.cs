using System.Collections.Generic;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    public class DCategory : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<DNote> Notes { get; set; }
    }
}
