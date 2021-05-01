using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public enum Role
    {
        Admin,
        Expert,
        Visitor
    }
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        //?? adresler burada olmasın başka yere al.
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }



    }
}