using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

[QueryProperty(nameof(Equipment), nameof(Equipment))]
public partial class EditItem : ContentPage
{
    public BaseEquipment Equipment { set { BindingContext = value; } }

    public EditItem()
    {
        InitializeComponent();
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}