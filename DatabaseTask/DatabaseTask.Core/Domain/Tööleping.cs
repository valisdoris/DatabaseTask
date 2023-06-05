using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Tööleping
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Alguskuupäev { get; set; }
        public DateTime? Lõppkuupäev { get; set; }
        public DateTime KoostamiseKp { get; set; }
        public string LepinguLiik { get; set; }
        public decimal Töökoormus { get; set; }
        public int? TöölepinguLisaNumber { get; set; }
        public int Töötasu { get; set; }

        public ICollection<Tööajakava> Tööajakavas { get; set; }

    }
}
