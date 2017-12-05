namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
                public int IdUser { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
       public string Email { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthdayDate { get; set; }
        public int? Age { get; set; }
    }
}
