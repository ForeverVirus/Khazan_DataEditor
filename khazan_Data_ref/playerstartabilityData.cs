using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class playerstartabilitydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int LevelMax { get; set; }
public PropertyData LevelMax_Property { get; set; }
    public int Gold { get; set; }
public PropertyData Gold_Property { get; set; }
    public int EXP { get; set; }
public PropertyData EXP_Property { get; set; }
    public int SkillPoint { get; set; }
public PropertyData SkillPoint_Property { get; set; }
    public int CommonSkillPoint { get; set; }
public PropertyData CommonSkillPoint_Property { get; set; }
    public int Posion { get; set; }
public PropertyData Posion_Property { get; set; }
}

public class playerstartabilitydatatbl : KhazanTableBase
{
    public List<playerstartabilitydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<playerstartabilitydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<playerstartabilitydata>();
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
