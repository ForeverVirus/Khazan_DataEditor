using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class npclistData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public string Name { get; set; }
    public string Blueprint { get; set; }
    public int NpcMenuTIDX { get; set; }
}

public class npclistDataTbl : KhazanTableBase
{
    public List<npclistData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<npclistData>();
        var dataArray = array.ToObject<npclistData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
