using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class statproportiontextdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EGrBaseStatus StatType { get; set; }
public PropertyData StatType_Property { get; set; }
    public string DisplayText { get; set; }
public PropertyData DisplayText_Property { get; set; }
    public int MinStat { get; set; }
public PropertyData MinStat_Property { get; set; }
    public int MaxStat { get; set; }
public PropertyData MaxStat_Property { get; set; }
}

public class statproportiontextdatatbl : KhazanTableBase
{
    public List<statproportiontextdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<statproportiontextdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<statproportiontextdata>();
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
