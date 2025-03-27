using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class monsterlistdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int BaseInfoGroupIndex { get; set; }
public PropertyData BaseInfoGroupIndex_Property { get; set; }
    public EMonsterGradeType MonsterGradeType { get; set; }
public PropertyData MonsterGradeType_Property { get; set; }
    public EMonsterRace MonsterRace { get; set; }
public PropertyData MonsterRace_Property { get; set; }
    public EMonsterSpecies MonsterSpecies { get; set; }
public PropertyData MonsterSpecies_Property { get; set; }
    public ENormalAttackType NormalAttackType { get; set; }
public PropertyData NormalAttackType_Property { get; set; }
    public string Blueprint { get; set; }
public PropertyData Blueprint_Property { get; set; }
    public string MiniImg { get; set; }
public PropertyData MiniImg_Property { get; set; }
    public int AfterDieSpawnedActorTIDX { get; set; }
public PropertyData AfterDieSpawnedActorTIDX_Property { get; set; }
    public int FactionTIDX { get; set; }
public PropertyData FactionTIDX_Property { get; set; }
    public EOverheadGaugeType OverHeadGaugeType { get; set; }
public PropertyData OverHeadGaugeType_Property { get; set; }
    public int DropRewardID { get; set; }
public PropertyData DropRewardID_Property { get; set; }
    public ERewardGrade MonsterRewardGrade { get; set; }
public PropertyData MonsterRewardGrade_Property { get; set; }
}

public class monsterlistdatatbl : KhazanTableBase
{
    public List<monsterlistdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<monsterlistdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<monsterlistdata>();
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
