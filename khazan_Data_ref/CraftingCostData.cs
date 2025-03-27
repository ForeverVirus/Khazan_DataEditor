using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CraftingCostData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public int ConsumeTIDX { get; set; }
    public int EquipmentTIDX { get; set; }
    public int GoldCost { get; set; }
    public int Material1TIDX { get; set; }
    public int Material1Count { get; set; }
    public int Material2TIDX { get; set; }
    public int Material2Count { get; set; }
    public int Material3TIDX { get; set; }
    public int Material3Count { get; set; }
    public int Material4TIDX { get; set; }
    public int Material4Count { get; set; }
    public int Material5TIDX { get; set; }
    public int Material5Count { get; set; }
    public int Material6TIDX { get; set; }
    public int Material6Count { get; set; }
}

public class CraftingCostDataTbl : KhazanTableBase
{
    public List<CraftingCostData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CraftingCostData>();
        var dataArray = array.ToObject<CraftingCostData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
