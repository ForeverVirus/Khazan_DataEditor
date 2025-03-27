using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class GuidePopupData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Desc { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}

public class GuidePopupDataTbl : KhazanTableBase
{
    public List<GuidePopupData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<GuidePopupData>();
        var dataArray = array.ToObject<GuidePopupData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
