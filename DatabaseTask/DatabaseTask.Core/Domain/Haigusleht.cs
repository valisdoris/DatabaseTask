using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Haigusleht
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string Liik { get; set; }
        public DateTime HaigestumiseAlgus { get; set; }
        public DateTime? HaigestumiseLõpp { get; set; }
        public string? Esmane_Järgenev { get; set; }

        public ICollection<PalgaarvestuseRead> PalgaarvestuseReads { get; set; }
    }
}
