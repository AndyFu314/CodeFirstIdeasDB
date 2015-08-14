namespace CodeFirstIdeasDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ideas.user")]
    public partial class user
    {
        public Guid id { get; set; }

        [StringLength(45)]
        public string name { get; set; }

        public int? age { get; set; }

        [StringLength(45)]
        public string discriminator { get; set; }

        public Guid? link_id { get; set; }

        public Guid? key_id { get; set; }
    }
}
