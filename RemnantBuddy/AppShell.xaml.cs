using RemnantBuddy.Views;

namespace RemnantBuddy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(EditItem), typeof(EditItem));
    }
}
