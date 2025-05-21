using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisnerosM_UsodeLayouts.Views;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }

    private void ToAbsolute_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsolutPage());
        throw new NotImplementedException();
    }
}