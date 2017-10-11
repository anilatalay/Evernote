using System;
using System.Linq;
using Evernote.DataAccessLayer;
using Evernote.Entities;

namespace Evernote.BusinessLayer
{
    public class Test
    {
        private Repository<DCategory> repo_category = new Repository<DCategory>();
        private Repository<DUser> repo_user = new Repository<DUser>();

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
    }
}
