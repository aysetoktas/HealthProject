using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class Article:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Yazar { get; set; }
        public DateTime Tarih { get; set; }
        public string Etiket { get; set; }
        public string Kaynakca { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}