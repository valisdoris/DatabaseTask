using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class TöötajaLaps
    {
        [Key]
        public Guid Id { get; set; }

        public Employee Employee { get; set; }
        public string Nimi { get; set; }
        public DateTime Sünnikp { get; set; }


    }
}
