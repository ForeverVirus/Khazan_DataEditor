using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class EquipmentUpgradeGradePriceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemGrade TargetGrade { get; set; }
    public EItemGrade MaterialGrade { get; set; }
    public int PriceRate { get; set; }
}

public class EquipmentUpgradeGradePriceDataTbl : KhazanTableBase
{
    public List<EquipmentUpgradeGradePriceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<EquipmentUpgradeGradePriceData>();
        var dataArray = array.ToObject<EquipmentUpgradeGradePriceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
