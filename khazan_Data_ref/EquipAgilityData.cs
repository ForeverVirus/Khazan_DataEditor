using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class EquipAgilityData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EStatusGrade AgilityGrade { get; set; }
    public long GradeRange { get; set; }
    public EGrBaseStatus Stat1ID { get; set; }
    public int[] OptionTIDX { get; set; }
}

public class EquipAgilityDataTbl : KhazanTableBase
{
    public List<EquipAgilityData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<EquipAgilityData>();
        var dataArray = array.ToObject<EquipAgilityData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
