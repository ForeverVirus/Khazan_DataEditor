using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class factionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public ERelationShipType Player_Default { get; set; }
    public ERelationShipType Monster_Default { get; set; }
    public ERelationShipType LOB_Default { get; set; }
    public ERelationShipType LOB_All_Attack { get; set; }
    public ERelationShipType Monster_Red { get; set; }
    public ERelationShipType Monster_Blue { get; set; }
    public ERelationShipType Monster_Neutral { get; set; }
    public bool IsPVPTarget { get; set; }
}

public class factionDataTbl : KhazanTableBase
{
    public List<factionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<factionData>();
        var dataArray = array.ToObject<factionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
