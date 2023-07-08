using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Models
{
    public class MasterCategory
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int CategoryId { get; set; }
        public Master Master { get; set; }
        public Category Category { get; set; }
    }
}
