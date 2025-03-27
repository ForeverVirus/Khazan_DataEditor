using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class tombstoneData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ETombstoneType TombstoneType { get; set; }
    public EMenuAbilityType MenuAbility { get; set; }
    public string MenuName { get; set; }
    public string MenuDesc { get; set; }
    public int UnlockMissionTIDX { get; set; }
    public int UnlockNPCDialogueTIDX { get; set; }
    public int UnLockNPCTIDX { get; set; }
    public ETombstoneCustomCondition CustomCondition { get; set; }
    public bool UseNewPopup { get; set; }
    public string NewPopupText { get; set; }
    public string NewPopupImgPath { get; set; }
}

public class tombstoneDataTbl : KhazanTableBase
{
    public List<tombstoneData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<tombstoneData>();
        var dataArray = array.ToObject<tombstoneData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
