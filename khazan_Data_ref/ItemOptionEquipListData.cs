using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ItemOptionEquipListData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string ListName { get; set; }
    public int EquipID { get; set; }
}

public class ItemOptionEquipListDataTbl : KhazanTableBase
{
    public List<ItemOptionEquipListData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ItemOptionEquipListData>();
        var dataArray = array.ToObject<ItemOptionEquipListData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
