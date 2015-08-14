namespace CodeFirstIdeasDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ideas.userkey")]
    public partial class userkey
    {
        public Guid id { get; set; }

        [StringLength(45)]
        public string keyname { get; set; }
    }
}
