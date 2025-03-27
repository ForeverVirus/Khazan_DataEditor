using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CraftingListData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public int ItemTIDX { get; set; }
    public int ClearMissionTIDX { get; set; }
    public int RecipeTIDX { get; set; }
    public int PCLevel { get; set; }
    public bool bLevelCheck { get; set; }
}

public class CraftingListDataTbl : KhazanTableBase
{
    public List<CraftingListData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CraftingListData>();
        var dataArray = array.ToObject<CraftingListData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
