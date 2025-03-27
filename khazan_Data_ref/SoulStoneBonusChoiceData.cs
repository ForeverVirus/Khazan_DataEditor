using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class soulstonebonuschoicedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int BonusRank { get; set; }
public PropertyData BonusRank_Property { get; set; }
    public int NeedSoulstonePoint { get; set; }
public PropertyData NeedSoulstonePoint_Property { get; set; }
    public ESoulStoneBonus ChoiceA { get; set; }
public PropertyData ChoiceA_Property { get; set; }
    public ESoulStoneBonus ChoiceB { get; set; }
public PropertyData ChoiceB_Property { get; set; }
    public int PlayRound { get; set; }
public PropertyData PlayRound_Property { get; set; }
}

public class soulstonebonuschoicedatatbl : KhazanTableBase
{
    public List<soulstonebonuschoicedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<soulstonebonuschoicedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<soulstonebonuschoicedata>();
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
