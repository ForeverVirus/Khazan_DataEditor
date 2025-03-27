using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class EquipmentUpgradePriceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Level { get; set; }
    public int[] Grade { get; set; }
}

public class EquipmentUpgradePriceDataTbl : KhazanTableBase
{
    public List<EquipmentUpgradePriceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<EquipmentUpgradePriceData>();
        var dataArray = array.ToObject<EquipmentUpgradePriceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
