﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Evernote.Entities.Base
{
    public class EntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required, StringLength(30)]
        public string ModifiedUserName { get; set; }
    }
}
