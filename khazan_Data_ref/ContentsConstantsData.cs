using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ContentsConstantsData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int UpgradeLevelPriceDefault { get; set; }
    public int UpgradeLevelPriceCorrection { get; set; }
    public int MaxWeaponDropCount { get; set; }
    public int MaxArmorDropCount { get; set; }
    public int MaxAccDropCount { get; set; }
}

public class ContentsConstantsDataTbl : KhazanTableBase
{
    public List<ContentsConstantsData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ContentsConstantsData>();
        var dataArray = array.ToObject<ContentsConstantsData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
