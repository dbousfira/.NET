using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer.Queries
{
    public class CategoryQuery
    {
        private readonly ContextDA _context;

        public CategoryQuery(ContextDA contexte)
        {
            _context = contexte;
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories;
        }

        public IQueryable<Category> GetByID(int id)
        {
            return _context.Categories.Where(c => c.ID == id);
        }
    }
}
