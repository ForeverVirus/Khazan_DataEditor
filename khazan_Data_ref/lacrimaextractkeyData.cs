using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class lacrimaextractkeyData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemGrade Grade { get; set; }
    public EItemSubType SubType { get; set; }
    public float Weight { get; set; }
}

public class lacrimaextractkeyDataTbl : KhazanTableBase
{
    public List<lacrimaextractkeyData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<lacrimaextractkeyData>();
        var dataArray = array.ToObject<lacrimaextractkeyData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
