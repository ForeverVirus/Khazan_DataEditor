using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class itemfactoryData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public int[] GradeRatio { get; set; }
    public int[] ItemID { get; set; }
}

public class itemfactoryDataTbl : KhazanTableBase
{
    public List<itemfactoryData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<itemfactoryData>();
        var dataArray = array.ToObject<itemfactoryData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
