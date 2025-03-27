using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class itemoptionlinkData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public string ExcludeListName { get; set; }
    public int ItemOptionGroupTIDX { get; set; }
    public int ItemOptionValueTIDX { get; set; }
}

public class itemoptionlinkDataTbl : KhazanTableBase
{
    public List<itemoptionlinkData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<itemoptionlinkData>();
        var dataArray = array.ToObject<itemoptionlinkData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
