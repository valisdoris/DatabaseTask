﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Tervisekontroll
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime TerviseKontrolliKP { get; set; }
        public string Meditsiiniasutus { get; set; }
        public string KahjulikudTegurid { get; set; }
        public string? Kommentaar { get; set; }
    }
}
