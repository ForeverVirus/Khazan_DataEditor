using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class craftinggradecapdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Playround { get; set; }
public PropertyData Playround_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public EItemGrade MaximumLimitGrade { get; set; }
public PropertyData MaximumLimitGrade_Property { get; set; }
}

public class craftinggradecapdatatbl : KhazanTableBase
{
    public List<craftinggradecapdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<craftinggradecapdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<craftinggradecapdata>();
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
