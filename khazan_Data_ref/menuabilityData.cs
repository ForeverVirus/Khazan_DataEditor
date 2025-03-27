using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class menuabilitydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string AbilityName { get; set; }
public PropertyData AbilityName_Property { get; set; }
    public EMenuAbilityType Ability { get; set; }
public PropertyData Ability_Property { get; set; }
    public string IconPath { get; set; }
public PropertyData IconPath_Property { get; set; }
    public int OpenMissionTIDX { get; set; }
public PropertyData OpenMissionTIDX_Property { get; set; }
    public bool UnlockMissionKeep { get; set; }
public PropertyData UnlockMissionKeep_Property { get; set; }
    public int UnlockNPCDialogueTIDX { get; set; }
public PropertyData UnlockNPCDialogueTIDX_Property { get; set; }
    public int UnlockPlayRound { get; set; }
public PropertyData UnlockPlayRound_Property { get; set; }
    public int UnLockNPCTIDX { get; set; }
public PropertyData UnLockNPCTIDX_Property { get; set; }
    public bool UseNewPopup { get; set; }
public PropertyData UseNewPopup_Property { get; set; }
    public string NewPopupText { get; set; }
public PropertyData NewPopupText_Property { get; set; }
    public string NewPopupImgPath { get; set; }
public PropertyData NewPopupImgPath_Property { get; set; }
    public int AddNameMenuAbilityTIDX { get; set; }
public PropertyData AddNameMenuAbilityTIDX_Property { get; set; }
}

public class menuabilitydatatbl : KhazanTableBase
{
    public List<menuabilitydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<menuabilitydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<menuabilitydata>();
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
