using LookForMaster.Models.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Models.Messages;

public class NavigationMessage : IMessage
{
    public Type DestinationViewModelType { get; set; }

    public NavigationMessage(Type destinationViewModelType)
    {
        DestinationViewModelType = destinationViewModelType;
    }
}