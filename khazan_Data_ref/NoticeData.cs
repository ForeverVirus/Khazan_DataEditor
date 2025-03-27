using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class NoticeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ENoticesType Type { get; set; }
    public ETermsSubType TermsSubType { get; set; }
    public string TitleText { get; set; }
    public string DescriptionText { get; set; }
    public string ActivateStartDateTimeString { get; set; }
    public int ActivateDay { get; set; }
    public int DisplayCount { get; set; }
    public bool bEnable { get; set; }
}

public class NoticeDataTbl : KhazanTableBase
{
    public List<NoticeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<NoticeData>();
        var dataArray = array.ToObject<NoticeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
