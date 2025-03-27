using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ItemAddInfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public bool Weapon { get; set; }
    public bool Armor { get; set; }
    public bool Accessory { get; set; }
    public bool bDisplayEncyclopedia { get; set; }
    public int DisplayEncyclopediaNeedMissionTIDX { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class ItemAddInfoDataTbl : KhazanTableBase
{
    public List<ItemAddInfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ItemAddInfoData>();
        var dataArray = array.ToObject<ItemAddInfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
