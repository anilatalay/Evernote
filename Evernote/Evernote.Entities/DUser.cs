using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Evernote.Entities.Base;

namespace Evernote.Entities
{
    [Table("Users")]
    public class DUser: EntityBase
    {
        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(25)]
        public string SurName { get; set; }

        [Required, StringLength(25)]
        public string UserName { get; set; }

        [Required, StringLength(70)]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public Guid ActivateGuid { get; set; }

        public bool IsAdmin { get; set; }

        public virtual  List<DNote> Notes { get; set; }
        public virtual  List<DComment> Comments { get; set; }
        public List<DLiked> Likes { get; set; }
    }
}
