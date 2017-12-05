namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
               public int IdProduct { get; set; }
                public string Name { get; set; }
                public string KosherType { get; set; }
                public int? Calorie { get; set; }
                public bool? Gluten { get; set; }
                public bool? Vegan { get; set; }
                    public decimal? Price { get; set; }
    }
}
