using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class itemfactoryDetailData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public long ID { get; set; }
    public int Ratio { get; set; }
    public bool FixedDrop { get; set; }
}

public class itemfactoryDetailDataTbl : KhazanTableBase
{
    public List<itemfactoryDetailData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<itemfactoryDetailData>();
        var dataArray = array.ToObject<itemfactoryDetailData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
