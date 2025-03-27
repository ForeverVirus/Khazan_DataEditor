using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class objectlistData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public string Blueprint { get; set; }
    public string Description { get; set; }
    public int BasicLevel { get; set; }
    public int BaseInfoGroupIndex { get; set; }
    public EObjectType ObjectType { get; set; }
    public EOverheadGaugeType OverHeadGaugeType { get; set; }
    public int FactionTIDX { get; set; }
    public EMinimapIconType MinimapIconType { get; set; }
}

public class objectlistDataTbl : KhazanTableBase
{
    public List<objectlistData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<objectlistData>();
        var dataArray = array.ToObject<objectlistData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
