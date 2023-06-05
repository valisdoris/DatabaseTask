using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Koolitus
    {
        [Key]
        public Guid Id { get; set; }
        public string Nimetus { get; set; }
        public Employee Employee { get; set; }
        public DateTime AlgusKp { get; set; }
        public DateTime LõppKp { get; set; }
        public string KoolituseAndmed { get; set; }
        public string? Kommentaar { get; set; }
    }
}
