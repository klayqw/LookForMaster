using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LookForMaster.Services.Base;
using LookForMaster.Services;
using LookForMaster.ViewModels;
using SimpleInjector;
using BookStore.Data;

namespace LookForMaster;

public partial class App : Application
{
    public static Container DIContainer = new Container();

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        ConfigureConatiner();

        WindowStartUp();

    }


    private void ConfigureConatiner()
    {
        DIContainer.RegisterSingleton<IMessenger, Messenger>();
        DIContainer.RegisterSingleton<MainViewModel>();
        DIContainer.RegisterSingleton<LoginPageViewModel>();
        DIContainer.RegisterSingleton<SignUpPageViewModel>();
        DIContainer.RegisterSingleton<LookForMasterDbContext>();
        DIContainer.RegisterSingleton<ChoosePageViewModel>();
        DIContainer.RegisterSingleton<AdminPincodePageViewModel>();
    }

    private void WindowStartUp()
    {
        var mainView = new MainWindow();
        var mainViewModel = DIContainer.GetInstance<MainViewModel>();
        mainViewModel.ActiveViewModel = DIContainer.GetInstance<ChoosePageViewModel>();
        mainView.DataContext = mainViewModel;

        mainView.ShowDialog();
    }


}
