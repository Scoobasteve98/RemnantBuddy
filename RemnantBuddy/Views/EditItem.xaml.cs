using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

public partial class EditItem : ContentPage, IQueryAttributable
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

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Equipment = (query[nameof(Equipment)] as BaseEquipment)!;
    }
}