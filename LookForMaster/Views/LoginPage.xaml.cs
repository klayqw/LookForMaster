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
public partial class LoginPage : UserControl
{
    public bool IsMaxsimize = false;
    public LoginPage()
    {
        InitializeComponent();
    }
    private void SignUpButton_MouseLeave(object sender, MouseEventArgs e) => SignUpButton.Content = "Sign Up";
    private void SignUpButton_MouseEnter(object sender, MouseEventArgs e)
    {
        SignUpButton.Content = "Sign Up";
        TextBlock textBlock = new TextBlock(new Run(SignUpButton.Content.ToString()));
        textBlock.TextDecorations = TextDecorations.Underline;
        SignUpButton.Content = textBlock;
    }
    private void LoginButton_MouseEnter(object sender, MouseEventArgs e)
    {
        DropShadowEffect dropShadowEffect = new DropShadowEffect();
        dropShadowEffect.Color = Colors.LawnGreen;
        dropShadowEffect.Direction = 0;
        dropShadowEffect.ShadowDepth = 0;
        dropShadowEffect.BlurRadius = 10;
        LoginButton.Effect = dropShadowEffect;
    }
    private void LoginButton_MouseLeave(object sender, MouseEventArgs e)
    {
        DropShadowEffect dropShadowEffect = new DropShadowEffect();
        dropShadowEffect.Color = Colors.LawnGreen;
        dropShadowEffect.Direction = 0;
        dropShadowEffect.ShadowDepth = 0;
        dropShadowEffect.BlurRadius = 5;
        LoginButton.Effect = dropShadowEffect;
    }
}
