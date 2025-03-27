using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class sampleheaderdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public bool IsUse { get; set; }
public PropertyData IsUse_Property { get; set; }
    public string FilePath { get; set; }
public PropertyData FilePath_Property { get; set; }
    public float var1 { get; set; }
public PropertyData var1_Property { get; set; }
    public double var2 { get; set; }
public PropertyData var2_Property { get; set; }
    public int var3 { get; set; }
public PropertyData var3_Property { get; set; }
    public int var4 { get; set; }
public PropertyData var4_Property { get; set; }
    public int var5 { get; set; }
public PropertyData var5_Property { get; set; }
    public long var6 { get; set; }
public PropertyData var6_Property { get; set; }
    public int var7 { get; set; }
public PropertyData var7_Property { get; set; }
    public int var8 { get; set; }
public PropertyData var8_Property { get; set; }
    public int var9 { get; set; }
public PropertyData var9_Property { get; set; }
    public int var10 { get; set; }
public PropertyData var10_Property { get; set; }
    public EGrDynamicStatus var11 { get; set; }
public PropertyData var11_Property { get; set; }
    public int var12 { get; set; }
public PropertyData var12_Property { get; set; }
    public int[] datas { get; set; }
public PropertyData datas_Property { get; set; }
    public int var14 { get; set; }
public PropertyData var14_Property { get; set; }
    public EGrBaseStatus var15 { get; set; }
public PropertyData var15_Property { get; set; }
    public int var16 { get; set; }
public PropertyData var16_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public int FactionTIDX { get; set; }
public PropertyData FactionTIDX_Property { get; set; }
    public string DateTime { get; set; }
public PropertyData DateTime_Property { get; set; }
}

public class sampleheaderdatatbl : KhazanTableBase
{
    public List<sampleheaderdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<sampleheaderdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<sampleheaderdata>();
        var dataExp = uasset.Exports[0] as DataTableExport;
        var table = dataExp?.Table;
        ProcessUAssetTable(table.Data, ref _table);
    }
    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
