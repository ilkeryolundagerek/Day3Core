using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core3_1.Entities
{
    [Table("tbl_category")]
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
