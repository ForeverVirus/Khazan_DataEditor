using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class playerlevelupData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Level { get; set; }
    public long ReqExp { get; set; }
    public long CumulativeExp { get; set; }
}

public class playerlevelupDataTbl : KhazanTableBase
{
    public List<playerlevelupData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<playerlevelupData>();
        var dataArray = array.ToObject<playerlevelupData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
