using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CollectItemInfo : KhazanDataBase
{
    public int CollectItemTIDX { get; set; }
    public int CollectItemCount { get; set; }
}

public class npcdialoguecollectitemData : KhazanDataBase
{
    public int TIDX { get; set; }
    public bool IsReturn { get; set; }
    public CollectItemInfo[] CollectItemInfo { get; set; }
}

public class npcdialoguecollectitemDataTbl : KhazanTableBase
{
    public List<npcdialoguecollectitemData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<npcdialoguecollectitemData>();
        var dataArray = array.ToObject<npcdialoguecollectitemData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
