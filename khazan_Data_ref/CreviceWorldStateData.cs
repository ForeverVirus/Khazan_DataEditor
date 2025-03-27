using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CreviceWorldStateData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ECreviceWorldState CreviceWorldState { get; set; }
    public string Desc { get; set; }
    public int NpcListTIDX { get; set; }
    public int ObjectListTIDX { get; set; }
    public string LevelPackageName { get; set; }
    public string WEP { get; set; }
}

public class CreviceWorldStateDataTbl : KhazanTableBase
{
    public List<CreviceWorldStateData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CreviceWorldStateData>();
        var dataArray = array.ToObject<CreviceWorldStateData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
