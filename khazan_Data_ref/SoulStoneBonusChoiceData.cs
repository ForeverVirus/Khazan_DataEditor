using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SoulStoneBonusChoiceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int BonusRank { get; set; }
    public int NeedSoulstonePoint { get; set; }
    public ESoulStoneBonus ChoiceA { get; set; }
    public ESoulStoneBonus ChoiceB { get; set; }
    public int PlayRound { get; set; }
}

public class SoulStoneBonusChoiceDataTbl : KhazanTableBase
{
    public List<SoulStoneBonusChoiceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SoulStoneBonusChoiceData>();
        var dataArray = array.ToObject<SoulStoneBonusChoiceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
