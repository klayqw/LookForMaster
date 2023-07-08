using LookForMaster.Messeges;
using LookForMaster.Models.Messages;
using LookForMaster.Services.Base;
using LookForMaster.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.ViewModels;
public class MainViewModel : ViewModelBase
{

    private ViewModelBase activeViewModel;
    private IMessenger messenger;

    public ViewModelBase ActiveViewModel
    {
        get => activeViewModel;
        set => base.PropertyChange(out this.activeViewModel, value);
    }

    public MainViewModel(IMessenger messenger)
    {
        this.messenger = messenger;

        this.messenger.Subscribe<ViewNavigate>((message) => {
            if (message is ViewNavigate navigationMessage)
            {

                var viewModelObj = App.DIContainer.GetInstance(navigationMessage.DestinationViewModelType);

                if (viewModelObj is ViewModelBase viewModel)
                {
                    this.ActiveViewModel = viewModel;
                }

            }
        });


    }


}