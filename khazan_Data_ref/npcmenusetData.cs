using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class npcmenusetData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public int Ability1 { get; set; }
    public string AbilityText1 { get; set; }
    public int Ability2 { get; set; }
    public string AbilityText2 { get; set; }
    public int Ability3 { get; set; }
    public string AbilityText3 { get; set; }
    public int Ability4 { get; set; }
    public string AbilityText4 { get; set; }
    public int Ability5 { get; set; }
    public string AbilityText5 { get; set; }
}

public class npcmenusetDataTbl : KhazanTableBase
{
    public List<npcmenusetData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<npcmenusetData>();
        var dataArray = array.ToObject<npcmenusetData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
