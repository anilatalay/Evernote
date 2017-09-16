using System;
using System.Collections.Generic;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    public class DUser: EntityBase
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivateGuid { get; set; }
        public bool IsAdmin { get; set; }

        public virtual  List<DNote> Notes { get; set; }
        public virtual  List<DComment> Comments { get; set; }
        public List<DLiked> Likes { get; set; }
    }
}
