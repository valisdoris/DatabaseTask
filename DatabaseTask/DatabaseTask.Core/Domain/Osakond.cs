using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Osakond
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public Harukontor Harukontor { get; set; }
        public bool Aktiivne { get; set; }

        public ICollection<OsakonnaTöötaja> OsakonnaTöötajas { get; set; }
        public ICollection<Osakonnajuht> Osakonnajuhts { get; set; }
    }
}
