using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BusinessLayer.Commands;
using BusinessLayer.Queries;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly ContextDA _context;
        private static Manager _manager = null;

        public Manager()
        {
            _context = new ContextDA();
        }

        public static Manager Instance
        {
            get
            {
                if (_manager == null)
                    _manager = new Manager();
                return _manager;
            }
        }

        public List<Product> GetAllProduct()
        {
            ProductQuery pq = new ProductQuery(_context);
            return pq.GetAll().ToList();
        }


        public int CreateProduct(Product p)
        {
            ProductCommand pc = new ProductCommand(_context);
            return pc.Create(p);
        }

        public void UpdateProduit(Product p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProductCommand pc = new ProductCommand(_context);
            pc.Update(p);
        }

        public void DeleteProduit(int produitID)
        {
            ProductCommand pc = new ProductCommand(_context);
            pc.Delete(produitID);
        }

        public List<Category> GetAllCategory()
        {
            CategoryQuery pq = new CategoryQuery(_context);
            return pq.GetAll().ToList();
        }
    }
}
