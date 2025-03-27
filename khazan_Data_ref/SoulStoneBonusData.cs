using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class soulstonebonusdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public ESoulStoneBonus EffectType { get; set; }
public PropertyData EffectType_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int BalanceOptionTIDX { get; set; }
public PropertyData BalanceOptionTIDX_Property { get; set; }
}

public class soulstonebonusdatatbl : KhazanTableBase
{
    public List<soulstonebonusdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<soulstonebonusdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<soulstonebonusdata>();
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
