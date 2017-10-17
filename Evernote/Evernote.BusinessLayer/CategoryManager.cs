using System.Collections.Generic;
using Evernote.DataAccessLayer.EntityFramework;
using Evernote.Entities;

namespace Evernote.BusinessLayer
{
    public class CategoryManager
    {
        private Repository<DCategory> repo_category = new Repository<DCategory>();

        public List<DCategory> GetCategories()
        {
            return repo_category.List();
        }

        public DCategory GetDCategoryById(int id)
        {
            return repo_category.Find(x => x.Id == id);
        }
    }
}
