using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MetaStatWeightTableData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string StatName { get; set; }
    public EGrBaseStatus Stat { get; set; }
    public EStatClass StatClass { get; set; }
    public float StatWeight { get; set; }
}

public class MetaStatWeightTableDataTbl : KhazanTableBase
{
    public List<MetaStatWeightTableData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MetaStatWeightTableData>();
        var dataArray = array.ToObject<MetaStatWeightTableData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
