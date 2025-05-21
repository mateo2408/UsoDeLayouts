using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisnerosM_UsodeLayouts.Views;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
    }

    private void ToFlex_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexPage());
        throw new NotImplementedException();
    }
}