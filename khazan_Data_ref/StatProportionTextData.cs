using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class StatProportionTextData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EGrBaseStatus StatType { get; set; }
    public string DisplayText { get; set; }
    public int MinStat { get; set; }
    public int MaxStat { get; set; }
}

public class StatProportionTextDataTbl : KhazanTableBase
{
    public List<StatProportionTextData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<StatProportionTextData>();
        var dataArray = array.ToObject<StatProportionTextData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
