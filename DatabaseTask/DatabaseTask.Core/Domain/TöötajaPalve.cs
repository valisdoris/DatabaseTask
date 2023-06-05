using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class TöötajaPalve
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string Sisu { get; set; }
        public DateTime LisamiseAeg { get; set; }
        public string? Kommentaar { get; set; }

    }
}
