using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class Weapon : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Head : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Torso : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Arm : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Leg : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Shoes : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Ring : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Necklace : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Potion : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Consumable : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class HPPotion : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Limited : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class Expand : KhazanDataBase
{
    public int ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
    public bool Duplicate { get; set; }
public PropertyData Duplicate_Property { get; set; }
}

public class droprewarddata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string DevTag { get; set; }
public PropertyData DevTag_Property { get; set; }
    public ERewardContent RewardExpID { get; set; }
public PropertyData RewardExpID_Property { get; set; }
    public ERewardGold RewardGoldID { get; set; }
public PropertyData RewardGoldID_Property { get; set; }
    public int GoldAmount { get; set; }
public PropertyData GoldAmount_Property { get; set; }
    public int GoldProbability { get; set; }
public PropertyData GoldProbability_Property { get; set; }
    public Weapon Weapon { get; set; }
public PropertyData Weapon_Property { get; set; }
    public Head Head { get; set; }
public PropertyData Head_Property { get; set; }
    public Torso Torso { get; set; }
public PropertyData Torso_Property { get; set; }
    public Arm Arm { get; set; }
public PropertyData Arm_Property { get; set; }
    public Leg Leg { get; set; }
public PropertyData Leg_Property { get; set; }
    public Shoes Shoes { get; set; }
public PropertyData Shoes_Property { get; set; }
    public Ring Ring { get; set; }
public PropertyData Ring_Property { get; set; }
    public Necklace Necklace { get; set; }
public PropertyData Necklace_Property { get; set; }
    public Potion Potion { get; set; }
public PropertyData Potion_Property { get; set; }
    public Consumable Consumable { get; set; }
public PropertyData Consumable_Property { get; set; }
    public HPPotion HPPotion { get; set; }
public PropertyData HPPotion_Property { get; set; }
    public Limited Limited { get; set; }
public PropertyData Limited_Property { get; set; }
    public bool WithNormalItem { get; set; }
public PropertyData WithNormalItem_Property { get; set; }
    public bool SmartDropFailure { get; set; }
public PropertyData SmartDropFailure_Property { get; set; }
    public Expand[] Expand { get; set; }
public PropertyData Expand_Property { get; set; }
}

public class droprewarddatatbl : KhazanTableBase
{
    public List<droprewarddata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<droprewarddata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<droprewarddata>();
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
