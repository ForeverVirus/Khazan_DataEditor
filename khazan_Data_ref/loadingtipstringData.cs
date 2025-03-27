using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class loadingtipstringData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ELoadingTooltipCategory TooltipCategory { get; set; }
    public string TooltipString { get; set; }
}

public class loadingtipstringDataTbl : KhazanTableBase
{
    public List<loadingtipstringData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<loadingtipstringData>();
        var dataArray = array.ToObject<loadingtipstringData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
