using LookForMaster.Models;
using LookForMaster.Models.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Messeges;

public class SendCurrentUser : IMessage
{
    public SendCurrentUser(User user)
    {
        User = user;
    }
    public User User { get; set; }
}