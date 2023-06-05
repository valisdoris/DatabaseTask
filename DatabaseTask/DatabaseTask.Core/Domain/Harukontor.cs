using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Harukontor
    {
        [Key]
        public Guid Id { get; set; }
        public Firma Firma { get; set; }
        public string Nimi { get; set; }
        public string RegKood { get; set; }
        public string Aadress { get; set; }
        public int Kontakttelefon { get; set; }
        public string KontaktEmail { get; set; }

        public ICollection<Osakond> Osakonds { get; set; }
        public ICollection<LaenutatavEse> LaenutatavEses { get; set; }
    }
}
