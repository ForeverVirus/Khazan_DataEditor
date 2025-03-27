using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SmartDropData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public int SelectCount { get; set; }
    public int ResetCount { get; set; }
}

public class SmartDropDataTbl : KhazanTableBase
{
    public List<SmartDropData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SmartDropData>();
        var dataArray = array.ToObject<SmartDropData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
