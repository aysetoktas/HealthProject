using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class Query
    {
        private static HPContext db = new HPContext();

        public static List<User> UserList()
        {
            return db.Users.AsNoTracking().ToList();
        }
        public static List<Product> ProductList()
        {
            return db.Products.AsNoTracking().ToList();
        }
        public static List<Category> CategoryList()
        {
            return db.Categories.AsNoTracking().ToList();
        }
        public static List<Article> ArticleList()
        {
            return db.Articles.AsNoTracking().ToList();
        }

    }
}