using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MissionRecordBonusData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public int NeedPoint { get; set; }
    public int[] BalnaceOption_Slot { get; set; }
}

public class MissionRecordBonusDataTbl : KhazanTableBase
{
    public List<MissionRecordBonusData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MissionRecordBonusData>();
        var dataArray = array.ToObject<MissionRecordBonusData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
