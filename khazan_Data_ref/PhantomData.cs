using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class phantomdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EPhantomType PhantomType { get; set; }
public PropertyData PhantomType_Property { get; set; }
    public int PhantomLevel { get; set; }
public PropertyData PhantomLevel_Property { get; set; }
    public int NeedLevelUpExp { get; set; }
public PropertyData NeedLevelUpExp_Property { get; set; }
    public int OptionTIDX { get; set; }
public PropertyData OptionTIDX_Property { get; set; }
}

public class phantomdatatbl : KhazanTableBase
{
    public List<phantomdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<phantomdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<phantomdata>();
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
