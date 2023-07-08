using LookForMaster.Models.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Services.Base;

public interface IMessenger
{

    void Send<TKey>(TKey arg) where TKey : IMessage;
    void Subscribe<TKey>(Action<IMessage> action) where TKey : IMessage;

}