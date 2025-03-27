using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equipagilitydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EStatusGrade AgilityGrade { get; set; }
public PropertyData AgilityGrade_Property { get; set; }
    public long GradeRange { get; set; }
public PropertyData GradeRange_Property { get; set; }
    public EGrBaseStatus Stat1ID { get; set; }
public PropertyData Stat1ID_Property { get; set; }
    public int[] OptionTIDX { get; set; }
public PropertyData OptionTIDX_Property { get; set; }
}

public class equipagilitydatatbl : KhazanTableBase
{
    public List<equipagilitydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equipagilitydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equipagilitydata>();
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
