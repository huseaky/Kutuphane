﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Çalışanlar
{
    public class Worder
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkerID { get; set; }
        [StringLength(100)]
        public string WorkerName { get; set; }
        [StringLength(100)]
        public string WorkerSurName { get; set; }
        [StringLength(100)]
        public string WorkerDepertmant { get; set; }
    }
}
