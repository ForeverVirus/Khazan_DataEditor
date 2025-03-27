using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class Base : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Task { get; set; }
    public string Name { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public int UnlockLevel { get; set; }
    public int StackLimit { get; set; }
    public int StorageStackLimit { get; set; }
    public int BalancePriceID { get; set; }
    public int ItemGroupTIDX { get; set; }
    public bool CanTradeGold { get; set; }
    public bool CanDecompose { get; set; }
    public bool CanTradeExp { get; set; }
    public bool CanDump { get; set; }
    public bool CanStrengthen { get; set; }
    public bool Important { get; set; }
    public string Tooltip { get; set; }
    public string FlavorText { get; set; }
    public string Icon { get; set; }
}

public class consumeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public Base Base { get; set; }
    public EItemGrade Grade { get; set; }
    public EConsumeType ConsumeType { get; set; }
    public EConsumeUseCondition[] EnableCondition { get; set; }
    public EConsumeUseCondition[] DisableCondition { get; set; }
    public bool CanUseShortCut { get; set; }
    public bool AutoUse { get; set; }
    public bool Permanently { get; set; }
    public EConsumeRefillPolicy StorageRefuelSet { get; set; }
    public bool bBeforeUseConfirm { get; set; }
    public string ConfirmPopupContext { get; set; }
    public bool bCanUseManyInInven { get; set; }
    public bool bDeductCountNow { get; set; }
    public int[] EffectTIDX { get; set; }
    public int SequenceDialogueTIDX { get; set; }
    public string SequenceDialogueText { get; set; }
    public bool bDetailUI { get; set; }
    public string Image { get; set; }
    public string DetailText1 { get; set; }
    public string DetailText2 { get; set; }
    public string DetailText3 { get; set; }
    public string SortType { get; set; }
}

public class consumeDataTbl : KhazanTableBase
{
    public List<consumeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<consumeData>();
        var dataArray = array.ToObject<consumeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
