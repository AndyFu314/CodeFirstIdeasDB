namespace CodeFirstIdeasDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ideas.idea")]
    public partial class idea
    {
        public Guid id { get; set; }

        [StringLength(45)]
        public string title { get; set; }

        public int? status { get; set; }
    }
}
