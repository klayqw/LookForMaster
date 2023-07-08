using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Models
{
    public class Master
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<MasterCategory> MasterCategories { get; set; }
    }
}
