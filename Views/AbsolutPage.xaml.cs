using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisnerosM_UsodeLayouts.Views;

public partial class AbsolutPage : ContentPage
{
    public AbsolutPage()
    {
        InitializeComponent();
    }

    private void ToGrid_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new GridPage());
    }
}