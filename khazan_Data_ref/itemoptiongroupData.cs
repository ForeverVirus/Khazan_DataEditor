using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemoptiongroupdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public int Ratio { get; set; }
public PropertyData Ratio_Property { get; set; }
    public string IncludeListName1 { get; set; }
public PropertyData IncludeListName1_Property { get; set; }
    public string IncludeListName2 { get; set; }
public PropertyData IncludeListName2_Property { get; set; }
    public string ExcludeListName1 { get; set; }
public PropertyData ExcludeListName1_Property { get; set; }
    public string ExcludeListName2 { get; set; }
public PropertyData ExcludeListName2_Property { get; set; }
    public string Class { get; set; }
public PropertyData Class_Property { get; set; }
    public string SubClass { get; set; }
public PropertyData SubClass_Property { get; set; }
    public EItemSubType Melee { get; set; }
public PropertyData Melee_Property { get; set; }
    public bool LongRange { get; set; }
public PropertyData LongRange_Property { get; set; }
    public bool Hair { get; set; }
public PropertyData Hair_Property { get; set; }
    public bool Torso { get; set; }
public PropertyData Torso_Property { get; set; }
    public bool Arm { get; set; }
public PropertyData Arm_Property { get; set; }
    public bool Leg { get; set; }
public PropertyData Leg_Property { get; set; }
    public bool Shoes { get; set; }
public PropertyData Shoes_Property { get; set; }
    public bool Ring { get; set; }
public PropertyData Ring_Property { get; set; }
    public bool Necklace { get; set; }
public PropertyData Necklace_Property { get; set; }
    public int MinContentsLevel { get; set; }
public PropertyData MinContentsLevel_Property { get; set; }
    public int MaxContentsLevel { get; set; }
public PropertyData MaxContentsLevel_Property { get; set; }
    public EItemGrade MinGrade { get; set; }
public PropertyData MinGrade_Property { get; set; }
    public EItemGrade MaxGrade { get; set; }
public PropertyData MaxGrade_Property { get; set; }
    public int MinPlayRound { get; set; }
public PropertyData MinPlayRound_Property { get; set; }
    public int MaxPlayRound { get; set; }
public PropertyData MaxPlayRound_Property { get; set; }
    public bool CanCraft { get; set; }
public PropertyData CanCraft_Property { get; set; }
    public bool CanDrop { get; set; }
public PropertyData CanDrop_Property { get; set; }
    public bool CanShop { get; set; }
public PropertyData CanShop_Property { get; set; }
}

public class itemoptiongroupdatatbl : KhazanTableBase
{
    public List<itemoptiongroupdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemoptiongroupdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemoptiongroupdata>();
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
