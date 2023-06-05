using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PalgaarvestuseRead
    {
        [Key]
        public Guid Id { get; set; }
        public Väljamakseliik? Väljamakseliik { get; set; }
        public int PalgaarvestuseSumma { get; set; }
        public Puhkus? Puhkus { get; set; }
        public Haigusleht? Haigusleht { get; set; }
        public Palk? Palk { get; set; }
        public Tööajakava? Tööajakava { get; set; }
        public string? Kommentaar { get; set; }
    }
}
