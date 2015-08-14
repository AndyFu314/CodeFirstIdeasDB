namespace CodeFirstIdeasDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ideas.endorse")]
    public partial class endorse
    {
        public Guid id { get; set; }

        public Guid? idea_id { get; set; }

        [StringLength(45)]
        public string description { get; set; }
    }
}
