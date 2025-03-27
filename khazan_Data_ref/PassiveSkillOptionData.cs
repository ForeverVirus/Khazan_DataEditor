using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class passiveskilloptiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int GroupID { get; set; }
public PropertyData GroupID_Property { get; set; }
    public int SkillLevel { get; set; }
public PropertyData SkillLevel_Property { get; set; }
    public string InherentStat1Name { get; set; }
public PropertyData InherentStat1Name_Property { get; set; }
    public int InherentOption1TIDX { get; set; }
public PropertyData InherentOption1TIDX_Property { get; set; }
}

public class passiveskilloptiondatatbl : KhazanTableBase
{
    public List<passiveskilloptiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<passiveskilloptiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<passiveskilloptiondata>();
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
