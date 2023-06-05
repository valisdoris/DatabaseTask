using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ligipääsuliik
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public DateTime Alguskuupäev { get; set; }
        public DateTime? Lõppkuupäev { get; set; }
        public string? Kommentaar { get; set; }

        public ICollection<TöötajaLigipääs> TöötajaLigipääs { get; set; }
    }
}
