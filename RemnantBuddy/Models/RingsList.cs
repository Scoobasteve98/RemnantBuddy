using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace RemnantBuddy.Models
{
    internal class RingsList
    {
        private readonly string _directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Rings");

        public RingsList()
        {
            LoadRings();
        }

        public ObservableCollection<Ring> Rings { get; set; } = new();

        public void LoadRings()
        {
            Rings.Clear();
            IEnumerable<Ring> rings = Directory
                .EnumerateFiles(_directoryPath, "*.json")
                .Select(filename => JsonConvert.DeserializeObject<Ring>(File.ReadAllText(filename)))
                .Where(ring => ring is not null)
                .OrderBy(ring => ring!.Name)!;

            foreach (var ring in rings.OrderBy(i => i.Name))
            {
                Rings.Add(ring);
            }
        }
    }
}
