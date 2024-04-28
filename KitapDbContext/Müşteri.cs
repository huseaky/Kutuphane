using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kütüphane.Entitiy;

namespace Kitap.arama
{
    public class Müşteri
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MüşteriID { get; set; }
        [StringLength(100)]
        public string MüşteriAd { get; set; }
        [StringLength(100)]
        public string MüşteriSoyAd { get; set; }
        public int KiralananKitapSayısı { get; set; }
       
        public int OkunanKitapSayısı { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        



    }

}
