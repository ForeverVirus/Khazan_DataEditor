using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class PhantomData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EPhantomType PhantomType { get; set; }
    public int PhantomLevel { get; set; }
    public int NeedLevelUpExp { get; set; }
    public int OptionTIDX { get; set; }
}

public class PhantomDataTbl : KhazanTableBase
{
    public List<PhantomData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<PhantomData>();
        var dataArray = array.ToObject<PhantomData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
