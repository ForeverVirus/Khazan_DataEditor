using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class reforgematerialData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public int EquipmentTIDX { get; set; }
    public EPriceType PriceType { get; set; }
    public int GoldCost { get; set; }
    public int LacrimaCost { get; set; }
    public int Material1TIDX { get; set; }
    public int Material1Count { get; set; }
    public int Material2TIDX { get; set; }
    public int Material2Count { get; set; }
    public int Material3TIDX { get; set; }
    public int Material3Count { get; set; }
    public int Material4TIDX { get; set; }
    public int Material4Count { get; set; }
}

public class reforgematerialDataTbl : KhazanTableBase
{
    public List<reforgematerialData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<reforgematerialData>();
        var dataArray = array.ToObject<reforgematerialData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
