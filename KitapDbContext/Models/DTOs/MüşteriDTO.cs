using System.ComponentModel.DataAnnotations;

namespace Kitap.arama.Models.DTOs
{
    public class MüşteriDTO
    {
        [StringLength(100)]
        public string MüşteriAd { get; set; }
        [StringLength(100)]
        public string MüşteriSoyAd { get; set; }
        public int KiralananKitapSayısı { get; set; }

        public int OkunanKitapSayısı { get; set; }
        public List<int>? BookIds { get; set; }
    }
}
