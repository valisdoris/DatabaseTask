using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Tööajakava
    {
        [Key]
        public Guid Id { get; set; }
        public Tööleping Tööleping { get; set; }
        public DateTime PerioodiAlgus { get; set; }
        public DateTime PerioodiLõpp { get; set; }
        public int TöötatudTunnid { get; set; }
        public int Valveaeg { get; set; }
        public int Ületunnid { get; set; }

        public ICollection<PalgaarvestuseRead> PalgaarvestuseReads { get; set; }
    }
}
