using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public enum Role
    {
        Admin,
        Uzman,
        Ziyaretçi
    }
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string PhoneNumber { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        //?? adresler burada olmasın başka yere al.
        public string? Facebook { get; set; }//nullable
        public string? Instagram { get; set; }//nullable
        public string? Linkedin { get; set; }//nullable
        public string? Picture { get; set; }//nullable

        public virtual ICollection<Product> Products { get; set; }



    }
}