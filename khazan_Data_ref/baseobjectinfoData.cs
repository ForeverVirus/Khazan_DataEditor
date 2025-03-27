using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class baseobjectinfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int GroupIndex { get; set; }
    public int Level { get; set; }
    public string Name { get; set; }
    public EObjectType ObjectType { get; set; }
    public EObjectCollectType ObjectCollectType { get; set; }
    public EObjectRarity ObjectRarity { get; set; }
    public int ConsPowerBonus { get; set; }
    public int ConsHealthPoint { get; set; }
    public Status Status { get; set; }
}

public class baseobjectinfoDataTbl : KhazanTableBase
{
    public List<baseobjectinfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<baseobjectinfoData>();
        var dataArray = array.ToObject<baseobjectinfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
