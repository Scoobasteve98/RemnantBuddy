using RemnantBuddy.Data;
using System.Collections.ObjectModel;

namespace RemnantBuddy.Models;

public class RingsList
{
    private readonly RemnantRepository _repository;
    public RingsList(RemnantRepository repository)
    {
        _repository = repository;
        LoadRings();
    }

    public ObservableCollection<Ring> Rings { get; set; } = new();

    public void LoadRings()
    {
        Rings.Clear();
        using var dbContext = _repository.CreateDbContextAsync().Result;
        _repository.GetAllRings().ForEach(Rings.Add);
    }
}
