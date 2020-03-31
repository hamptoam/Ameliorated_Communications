using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ameliorated_Communications.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }

        public int CalleeId { get; set; }

        public Employee Employee { get; set; }

        public string outgoingText { get; set; }

     //   public IResponse Response { get; set; }
    }
}
