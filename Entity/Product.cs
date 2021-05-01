using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }  
        //Paketlerin kullanım süresi (aylık vs.)

    }
}