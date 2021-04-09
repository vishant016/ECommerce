using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Web;


namespace Repository
{
    public class BookRepository
    {
        private ProductDBContext context = new ProductDBContext();

        public List<Book> GetAll()
        {
            return this.context.Books.ToList();
        }

        public bool Insert(Book book)
        {
            Book name = this.context.Books.SingleOrDefault(b => b.Name == book.Name); //Checking if name of the book already exists

            if (name == null)
            {
                var data = this.context.Books.Any();
                if (!data)
                     
                {
                    book.Id = 1;
                   
                    this.context.Books.Add(book);
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    int id = this.context.Books.Max(b => b.Id);
                    book.Id = id + 1;
                    this.context.Books.Add(book);
                    this.context.SaveChanges();
                    return true;
                }
               
            }
            else
            {
                return false;
            }
        }

        public Book Get(int id)
        {
            return this.context.Books.SingleOrDefault(b => b.Id == id);
        }

        public bool Update(Book book, bool warning)
        {
            Book bookToUpdate = this.Get(book.Id);

            Book name = this.context.Books.SingleOrDefault(b => b.Name == book.Name); //Checking if name of the book already exists

            if (name == null || name.Name == bookToUpdate.Name)
            {
                bookToUpdate.Name = book.Name;
                bookToUpdate.Price = book.Price;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Type = book.Type;

                if (!warning)
                {
                    bookToUpdate.ImagePath = book.ImagePath;
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
            Book bookToDelete = this.Get(id);
            this.context.Books.Remove(bookToDelete);
            return this.context.SaveChanges();
        }
    }
}
