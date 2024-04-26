using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama
{
    public class Sube
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ŞubeID { get; set; }
        [StringLength(100)]
        public string ŞubeUlke { get; set; }
        [StringLength(100)]
        public string ŞubeMahalle { get; set; }
        [StringLength(100)]
        public string ŞubeKpaıNo { get; set; }
        [StringLength(100)]
        public string ŞubeSokak { get; set; }
    }
}
