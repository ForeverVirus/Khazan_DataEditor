using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class missionclearresetitemData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MissionTIDX { get; set; }
    public EItemType ItemType { get; set; }
    public int ItemTIDX { get; set; }
}

public class missionclearresetitemDataTbl : KhazanTableBase
{
    public List<missionclearresetitemData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<missionclearresetitemData>();
        var dataArray = array.ToObject<missionclearresetitemData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
