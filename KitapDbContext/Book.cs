using Kitap.arama;
using Kitap.arama.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kütüphane.Entitiy
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100)]
        public string KitapAdı { get; set; }
        public virtual Müşteri? Müşteri { get; set; }
        public Kategori Kategori { get; set; }

    }
}
