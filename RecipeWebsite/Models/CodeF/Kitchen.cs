namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  
    public partial class Kitchen
    {
      [Key]
       public int ID { get; set; }
          [ForeignKey("User")]
        [Column(Order = 1)]
       public string UserName { get; set; }
          [ForeignKey("User")]
          [Column(Order = 2)]
          public string Password { get; set; }
        public virtual List<User> Users { get; set; }
            
    }
}
