using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceCommandHubEquipPresetData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int WeaponLevel { get; set; }
    public EItemGrade WeaponGrade { get; set; }
    public int ArmorLevel { get; set; }
    public EItemGrade ArmorGrade { get; set; }
    public int AccessoryLevel { get; set; }
    public EItemGrade AccessoryGrade { get; set; }
    public int WeaponID { get; set; }
    public int HairID { get; set; }
    public int TorsoID { get; set; }
    public int ArmID { get; set; }
    public int LegID { get; set; }
    public int ShoesID { get; set; }
    public int NecklacesID { get; set; }
    public int RingID { get; set; }
    public bool MaxOptionValue { get; set; }
    public long[] WeaponOptionID { get; set; }
    public long[] HairOptionID { get; set; }
    public long[] TorsoOptionID { get; set; }
    public long[] ArmOptionID { get; set; }
    public long[] LegOptionID { get; set; }
    public long[] ShoesOptionID { get; set; }
    public long[] NecklacesOptionID { get; set; }
    public long[] RingOptionID { get; set; }
}

public class BalanceCommandHubEquipPresetDataTbl : KhazanTableBase
{
    public List<BalanceCommandHubEquipPresetData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceCommandHubEquipPresetData>();
        var dataArray = array.ToObject<BalanceCommandHubEquipPresetData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
