using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Vihje
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime SaatmiseAeg { get; set; }
        public string Sisu { get; set; }
        public Firma Firma { get; set; }
    }
}
