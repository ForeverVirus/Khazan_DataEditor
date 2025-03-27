using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class Effect : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public int SetCount { get; set; }
    public int OptionTIDX { get; set; }
    public string Image { get; set; }
}

public class setitemData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public string CraftingImage { get; set; }
    public int CraftingOrder { get; set; }
    public Effect[] Effect { get; set; }
}

public class setitemDataTbl : KhazanTableBase
{
    public List<setitemData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<setitemData>();
        var dataArray = array.ToObject<setitemData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
