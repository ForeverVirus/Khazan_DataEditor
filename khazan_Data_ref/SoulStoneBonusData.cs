using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SoulStoneBonusData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ESoulStoneBonus EffectType { get; set; }
    public int Level { get; set; }
    public int BalanceOptionTIDX { get; set; }
}

public class SoulStoneBonusDataTbl : KhazanTableBase
{
    public List<SoulStoneBonusData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SoulStoneBonusData>();
        var dataArray = array.ToObject<SoulStoneBonusData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
