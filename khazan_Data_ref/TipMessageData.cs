using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class TipMessageData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Title { get; set; }
    public string TipDesc { get; set; }
    public int UnLockMissionTIDX { get; set; }
    public ETipMessageType TipMessageType { get; set; }
}

public class TipMessageDataTbl : KhazanTableBase
{
    public List<TipMessageData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<TipMessageData>();
        var dataArray = array.ToObject<TipMessageData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
