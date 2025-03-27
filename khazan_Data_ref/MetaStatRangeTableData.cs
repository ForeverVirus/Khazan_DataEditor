using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MetaStatRangeTableData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string StatName { get; set; }
    public EMetaStatRange Stat { get; set; }
    public int RangeMin { get; set; }
    public int RangeMax { get; set; }
}

public class MetaStatRangeTableDataTbl : KhazanTableBase
{
    public List<MetaStatRangeTableData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MetaStatRangeTableData>();
        var dataArray = array.ToObject<MetaStatRangeTableData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
