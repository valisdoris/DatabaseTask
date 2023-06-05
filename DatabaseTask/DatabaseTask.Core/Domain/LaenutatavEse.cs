using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class LaenutatavEse
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public string AsjaKood { get; set; }
        public DateTime LaenutusesAlates { get; set; }
        public DateTime? LaenutusesKuni { get; set; }
        public Harukontor Harukontor { get; set; }

        public ICollection<Laenutus> Laenutus { get; set; }
    }
}
