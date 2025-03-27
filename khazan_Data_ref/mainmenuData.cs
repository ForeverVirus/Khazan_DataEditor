using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class mainmenudata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EMainMenuType MainMenuType { get; set; }
public PropertyData MainMenuType_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string MenuDesc { get; set; }
public PropertyData MenuDesc_Property { get; set; }
    public int UnLockMissionTIDX { get; set; }
public PropertyData UnLockMissionTIDX_Property { get; set; }
    public int UnLockSkillPoint { get; set; }
public PropertyData UnLockSkillPoint_Property { get; set; }
    public int UnLockNPCTIDX { get; set; }
public PropertyData UnLockNPCTIDX_Property { get; set; }
    public ETutorialType UnLockTutorialType { get; set; }
public PropertyData UnLockTutorialType_Property { get; set; }
    public bool UseNewPopup { get; set; }
public PropertyData UseNewPopup_Property { get; set; }
    public string NewPopupText { get; set; }
public PropertyData NewPopupText_Property { get; set; }
    public string NewPopupImgPath { get; set; }
public PropertyData NewPopupImgPath_Property { get; set; }
}

public class mainmenudatatbl : KhazanTableBase
{
    public List<mainmenudata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<mainmenudata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<mainmenudata>();
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
