namespace QuanLyQuanTraSua.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string NameOrder { get; set; }

        public int idCategory { get; set; }

        public double price { get; set; }

        public virtual Category Category { get; set; }
    }
}
