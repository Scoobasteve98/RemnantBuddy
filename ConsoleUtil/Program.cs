using Newtonsoft.Json;
using RemnantBuddy.Models;

List<BaseEquipment> equipments = JsonConvert.DeserializeObject<List<BaseEquipment>>(File.ReadAllText("C:\\Code\\RemnantBuddy\\RemnantBuddy\\Data\\rings.json"));

foreach(var equipment in equipments)
{
    File.WriteAllText($"C:\\Code\\RemnantBuddy\\RemnantBuddy\\Data\\Rings\\{equipment.Name.ToLower().Replace(' ', '-')}.json", JsonConvert.SerializeObject(equipment, Formatting.Indented));
}