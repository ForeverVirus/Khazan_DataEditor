using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class EquipLevelGroupData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public int EquipLevelGroup { get; set; }
    public int EquipLevel { get; set; }
    public int BaseStatMin { get; set; }
    public int BaseStatMax { get; set; }
}

public class EquipLevelGroupDataTbl : KhazanTableBase
{
    public List<EquipLevelGroupData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<EquipLevelGroupData>();
        var dataArray = array.ToObject<EquipLevelGroupData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
