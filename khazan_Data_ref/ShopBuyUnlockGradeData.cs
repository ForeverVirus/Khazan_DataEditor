using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shopbuyunlockgradedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Playround { get; set; }
public PropertyData Playround_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public EItemGrade UnLockGrade { get; set; }
public PropertyData UnLockGrade_Property { get; set; }
}

public class shopbuyunlockgradedatatbl : KhazanTableBase
{
    public List<shopbuyunlockgradedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shopbuyunlockgradedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shopbuyunlockgradedata>();
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
