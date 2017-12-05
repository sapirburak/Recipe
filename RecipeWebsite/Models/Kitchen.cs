namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  
    public partial class Kitchen
    {
            public int IdKitchen { get; set; }
            public int IdUser { get; set; }
    }
}
