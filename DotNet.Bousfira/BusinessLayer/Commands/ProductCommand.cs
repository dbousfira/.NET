using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer.Commands
{
    public class ProductCommand
    {
        private ContextDA _context;

        public ProductCommand(ContextDA context)
        {
            _context = context;
        }

        public int Create(Product p)
        {
            _context.Products.Add(p);
            return _context.SaveChanges();
        }

        public void Update(Product p)
        {
            Product upPrd = _context.Products.Where(prd => prd.ID == p.ID).FirstOrDefault();

            if (upPrd != null)
            {
                upPrd.Name = p.Name;
                upPrd.CategoryID = p.CategoryID;
            }

            _context.SaveChanges();
        }

        public void Delete(int ID)
        {
            Product delPrd = _context.Products.Where(prd => prd.ID == ID).FirstOrDefault();
            if (delPrd != null)
            {
                _context.Products.Remove(delPrd);
            }
            _context.SaveChanges();
        }
    }
}
