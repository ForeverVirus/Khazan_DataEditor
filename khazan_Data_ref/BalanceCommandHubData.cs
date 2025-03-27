using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceCommandHubData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int MissionTable { get; set; }
    public int PCLevel { get; set; }
    public int EquipmentLvel { get; set; }
    public int Exp { get; set; }
    public int Body { get; set; }
    public int Heart { get; set; }
    public int Strength { get; set; }
    public int Force { get; set; }
    public int Skill { get; set; }
    public int WeaponMastery { get; set; }
    public int CommonMastery { get; set; }
    public int LAPresetID { get; set; }
    public int HAPresetID { get; set; }
    public int PAPresetID { get; set; }
    public int DAPresetID { get; set; }
    public int GSPresetID { get; set; }
    public int SpearPresetID { get; set; }
    public string LAPresetName { get; set; }
    public string HAPresetName { get; set; }
    public string PAPresetName { get; set; }
    public string DAPresetName { get; set; }
    public string GSPresetName { get; set; }
    public string SpearPresetName { get; set; }
}

public class BalanceCommandHubDataTbl : KhazanTableBase
{
    public List<BalanceCommandHubData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceCommandHubData>();
        var dataArray = array.ToObject<BalanceCommandHubData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
