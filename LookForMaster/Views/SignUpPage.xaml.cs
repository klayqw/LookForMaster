using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LookForMaster.Views;

public partial class SignUpPage : UserControl
{
    public SignUpPage()
    {
        InitializeComponent();
    }

    private void SigUpButton_MouseEnter(object sender, MouseEventArgs e)
    {
        DropShadowEffect dropShadowEffect = new DropShadowEffect();
        dropShadowEffect.Color = Colors.LawnGreen;
        dropShadowEffect.Direction = 0;
        dropShadowEffect.ShadowDepth = 0;
        dropShadowEffect.BlurRadius = 10;
        SignUpButton.Effect = dropShadowEffect;
    }
    private void SigUpButton_MouseLeave(object sender, MouseEventArgs e)
    {
        DropShadowEffect dropShadowEffect = new DropShadowEffect();
        dropShadowEffect.Color = Colors.LawnGreen;
        dropShadowEffect.Direction = 0;
        dropShadowEffect.ShadowDepth = 0;
        dropShadowEffect.BlurRadius = 5;
        SignUpButton.Effect = dropShadowEffect;
    }
}
