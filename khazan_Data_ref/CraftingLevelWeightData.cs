using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CraftingLevelWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Level { get; set; }
    public int GoldWeight { get; set; }
    public int Material1Weight { get; set; }
    public int Material2Weight { get; set; }
    public int Material3Weight { get; set; }
    public int Material4Weight { get; set; }
    public int Material5Weight { get; set; }
    public int Material6Weight { get; set; }
}

public class CraftingLevelWeightDataTbl : KhazanTableBase
{
    public List<CraftingLevelWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CraftingLevelWeightData>();
        var dataArray = array.ToObject<CraftingLevelWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
