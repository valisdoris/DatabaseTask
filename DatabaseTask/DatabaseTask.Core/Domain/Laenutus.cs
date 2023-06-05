using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Laenutus
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public LaenutatavEse LaenutatavEse { get; set; }
        public DateTime LaenutuseAlgus { get; set; }
        public DateTime? LaenutuseLõpp { get; set; }
    }
}
