using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime Validaty { get; set; }
        public string CVV { get; set; }
        public string Pincode { get; set; }
        
    }
}
