using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class Material : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Type { get; set; }
    public int Count { get; set; }
}

public class DecomposeMaterialData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public int EquipmentTIDX { get; set; }
    public int Exp { get; set; }
    public Material[] Material { get; set; }
}

public class DecomposeMaterialDataTbl : KhazanTableBase
{
    public List<DecomposeMaterialData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<DecomposeMaterialData>();
        var dataArray = array.ToObject<DecomposeMaterialData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
