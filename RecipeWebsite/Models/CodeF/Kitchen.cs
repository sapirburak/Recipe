namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  
    public partial class Kitchen
    {
            public virtual int IdKitchen { get; set; }
            public virtual int IdUser { get; set; }
    }
}
