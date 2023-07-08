using LookForMaster.ViewModels.Base;
using Microsoft.Xaml.Behaviors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.ViewModels;

public class LoginPageViewModel : ViewModelBase
{
    private string email;

    public string Email
    {
        get => email;
        set => base.PropertyChange(out this.email, value);
    }

    private string errorEmail;
    public string ErrorEmail
    {
        get => errorEmail;
        set => base.PropertyChange(out this.errorEmail, value);
    }

    private string password;
    public string Password
    {
        get => password;
        set => base.PropertyChange(out this.password, value);
    }

    private string errorPassword;
    public string ErrorPassword
    {
        get => errorPassword;
        set => base.PropertyChange(out this.errorPassword, value);
    }

    private ActionCommand signUpCommand;
    public ActionCommand SignUpCommand
    {
        get => signUpCommand;
        set => base.PropertyChange(out this.signUpCommand, value);
    }

    private ActionCommand loginCommand;
    public ActionCommand LoginCommand
    {
        get => loginCommand;
        set => base.PropertyChange(out this.loginCommand, value);
    }

    public LoginPageViewModel()
    {

    }

}
