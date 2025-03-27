using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MetaStatAgilityTableData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string StatName { get; set; }
    public EStatusGrade Stat { get; set; }
    public EStatClass StatClass { get; set; }
    public float StatWeight { get; set; }
}

public class MetaStatAgilityTableDataTbl : KhazanTableBase
{
    public List<MetaStatAgilityTableData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MetaStatAgilityTableData>();
        var dataArray = array.ToObject<MetaStatAgilityTableData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
