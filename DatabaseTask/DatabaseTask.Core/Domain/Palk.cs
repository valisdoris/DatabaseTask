using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Palk
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Arvestuskuu { get; set; }
        public int ArvestatudSumma { get; set; }
        public int? TulumaksuvabaMin { get; set; }
        public string? Kommentaar { get; set; }
        public decimal KinnipeetudTm { get; set; }
        public decimal Väljamakse { get; set; }
        public DateTime VäljamakseKp { get; set; }
        public string Kontonumber { get; set; }

        public ICollection<PalgaarvestuseRead> PalgaarvestuseReads { get; set; }
    }
}
