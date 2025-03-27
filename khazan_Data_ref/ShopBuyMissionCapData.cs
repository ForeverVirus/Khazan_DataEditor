using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopBuyMissionCapData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MissionTIDX { get; set; }
    public int PlayRoundItemLevel1 { get; set; }
    public int PlayRoundItemLevel2 { get; set; }
    public int PlayRoundItemLevel3 { get; set; }
    public int PlayRoundItemLevel4 { get; set; }
    public int PlayRoundItemLevel5 { get; set; }
}

public class ShopBuyMissionCapDataTbl : KhazanTableBase
{
    public List<ShopBuyMissionCapData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopBuyMissionCapData>();
        var dataArray = array.ToObject<ShopBuyMissionCapData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
