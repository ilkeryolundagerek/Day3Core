using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core3_1.Entities
{
    //Entity: Varlık anlamına gelir. Genelde EntityFramework kurgularında kullanırız.
    //Eklenen attribute yapıları tamamen eğer bu modelden bir db tablo oluşturacaksam yararlıdır.
    [Table("tbl_product")]
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
    }
}
