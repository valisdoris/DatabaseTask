using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Riik
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }

        public ICollection<Firma> Firmas { get; set; }
    }
}
