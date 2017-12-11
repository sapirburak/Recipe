namespace MVC1.Models.dbcodeF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypesRecips

    {
        public int Id { get; set; }
        public int TypeId { get; set; }
               public int RecipeId { get; set; }
                public virtual List<Recipe> Recipes { get; set; }
                public virtual List<Type> Types { get; set; }
    }
}
