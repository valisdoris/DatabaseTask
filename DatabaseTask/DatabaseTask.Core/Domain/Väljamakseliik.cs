using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Väljamakseliik
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public bool LiikKasutuses { get; set; }
        public ICollection<PalgaarvestuseRead> PalgaarvestuseReads { get; set; }
    }
}
