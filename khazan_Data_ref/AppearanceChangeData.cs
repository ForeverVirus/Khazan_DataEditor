using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class AppearanceChangeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int ListOrder { get; set; }
    public int EquipmentTIDX { get; set; }
    public EItemSubType SubType { get; set; }
    public bool CheckAcquirement { get; set; }
}

public class AppearanceChangeDataTbl : KhazanTableBase
{
    public List<AppearanceChangeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<AppearanceChangeData>();
        var dataArray = array.ToObject<AppearanceChangeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
