using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DatabaseTask.Core.Domain
{
    public class Isik
    {
        [Key]
        public Guid Id { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public string Sugu { get; set; }
        public DateTime Sünniaeg { get; set; }
        public int Isikukood { get; set; }
        public int KontaktTelefon { get; set; }
        public string? KontaktAadress { get; set; }
        public ICollection<Employee> Employees { get; set; }



    }
}
