using Newtonsoft.Json;
using RemnantBuddy.Models;

namespace RemnantBuddy.Views;

[QueryProperty(nameof(Name), nameof(Name))]
public partial class EditItem : ContentPage
{
    private readonly string _directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Rings");
    public string Name { set { LoadItem(value); } }

    public EditItem()
    {
        InitializeComponent();
    }

    public void LoadItem(string fileName)
    {
        BaseEquipment noteModel = JsonConvert.DeserializeObject<BaseEquipment>(File.ReadAllText(Path.Combine(_directory, $"{fileName}.json"))) ?? new();
        BindingContext = noteModel;
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {

        if (BindingContext is BaseEquipment note)
        {
            note.Name = NameEditor.Text;
            note.Description = DescriptionEditor.Text;
            note.Location = LocationEditor.Text;
            File.WriteAllText(Path.Combine(_directory, $"{note.Name.ToLower().Replace(' ', '-')}.json"), JsonConvert.SerializeObject(note));
        }

        await Shell.Current.GoToAsync("..");
    }
}