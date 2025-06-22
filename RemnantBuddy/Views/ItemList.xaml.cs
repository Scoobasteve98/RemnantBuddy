using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

public partial class ItemList : ContentPage
{
    public ItemList()
    {
        InitializeComponent();

        BindingContext = new RingsList();
    }

    protected override void OnAppearing()
    {
        ((RingsList)BindingContext).LoadRings();
    }

    private async void itemsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var ring = (Ring)e.CurrentSelection[0];

            await Shell.Current.GoToAsync(nameof(ViewItem), true, new Dictionary<string, object>() { { nameof(ViewItem.Equipment), ring } });

            // Unselect the UI
            itemCollection.SelectedItem = null;
        }
    }
}