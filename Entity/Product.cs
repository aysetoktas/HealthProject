using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public enum Time
    {
        Tek,
        Aylık,
        Yıllık
    }
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        //Paketlerin kullanım süresi (aylık vs.)
        public Time Time { get; set; }
        //Pakete ait 5 Özelik
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}