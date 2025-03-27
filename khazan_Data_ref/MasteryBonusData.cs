using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MasteryBonusData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MasteryLevel { get; set; }
    public int LevelupMasteryPoint { get; set; }
    public int LevelupCommonMasteryPoint { get; set; }
}

public class MasteryBonusDataTbl : KhazanTableBase
{
    public List<MasteryBonusData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MasteryBonusData>();
        var dataArray = array.ToObject<MasteryBonusData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
