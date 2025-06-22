using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

[QueryProperty(nameof(Equipment), nameof(Equipment))]
public partial class ViewItem : ContentPage
{
    public BaseEquipment Equipment { private get { return (BindingContext as BaseEquipment)!; } set { BindingContext = value; } }

    public ViewItem()
    {
        InitializeComponent();
    }

    private async void Edit_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ViewItem), true, new Dictionary<string, object>() { { nameof(EditItem.Equipment), Equipment } });
    }

}