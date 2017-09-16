using System;
using System.Collections.Generic;
using System.Text;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    public class Category : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<DNote> Notes { get; set; }
    }
}
