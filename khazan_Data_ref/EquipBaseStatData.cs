using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class EquipBaseStatData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long WeaponBaseStatMin { get; set; }
    public long WeaponBaseStatMax { get; set; }
    public long Armor_SheetingBaseStatMin { get; set; }
    public long Armor_SheetingBaseStatMax { get; set; }
    public long Armor_HeavyBaseStatMin { get; set; }
    public long Armor_HeavyBaseStatMax { get; set; }
    public long Armor_GreavesBaseStatMin { get; set; }
    public long Armor_GreavesBaseStatMax { get; set; }
    public long AccessoryBaseStatMin { get; set; }
    public long AccessoryBaseStatMax { get; set; }
}

public class EquipBaseStatDataTbl : KhazanTableBase
{
    public List<EquipBaseStatData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<EquipBaseStatData>();
        var dataArray = array.ToObject<EquipBaseStatData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
