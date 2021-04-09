using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Repository
{
    public class ClothRepository
    {
        private ProductDBContext context = new ProductDBContext();

        public List<Cloth> GetAll()
        {
            return this.context.Cloths.ToList();
        }

        public bool Insert(Cloth cloth)
        {
            Cloth name = this.context.Cloths.SingleOrDefault(c => c.Name == cloth.Name); //Checking if name of the book already exists

            if (name == null)
            {
                var data = this.context.Cloths.Any();
                if (!data)

                {
                     cloth.Id = 1;

                    this.context.Cloths.Add(cloth);
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    int id = this.context.Cloths.Max(b => b.Id);
                    cloth.Id = id + 1;
                    this.context.Cloths.Add(cloth);
                    this.context.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public Cloth Get(int id)
        {
            return this.context.Cloths.SingleOrDefault(c => c.Id == id);
        }

        public bool Update(Cloth cloth, bool warning)
        {
            Cloth clothToUpdate = this.Get(cloth.Id);

            Cloth name = this.context.Cloths.SingleOrDefault(c => c.Name == cloth.Name); //Checking if name of the cloth already exists

            if (name == null || name.Name == clothToUpdate.Name)
            {
                clothToUpdate.Name = cloth.Name;
                clothToUpdate.Type = cloth.Type;
                clothToUpdate.Price = cloth.Price;

                if (!warning)
                {
                    clothToUpdate.ImagePath = cloth.ImagePath;
                }

                this.context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public int Delete(int id)
        {
            Cloth clothToDelete = this.Get(id);
            this.context.Cloths.Remove(clothToDelete);
            return this.context.SaveChanges();
        }
    }
}
