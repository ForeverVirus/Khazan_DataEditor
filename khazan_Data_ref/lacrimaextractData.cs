using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class lacrimaextractData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Level { get; set; }
    public int Amount { get; set; }
}

public class lacrimaextractDataTbl : KhazanTableBase
{
    public List<lacrimaextractData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<lacrimaextractData>();
        var dataArray = array.ToObject<lacrimaextractData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
