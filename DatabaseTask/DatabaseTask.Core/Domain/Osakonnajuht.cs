using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Osakonnajuht
    {
        [Key]
        public Guid Id { get; set; }
        public Osakond Osakond { get; set; }
        public Employee Employee { get; set; }
        public DateTime JuhtAlates { get; set; }
        public DateTime? JuhtKuni { get; set; }
    }
}
