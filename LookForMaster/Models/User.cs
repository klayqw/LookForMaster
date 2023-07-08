using LookForMaster.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Models
{
    public enum USER_PRIORITIES
    {
        admin,
        master,
        customer,
    }

    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public USER_PRIORITIES Priority { get; set; }

        public Card Card { get; set; }
        public int CardId { get; set; }
    }

}
