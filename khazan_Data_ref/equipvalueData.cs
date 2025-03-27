using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class equipvalueData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public int Value { get; set; }
    public int WeightValue { get; set; }
}

public class equipvalueDataTbl : KhazanTableBase
{
    public List<equipvalueData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<equipvalueData>();
        var dataArray = array.ToObject<equipvalueData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
