using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Puhkus
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Puhkuseliik Puhkuseliik { get; set; }
        public DateTime PuhkuseAlgus { get; set; }
        public DateTime PuhkuseLõpp { get; set; }
        public bool VäljamaksePalgaga { get; set; }
        public string? Kommentaar { get; set; }

        public ICollection<PalgaarvestuseRead> PalgaarvestuseReads { get; set; }
    }
}
