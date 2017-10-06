using System.Linq;
using Evernote.DataAccessLayer;
using Evernote.Entities;

namespace Evernote.BusinessLayer
{
    public class Test
    {
        public Test()
        {
            Repository<DCategory> repo = new Repository<DCategory>();
            var data = repo.List();
        }

        public void InsertTest()
        {
            var repo = new Repository<DCategory>();
            
        }
    }
}
