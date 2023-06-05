using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class TöötajaLigipääs
    {
        [Key]
        public Guid Id { get; set; }
        public Ligipääsuliik Ligipääsuliik { get; set; }
        public Employee Employee { get; set; }
        public DateTime KehtivAlates { get; set; }
        public DateTime KehtivKuni { get; set; }
    }
}
