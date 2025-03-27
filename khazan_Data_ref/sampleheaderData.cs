using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class sampleheaderData : KhazanDataBase
{
    public int TIDX { get; set; }
    public bool IsUse { get; set; }
    public string FilePath { get; set; }
    public float var1 { get; set; }
    public int var2 { get; set; }
    public int var3 { get; set; }
    public int var4 { get; set; }
    public int var5 { get; set; }
    public long var6 { get; set; }
    public int var7 { get; set; }
    public int var8 { get; set; }
    public int var9 { get; set; }
    public int var10 { get; set; }
    public EGrDynamicStatus var11 { get; set; }
    public int var12 { get; set; }
    public int[] datas { get; set; }
    public int var14 { get; set; }
    public EGrBaseStatus var15 { get; set; }
    public int var16 { get; set; }
    public int GroupIndex { get; set; }
    public int FactionTIDX { get; set; }
    public string DateTime { get; set; }
}

public class sampleheaderDataTbl : KhazanTableBase
{
    public List<sampleheaderData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<sampleheaderData>();
        var dataArray = array.ToObject<sampleheaderData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
