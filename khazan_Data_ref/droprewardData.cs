using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class Weapon : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Head : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Torso : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Arm : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Leg : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Shoes : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Ring : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Necklace : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Potion : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Consumable : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class HPPotion : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Limited : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class Expand : KhazanDataBase
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Probability { get; set; }
    public bool Duplicate { get; set; }
}

public class droprewardData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string DevTag { get; set; }
    public ERewardContent RewardExpID { get; set; }
    public ERewardGold RewardGoldID { get; set; }
    public int GoldAmount { get; set; }
    public int GoldProbability { get; set; }
    public Weapon Weapon { get; set; }
    public Head Head { get; set; }
    public Torso Torso { get; set; }
    public Arm Arm { get; set; }
    public Leg Leg { get; set; }
    public Shoes Shoes { get; set; }
    public Ring Ring { get; set; }
    public Necklace Necklace { get; set; }
    public Potion Potion { get; set; }
    public Consumable Consumable { get; set; }
    public HPPotion HPPotion { get; set; }
    public Limited Limited { get; set; }
    public bool WithNormalItem { get; set; }
    public bool SmartDropFailure { get; set; }
    public Expand[] Expand { get; set; }
}

public class droprewardDataTbl : KhazanTableBase
{
    public List<droprewardData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<droprewardData>();
        var dataArray = array.ToObject<droprewardData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
