using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class playerdefaultabilitydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EGrBaseStatus DefaultStat { get; set; }
public PropertyData DefaultStat_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public Status Status { get; set; }
public PropertyData Status_Property { get; set; }
}

public class playerdefaultabilitydatatbl : KhazanTableBase
{
    public List<playerdefaultabilitydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<playerdefaultabilitydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<playerdefaultabilitydata>();
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
