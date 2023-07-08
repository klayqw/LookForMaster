using LookForMaster.ViewModels.Base;
using Microsoft.Xaml.Behaviors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.ViewModels;

public class SignUpPageViewModel : ViewModelBase
{
    private string nickname;

    public string Nickname
    {
        get => nickname;
        set => base.PropertyChange(out nickname, value);
    }

    private string email;

    public string Email
    {
        get => email;
        set => base.PropertyChange(out email, value);
    }

    private ActionCommand signUpCommand;

    public ActionCommand SignUpCommand
    {
        get => signUpCommand;
        set => base.PropertyChange(out signUpCommand, value);
    }


}
