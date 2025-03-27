using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shopbuyconditiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int PCLevel { get; set; }
public PropertyData PCLevel_Property { get; set; }
    public int ItemLevel { get; set; }
public PropertyData ItemLevel_Property { get; set; }
    public int GradeCommonRatio { get; set; }
public PropertyData GradeCommonRatio_Property { get; set; }
    public int GradeUncommonRatio { get; set; }
public PropertyData GradeUncommonRatio_Property { get; set; }
    public int GradeRareRatio { get; set; }
public PropertyData GradeRareRatio_Property { get; set; }
    public int GradeUniqueRatio { get; set; }
public PropertyData GradeUniqueRatio_Property { get; set; }
    public int GradeLegendaryRatio { get; set; }
public PropertyData GradeLegendaryRatio_Property { get; set; }
    public int GradeEpicRatio { get; set; }
public PropertyData GradeEpicRatio_Property { get; set; }
}

public class shopbuyconditiondatatbl : KhazanTableBase
{
    public List<shopbuyconditiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shopbuyconditiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shopbuyconditiondata>();
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
