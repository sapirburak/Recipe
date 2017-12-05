namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

 
    public partial class Recipe
    {
          public int IdRecipe { get; set; }
                public string Name { get; set; }
                public string KosherType { get; set; }
        
                public decimal? Price { get; set; }
                public int? Calorie { get; set; }
                public string Instructions { get; set; }
                public string Tip { get; set; }
                public DateTime? PreparationTime { get; set; }
                public int? IdUserOwner { get; set; }
    }
}
