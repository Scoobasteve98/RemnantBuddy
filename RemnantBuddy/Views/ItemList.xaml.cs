using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

public partial class ItemList : ContentPage
{
    public ItemList(RingsList ringList)
    {
        InitializeComponent();

        BindingContext = ringList;
    }

    private async void itemsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var equipment = (BaseEquipment)e.CurrentSelection[0];

            await Shell.Current.GoToAsync(nameof(ViewItem), true, new Dictionary<string, object>() { { nameof(ViewItem.Equipment), equipment } });

            // Unselect the UI
            itemCollection.SelectedItem = null;
        }
    }
}