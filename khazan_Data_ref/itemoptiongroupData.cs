using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class itemoptiongroupData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public int Ratio { get; set; }
    public string IncludeListName1 { get; set; }
    public string IncludeListName2 { get; set; }
    public string ExcludeListName1 { get; set; }
    public string ExcludeListName2 { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public EItemSubType Melee { get; set; }
    public bool LongRange { get; set; }
    public bool Hair { get; set; }
    public bool Torso { get; set; }
    public bool Arm { get; set; }
    public bool Leg { get; set; }
    public bool Shoes { get; set; }
    public bool Ring { get; set; }
    public bool Necklace { get; set; }
    public int MinContentsLevel { get; set; }
    public int MaxContentsLevel { get; set; }
    public EItemGrade MinGrade { get; set; }
    public EItemGrade MaxGrade { get; set; }
    public int MinPlayRound { get; set; }
    public int MaxPlayRound { get; set; }
    public bool CanCraft { get; set; }
    public bool CanDrop { get; set; }
    public bool CanShop { get; set; }
}

public class itemoptiongroupDataTbl : KhazanTableBase
{
    public List<itemoptiongroupData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<itemoptiongroupData>();
        var dataArray = array.ToObject<itemoptiongroupData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
