using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class OzmaDiaryData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string CategoryName { get; set; }
    public int Diary1TIDX { get; set; }
    public string Diary1Hidden { get; set; }
    public int Diary2TIDX { get; set; }
    public string Diary2Hidden { get; set; }
    public string Diary2ImagePath { get; set; }
    public int Diary3TIDX { get; set; }
    public string Diary3Hidden { get; set; }
    public int Diary4TIDX { get; set; }
    public string Diary4Hidden { get; set; }
}

public class OzmaDiaryDataTbl : KhazanTableBase
{
    public List<OzmaDiaryData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<OzmaDiaryData>();
        var dataArray = array.ToObject<OzmaDiaryData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
