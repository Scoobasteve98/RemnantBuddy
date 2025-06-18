using Newtonsoft.Json;
using RemnantBuddy.Models;
using System.Collections.ObjectModel;
using System.Linq;

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

    private async void Edit_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(EditItem));
    }

    private async void itemsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var ring = (Ring)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(EditItem)}?{nameof(EditItem.Name)}={ring.Name.ToLower().Replace(' ', '-')}");

            // Unselect the UI
            itemCollection.SelectedItem = null;
        }
    }
}