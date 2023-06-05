using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ametinimetus
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public DateTime KasutuselAlates { get; set; }
        public DateTime? KasutuselKuni { get; set; }

        public ICollection<TöötajaAmetinimetus> TöötajaAmetinimetus { get; set; }
    }
}
