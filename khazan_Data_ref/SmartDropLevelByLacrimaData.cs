using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SmartDropLevelByLacrimaData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int SmartDropStandardLevel { get; set; }
    public long CumulativeExp { get; set; }
}

public class SmartDropLevelByLacrimaDataTbl : KhazanTableBase
{
    public List<SmartDropLevelByLacrimaData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SmartDropLevelByLacrimaData>();
        var dataArray = array.ToObject<SmartDropLevelByLacrimaData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
