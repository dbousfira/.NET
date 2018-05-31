using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer.Queries
{
    public class ProductQuery
    {
        private readonly ContextDA _context;

        public ProductQuery(ContextDA contexte)
        {
            _context = contexte;
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public IQueryable<Product> GetByID(int id)
        {
            return _context.Products.Where(p => p.ID == id);
        }
    }
}
