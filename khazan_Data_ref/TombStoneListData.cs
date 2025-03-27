using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class TombStoneListData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsStartingPoint { get; set; }
    public string ImagePath { get; set; }
}

public class TombStoneListDataTbl : KhazanTableBase
{
    public List<TombStoneListData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<TombStoneListData>();
        var dataArray = array.ToObject<TombStoneListData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
