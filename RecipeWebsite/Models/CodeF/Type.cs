namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class Type
    {
           public string TypeName { get; set; }
                public int Id { get; set; }
    }
}
