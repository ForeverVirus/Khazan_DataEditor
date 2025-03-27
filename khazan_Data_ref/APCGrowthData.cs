using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class APCGrowthData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EAPCGrowthType GrowthType { get; set; }
    public string SpellText { get; set; }
    public int Level { get; set; }
    public long RequireItemTIDX { get; set; }
    public int RequireCount { get; set; }
    public int BalanceOptionInfoTIDX { get; set; }
    public string IconPath { get; set; }
}

public class APCGrowthDataTbl : KhazanTableBase
{
    public List<APCGrowthData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<APCGrowthData>();
        var dataArray = array.ToObject<APCGrowthData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
