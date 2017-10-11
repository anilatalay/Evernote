using System;
using Evernote.DataAccessLayer.EntityFramework;
using Evernote.Entities;

namespace Evernote.BusinessLayer
{
    public class Test
    {
        private Repository<DCategory> repo_category = new Repository<DCategory>();
        private Repository<DUser> repo_user = new Repository<DUser>();
        private Repository<DComment> repo_comment = new Repository<DComment>();
        private Repository<DNote> repo_note = new Repository<DNote>();

        public Test()
        {
            var data = repo_category.List();
        }

        public void InsertTest()
        {
            var user = new DUser
            {
                Name = "Refik",
                SurName = "Seven",
                Email = "refik.seven@test.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                UserName = "refikseven",
                Password = "123456",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUserName = "anilatalay"
            };

            var result = repo_user.Insert(user);
        }

        public void UpdateTest()
        {
            var user = repo_user.Find(x => x.UserName == "refik");
            if (user != null)
            {
                user.UserName = "Vedat";
                var result = repo_user.Update(user);
            }
        }

        public void CommentTest()
        {
            var user = repo_user.Find(x => x.Id == 1);
            var note = repo_note.Find(x => x.Id == 1);

            var comment = new DComment
            {
                Text = "Bu bir test'dir.",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                Note = note,
                User = user
            };

            repo_comment.Insert(comment);
        }
    }
}
