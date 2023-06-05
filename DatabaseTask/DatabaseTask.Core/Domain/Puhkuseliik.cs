using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Puhkuseliik
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public bool LiikKasutuses { get; set; }
        public int PuhkusepäevadeArv { get; set; }
        public string MKommentaar { get; set; }

        public ICollection<Puhkus> Puhkus { get; set; }
    }
}
