using LookForMaster.Models.Messages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Messeges;

public class ViewNavigate : IMessage
{
    public ViewNavigate(Type destinationViewModelType)
    {
        DestinationViewModelType = destinationViewModelType;
    }

    public Type DestinationViewModelType { get; set; }

}
