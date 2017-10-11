using System;
using System.Data.Entity;
using Evernote.Entities;

namespace Evernote.DataAccessLayer.EntityFramework
{
    public class MyInitializer: CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            // adding admin user
            var userAdmin = new DUser
            {
                Name = "Anıl",
                SurName = "Atalay",
                Email = "anilatalay@hotmail.com.tr",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                UserName = "anilatalay",
                Password = "123456",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUserName = "anilatalay"
            };

            // adding normal user
            var userNormal = new DUser
            {
                Name = "Anıl",
                SurName = "Atalay",
                Email = "anil@anilatalay.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                UserName = "atalayanil",
                Password = "654321",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUserName = "anilatalay"
            };

            context.Users.Add(userAdmin);
            context.Users.Add(userNormal);

            context.SaveChanges();
        }
    }
}
