using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopBuyUnlockGradeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Playround { get; set; }
    public int MissionTIDX { get; set; }
    public EItemGrade UnLockGrade { get; set; }
}

public class ShopBuyUnlockGradeDataTbl : KhazanTableBase
{
    public List<ShopBuyUnlockGradeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopBuyUnlockGradeData>();
        var dataArray = array.ToObject<ShopBuyUnlockGradeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
