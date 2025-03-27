using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CraftingConditionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int PCLevel { get; set; }
    public int ItemLevel { get; set; }
}

public class CraftingConditionDataTbl : KhazanTableBase
{
    public List<CraftingConditionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CraftingConditionData>();
        var dataArray = array.ToObject<CraftingConditionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
