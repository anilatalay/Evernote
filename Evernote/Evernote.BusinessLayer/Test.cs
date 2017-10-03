using Evernote.DataAccessLayer;
using Evernote.Entities;

namespace Evernote.BusinessLayer
{
    public class Test
    {
        public Test()
        {
            var db = new DatabaseContext();
            db.Database.CreateIfNotExists();
        }
    }
}
