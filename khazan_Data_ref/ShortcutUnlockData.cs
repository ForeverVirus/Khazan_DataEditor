using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShortcutUnlockData : KhazanDataBase
{
    public int TIDX { get; set; }
    public bool FirstOpen { get; set; }
    public long Material { get; set; }
    public long Count { get; set; }
}

public class ShortcutUnlockDataTbl : KhazanTableBase
{
    public List<ShortcutUnlockData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShortcutUnlockData>();
        var dataArray = array.ToObject<ShortcutUnlockData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
