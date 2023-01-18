using System.ComponentModel.DataAnnotations;

namespace Core3_1.ViewModels
{
    public class ProductListItemViewModel
    {
        [Display(Name = "Ürün Stok Numarası")]
        public string ProductId { get; set; }

        [Display(Name = "Öne Çıkan GGörsel")]
        public string FeaturedImage { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public class ContactViewModel
    {
        [Required, MinLength(2), MaxLength(15), Display(Name = "Adınız: ", Prompt = "Adınız: ")]
        public string Firstname { get; set; }

        [MinLength(2), MaxLength(15), Display(Name = "Göbek Adınız: ", Prompt = "Göbek Adınız: ")]
        public string Middlename { get; set; }

        [Required, MinLength(2), MaxLength(15), Display(Name = "Soyadınız: ", Prompt = "Soyadınız: ")]
        public string Lastname { get; set; }

        [Required, EmailAddress, Display(Name = "E-Posta Adresiniz: ", Prompt = "E-Posta Adresiniz: ")]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber), Display(Name = "Telefon Numaranız: ", Prompt = "Telefon Numaranız: ")]
        public string Phone { get; set; }

        [Required, MinLength(5), MaxLength(150), Display(Name = "Konu Başlığı: ", Prompt = "Konu Başlığı: ")]
        public string Subject { get; set; }

        [Required, MinLength(10), MaxLength(1000), DataType(DataType.MultilineText), Display(Name = "Mesajınız: ", Prompt = "Mesajınız: ")]
        public string Message { get; set; }

        [Required, Display(Name = "Koşulları okudum, kabul ediyorum.")]
        public bool AcceptTerms { get; set; }
    }
}
