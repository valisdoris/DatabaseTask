using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Firma
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimi { get; set; }
        public string RegKood { get; set; }
        public Riik Riik { get; set; }
        public string Aadress { get; set; }
        public int Kontakttelefon { get; set; }
        public string KontaktEmail { get; set; }

        public ICollection<Vihje>? Vihjes { get; set; }
        public ICollection<Harukontor> Harukontors { get; set; }
    }
}
