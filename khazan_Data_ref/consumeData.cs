using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class Base : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Task { get; set; }
public PropertyData Task_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public string Class { get; set; }
public PropertyData Class_Property { get; set; }
    public string SubClass { get; set; }
public PropertyData SubClass_Property { get; set; }
    public int UnlockLevel { get; set; }
public PropertyData UnlockLevel_Property { get; set; }
    public int StackLimit { get; set; }
public PropertyData StackLimit_Property { get; set; }
    public int StorageStackLimit { get; set; }
public PropertyData StorageStackLimit_Property { get; set; }
    public int BalancePriceID { get; set; }
public PropertyData BalancePriceID_Property { get; set; }
    public int ItemGroupTIDX { get; set; }
public PropertyData ItemGroupTIDX_Property { get; set; }
    public bool CanTradeGold { get; set; }
public PropertyData CanTradeGold_Property { get; set; }
    public bool CanDecompose { get; set; }
public PropertyData CanDecompose_Property { get; set; }
    public bool CanTradeExp { get; set; }
public PropertyData CanTradeExp_Property { get; set; }
    public bool CanDump { get; set; }
public PropertyData CanDump_Property { get; set; }
    public bool CanStrengthen { get; set; }
public PropertyData CanStrengthen_Property { get; set; }
    public bool Important { get; set; }
public PropertyData Important_Property { get; set; }
    public string Tooltip { get; set; }
public PropertyData Tooltip_Property { get; set; }
    public string FlavorText { get; set; }
public PropertyData FlavorText_Property { get; set; }
    public string Icon { get; set; }
public PropertyData Icon_Property { get; set; }
}

public class consumedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public Base Base { get; set; }
public PropertyData Base_Property { get; set; }
    public EItemGrade Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public EConsumeType ConsumeType { get; set; }
public PropertyData ConsumeType_Property { get; set; }
    public EConsumeUseCondition[] EnableCondition { get; set; }
public PropertyData EnableCondition_Property { get; set; }
    public EConsumeUseCondition[] DisableCondition { get; set; }
public PropertyData DisableCondition_Property { get; set; }
    public bool CanUseShortCut { get; set; }
public PropertyData CanUseShortCut_Property { get; set; }
    public bool AutoUse { get; set; }
public PropertyData AutoUse_Property { get; set; }
    public bool Permanently { get; set; }
public PropertyData Permanently_Property { get; set; }
    public EConsumeRefillPolicy StorageRefuelSet { get; set; }
public PropertyData StorageRefuelSet_Property { get; set; }
    public bool bBeforeUseConfirm { get; set; }
public PropertyData bBeforeUseConfirm_Property { get; set; }
    public string ConfirmPopupContext { get; set; }
public PropertyData ConfirmPopupContext_Property { get; set; }
    public bool bCanUseManyInInven { get; set; }
public PropertyData bCanUseManyInInven_Property { get; set; }
    public bool bDeductCountNow { get; set; }
public PropertyData bDeductCountNow_Property { get; set; }
    public int[] EffectTIDX { get; set; }
public PropertyData EffectTIDX_Property { get; set; }
    public int SequenceDialogueTIDX { get; set; }
public PropertyData SequenceDialogueTIDX_Property { get; set; }
    public string SequenceDialogueText { get; set; }
public PropertyData SequenceDialogueText_Property { get; set; }
    public bool bDetailUI { get; set; }
public PropertyData bDetailUI_Property { get; set; }
    public string Image { get; set; }
public PropertyData Image_Property { get; set; }
    public string DetailText1 { get; set; }
public PropertyData DetailText1_Property { get; set; }
    public string DetailText2 { get; set; }
public PropertyData DetailText2_Property { get; set; }
    public string DetailText3 { get; set; }
public PropertyData DetailText3_Property { get; set; }
    public string SortType { get; set; }
public PropertyData SortType_Property { get; set; }
    public string UseSoundPath { get; set; }
public PropertyData UseSoundPath_Property { get; set; }
}

public class consumedatatbl : KhazanTableBase
{
    public List<consumedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<consumedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<consumedata>();
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
