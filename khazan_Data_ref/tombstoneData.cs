using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class tombstonedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public ETombstoneType TombstoneType { get; set; }
public PropertyData TombstoneType_Property { get; set; }
    public EMenuAbilityType MenuAbility { get; set; }
public PropertyData MenuAbility_Property { get; set; }
    public string MenuName { get; set; }
public PropertyData MenuName_Property { get; set; }
    public string MenuDesc { get; set; }
public PropertyData MenuDesc_Property { get; set; }
    public int UnlockMissionTIDX { get; set; }
public PropertyData UnlockMissionTIDX_Property { get; set; }
    public int UnlockNPCDialogueTIDX { get; set; }
public PropertyData UnlockNPCDialogueTIDX_Property { get; set; }
    public int UnLockNPCTIDX { get; set; }
public PropertyData UnLockNPCTIDX_Property { get; set; }
    public ETombstoneCustomCondition CustomCondition { get; set; }
public PropertyData CustomCondition_Property { get; set; }
    public bool UseNewPopup { get; set; }
public PropertyData UseNewPopup_Property { get; set; }
    public string NewPopupText { get; set; }
public PropertyData NewPopupText_Property { get; set; }
    public string NewPopupImgPath { get; set; }
public PropertyData NewPopupImgPath_Property { get; set; }
}

public class tombstonedatatbl : KhazanTableBase
{
    public List<tombstonedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<tombstonedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<tombstonedata>();
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
