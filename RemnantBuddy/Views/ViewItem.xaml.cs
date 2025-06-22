using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

public partial class ViewItem : ContentPage, IQueryAttributable
{
    public BaseEquipment Equipment { private get { return (BindingContext as BaseEquipment)!; } set { BindingContext = value; } }

    public ViewItem()
    {
        InitializeComponent();
    }

    private async void Edit_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(EditItem), true, new Dictionary<string, object>() { { nameof(EditItem.Equipment), Equipment } });
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Equipment = (query[nameof(Equipment)] as BaseEquipment)!;
    }
}