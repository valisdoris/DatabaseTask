using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class TöötajaAmetinimetus
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Alguskuupäev { get; set; }
        public DateTime? Lõppkuupäev { get; set; }
        public Ametinimetus Ametinimetus { get; set; }
    }
}
