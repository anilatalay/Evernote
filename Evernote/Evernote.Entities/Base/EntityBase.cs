using System;
using System.Collections.Generic;
using System.Text;

namespace Evernote.Entities.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedUserName { get; set; }
    }
}
