using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ArtBookData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int PageNo { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
}

public class ArtBookDataTbl : KhazanTableBase
{
    public List<ArtBookData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ArtBookData>();
        var dataArray = array.ToObject<ArtBookData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
