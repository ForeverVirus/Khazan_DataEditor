using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class zoneinfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Area { get; set; }
public PropertyData Area_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public bool TestLevel { get; set; }
public PropertyData TestLevel_Property { get; set; }
    public string MusicSwitchName { get; set; }
public PropertyData MusicSwitchName_Property { get; set; }
    public EZoneType ZoneType { get; set; }
public PropertyData ZoneType_Property { get; set; }
    public int UIPriority { get; set; }
public PropertyData UIPriority_Property { get; set; }
    public bool PVPZone { get; set; }
public PropertyData PVPZone_Property { get; set; }
    public string LevelPackageName { get; set; }
public PropertyData LevelPackageName_Property { get; set; }
    public string SpawnLevelIdentifier { get; set; }
public PropertyData SpawnLevelIdentifier_Property { get; set; }
    public bool EnableSprintAndDash { get; set; }
public PropertyData EnableSprintAndDash_Property { get; set; }
    public bool EnableArmed { get; set; }
public PropertyData EnableArmed_Property { get; set; }
    public bool EnableBattleSkill { get; set; }
public PropertyData EnableBattleSkill_Property { get; set; }
    public bool EnablePresentAreaNameOnStart { get; set; }
public PropertyData EnablePresentAreaNameOnStart_Property { get; set; }
}

public class zoneinfodatatbl : KhazanTableBase
{
    public List<zoneinfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<zoneinfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<zoneinfodata>();
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
