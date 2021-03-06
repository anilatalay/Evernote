﻿using System.Collections.Generic;
using Evernote.DataAccessLayer.EntityFramework;
using Evernote.Entities;
using System.Linq;

namespace Evernote.BusinessLayer
{
    public class NoteManager
    {
        private Repository<DNote> repo_note = new Repository<DNote>();

        public List<DNote> GetAllNote()
        {
            return repo_note.List();
        }

        public IQueryable<DNote> GetAllNoteQueryable()
        {
            return repo_note.ListQueryable();
        }
    }
}
