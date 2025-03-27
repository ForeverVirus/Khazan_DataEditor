namespace KhazanData
{
public enum EAPCGrowthType
{
    None = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
    Type5 = 5,
    Type6 = 6,
    Count = 7,
}

public enum EItemSubType
{
    None = 0,
    MeleeWeapon_Start = 1,
    SwordShield = 2,
    Axe = 3,
    Gauntlet = 4,
    Spear = 5,
    Blunt = 6,
    DualAxeSword = 7,
    GSword = 8,
    MeleeWeapon_End = 9,
    LongRangeWeapon_Start = 20,
    Dagger = 21,
    Javelin = 22,
    Bow = 23,
    HandAxe = 24,
    LongRangeWeapon_End = 30,
    Armor_Start = 100,
    Shoes = 104,
    Torso = 105,
    Arm = 106,
    Leg = 107,
    Hair = 108,
    Ring = 110,
    Necklace = 111,
    Bracelet = 112,
    Armor_End = 113,
    Material_Start = 150,
    Crafting = 151,
    Mission = 152,
    Recipe = 153,
    Material_End = 154,
    Consume_Start = 200,
    Skill = 201,
    Function = 202,
    ThrowSkill = 203,
    Consume_End = 204,
    Collectible_Start = 210,
    Books = 211,
    Parchment = 212,
    Notes = 213,
    Documents = 214,
    Collectible_End = 215,
    Etc_Start = 220,
    System = 221,
    ETC = 222,
    Etc_End = 223,
    All = 254,
}

public enum EKazanWeaponType
{
    None = 0,
    Basic = 1,
    DualAxeSword = 2,
    GSword = 3,
    Spear = 4,
    SoulTaker = 5,
    BareHands = 6,
    Injured = 7,
    NonCombat = 8,
    Count = 9,
}

public enum ERewardGrade
{
    None = 0,
    Weak = 1,
    Normal_Weak = 2,
    Normal = 3,
    Normal_Elite = 4,
    Normal_Big = 5,
    Elite = 6,
    Strong_Normal = 7,
    Strong_Hard = 8,
    Boss = 9,
    APC_BEGIN = 10,
    FriendAPC_GSword = 11,
    FriendAPC_DualAxeSword = 12,
    FriendAPC_Spear = 13,
    EnemyAPC_GSword = 14,
    EnemyAPC_DualAxeSword = 15,
    EnemyAPC_Spear = 16,
    APC_END = 17,
    Count = 18,
}

public enum EItemGrade
{
    None = 0,
    Grade_1 = 1,
    Grade_2 = 2,
    Grade_3 = 3,
    Grade_4 = 4,
    Grade_5 = 5,
    Grade_6 = 6,
    Max = 7,
}

public enum EGrBaseStatus
{
    None,
    StaminaPointMax = 1,
    STRecovery = 2,
    SkillPoint = 3,
    Power = 4,
    DamageReductionRate = 5,
    PowerBonus = 6,
    DamageRate = 7,
    SkillDamageRate = 8,
    DamageAddRate = 9,
    GuardPenetrateRate = 10,
    BackAttackDamageRate = 11,
    ExhaustDamageRate = 12,
    AttackAndDefense = 13,
    Defense = 14,
    DefenseBonus = 15,
    DamageHalfReductionRate = 16,
    DefenseReductionValue = 17,
    DefenseReductionValuePerLevel = 18,
    StaminaDamage = 19,
    StaminaDamageRate = 20,
    ParryStaminaReduction = 21,
    StaminaDamageReductionRate = 22,
    GuardStaminaReductionRate = 23,
    GuardStaminaKeepRate = 24,
    StaminaReductionRate = 25,
    HPPosionLifeRecoveryRate = 26,
    HPPosionCount = 27,
    StaminaPosionCount = 28,
    DaggerCount = 29,
    JavelinCount = 30,
    Body = 31,
    Heart = 32,
    Strength = 33,
    Force = 34,
    Skill = 35,
    HealthPointMax = 36,
    HealthPointMaxBonus = 37,
    FireAttack = 38,
    WaterAttack = 39,
    ElectricAttack = 40,
    EarthAttack = 41,
    PoisonAttack = 42,
    DeseaseAttack = 43,
    ChaosAttack = 44,
    ElementalResistDark = 45,
    FireDefense = 46,
    WaterDefense = 47,
    ElectricDefense = 48,
    EarthDefense = 49,
    PoisonDefense = 50,
    DeseaseDefense = 51,
    ChaosDefense = 52,
    STRecoveryTime = 53,
    BattleResourceMaxGroup1 = 54,
    BattleResourceMaxGroup2 = 55,
    BattleResourceMaxGroup3 = 56,
    BattleResourceMaxGroup4 = 57,
    BattleResourceMaxGroup5 = 58,
    BattleResourceMaxGroup6 = 59,
    BattleResourceMaxGroup7 = 60,
    BattleResourceMaxGroup8 = 61,
    EquipWeightMax = 62,
    AttackerReaction = 63,
    DamagerReaction = 64,
    AmountLacrima = 65,
    WeaponDropRate = 66,
    HealthPotionDropRate = 67,
    IncreaseItemRank = 68,
    IncreasePhentomDuration = 69,
    AmountGold = 70,
    DefensePenetrate = 71,
    SetCount = 72,
    IncreaseBodyLv = 73,
    IncreaseHeartLv = 74,
    IncreaseStrengthLv = 75,
    IncreaseForceLv = 76,
    IncreaseSkillLv = 77,
    BrutalDamageRate = 78,
    BattleResource1GainRate = 79,
    BattleResource5GainRate = 80,
    AllyAPCHealthPointMax = 81,
    AllyAPCDamageRate = 82,
    AllyAPCStaminaPointMax = 83,
    AttributeDebuffGauge = 84,
    BattleResource1GainRateWhenJustGuard = 85,
}

public enum EItemOptionCondition
{
    None = 0,
    WeaponCategory = 1,
    SkillID = 2,
    AttackType = 3,
    RangeType = 4,
    BackAttack = 5,
    Guard = 6,
    CurrentHP = 7,
    Stance = 8,
    MonsterRace = 9,
    MonsterSpecies = 10,
    StatProportion = 11,
    EnemyCount = 12,
    EnemyCurrentHP = 13,
    CurrentStamina = 14,
    SoulTakerMode = 15,
    UseSkill = 16,
    Groggy = 17,
    StatusEffect = 18,
    KillEnemy = 19,
    ChargeAtk = 20,
    Hit = 21,
    CurrentStaminaTrigger = 22,
    CurrentHPTrigger = 23,
    EnemyCountTrigger = 24,
    CounterAttack = 25,
    JustDodge = 26,
    Dodge = 27,
    SpiritSkill = 28,
    StaminaExhaustionSkill = 29,
}

public enum EDyanmicOptionApplyType
{
    None = 0,
    Attacker = 1,
    Defender = 2,
}

public enum EStatusEffectRemoveType
{
    None = 0,
    ConditionEnd = 1,
}

public enum EActorGradeType
{
    NONE = 0,
    GRADE_1 = 1,
    GRADE_2 = 2,
    GRADE_3 = 3,
    GRADE_4 = 4,
    GRADE_5 = 5,
    GRADE_6 = 6,
    Count = 7,
}

public enum EObjectType
{
    None = 0,
    Treasure = 1,
    CollectionObject = 2,
    Lacrima = 3,
    TombStone = 4,
    Ladder = 5,
    Door = 6,
    Switch = 7,
    Mission = 8,
    SoulStone = 9,
    Count = 10,
}

public enum EObjectCollectType
{
    None = 0,
    Plant = 1,
    Mineral = 2,
    Animal = 3,
    Insect = 4,
    Ventana = 5,
    LootBox = 6,
    Teleport = 7,
}

public enum EObjectRarity
{
    None = 0,
    Common = 1,
    UnCommon = 2,
    Rare = 3,
    Unique = 4,
    Epic = 5,
    Count = 6,
}

public enum EBattleDialogueConditionType
{
    BattleTime = 0,
    PlayerDeath = 1,
    MonsterHP = 2,
    CinematicEnd = 3,
}

public enum EBattleDialogueOrderType
{
    Forward = 0,
    Random = 1,
}

public enum EItemType
{
    None = 0,
    Consume = 2,
    Etc = 3,
    Money = 4,
    Accessory = 5,
    Avatar = 6,
    Weapon = 7,
    Armor = 8,
    Material = 9,
    Collectible = 10,
    Max = 11,
}

public enum EConsumeType
{
    None = 0,
    Charm = 1,
    Eatable = 2,
    Medicine = 3,
    Specific1 = 4,
    ETC = 5,
}

public enum EConsumeUseCondition
{
    None = 0,
    HPFull = 1,
    BattleResource1Full = 2,
    BattleResource1Lack1 = 3,
    BattleResource1Lack2 = 4,
    BattleResource1Lack3 = 5,
    BattleResource1Lack4 = 6,
    BattleResource1Lack5 = 7,
    BareHand = 8,
    DebuffAttributeAny = 9,
    DebuffAttributeSelf = 10,
    CantRecallExp = 11,
    CantStatReset = 12,
    CanUseSystem = 13,
    CanUseMission = 14,
    DebuffAttributeSelfByID = 15,
    Count = 255,
}

public enum EConsumeRefillPolicy
{
    None = 0,
    Always = 1,
    RegistShortcut = 2,
}

public enum ECreviceWorldState
{
    RealWorld = 0,
    UnderWorld = 1,
}

public enum EDamageFloaterEffectType
{
    Anim = 0,
    FontColor = 1,
    FontScale = 2,
    Icon = 3,
    Progress = 4,
}

public enum EDamageFloaterAttackType
{
    Normal = 0,
    Back = 1,
    Elemental = 2,
    DamageOverTime = 3,
    DamageInDecreaseByPart = 4,
    DestructionBox = 5,
    CompleteDestroyedBox = 6,
    WeakPoint = 7,
    GrappleAttack = 8,
    PCDamaged = 9,
    SubDamageStart = 100,
    SEBuffFire = 101,
    SEBuffWater = 102,
    SEBuffLightning = 103,
    SEBuffEarth = 104,
    SEBuffPoison = 105,
    SEBuffPosionVenom = 106,
    SEBuffDiseasePlague = 107,
    SEBuffDiseaseHallucinatio = 108,
    SEBuffChaos = 109,
    SEDebuffFire = 110,
    SEDebuffWater = 111,
    SEDebuffPoison = 112,
    SEDebuffPosionVenom = 113,
    SEDebuffDiseasePlague = 114,
    SEDebuffChaos = 115,
}

public enum ERewardContent
{
    None = 0,
    Mission = 1,
    MonNormal = 2,
    MonEliteHuman = 3,
    MonEliteSoul = 4,
    MonBoss = 5,
    Object = 6,
    MonNormalGroup = 7,
    MonNormalBig = 8,
}

public enum ERewardGold
{
    None = 0,
    Mission = 1,
    MonsterWeak = 2,
    MonsterNormal = 3,
    MonsterElite = 4,
    MonsterBoss = 5,
    Object = 6,
    Destructible = 7,
    MonNormalGroup = 8,
    MonNormalBig = 9,
    MonEliteSoul = 10,
    MonEliteHuman = 11,
}

public enum EStatusGrade
{
    None = 0,
    A = 1,
    B = 2,
    C = 3,
    D = 4,
}

public enum EItemTier
{
    None = 0,
    Normal = 1,
    Special = 2,
}

public enum ERelationShipType
{
    ENEMY = 0,
    FRIEND = 1,
    NEUTRALITY = 2,
}

public enum EItemEffectType
{
    None = 0,
    StatPoint = 1,
    MissionStop = 2,
    Mastery = 3,
    Item = 4,
    ConditionRelease = 5,
    Skill = 6,
    RecallExp = 7,
    StatusRecovery = 8,
    SE_Set = 9,
    SE_Release = 10,
    ItemRefill = 11,
    StatusEffect = 12,
    Toggle = 13,
    Revive = 14,
    StatReset = 15,
    ReturnCheckpoint = 16,
    SE_ReleaseByID = 17,
}

public enum EStatPoint
{
    None = 0,
    SP = 1,
    Exp = 2,
    Gold = 3,
    PlayerMemory = 4,
    AmountHPPotion = 5,
}

public enum EMissionStop
{
    None = 0,
    KeepExp = 1,
    LoseExp = 2,
}

public enum EMasteryItem
{
    None = 0,
    Equip = 1,
    Select = 2,
}

public enum EStatusEffectAttribute
{
    None = 0,
    Fire = 1,
    Water = 2,
    Lightning = 3,
    Earth = 4,
    Poison = 5,
    Poison_Venom = 6,
    Disease_Plague = 7,
    Disease_Hallucination = 8,
    Chaos_InstantDeath = 9,
    Max = 10,
    ALL = 255,
}

public enum EGrDynamicStatus
{
    None = 0,
    HealthPoint = 1,
    MaxHPDecrease = 2,
    ArmorPhysical = 3,
    ArmorMagical = 4,
    BattleState = 5,
    Stamina = 6,
    MaxStaminaDecrease = 7,
    MaxStaminaIncrease = 8,
    BattleResourceGroup1 = 9,
    BattleResourceGroup2 = 10,
    BattleResourceGroup3 = 11,
    BattleResourceGroup4 = 12,
    BattleResourceGroup5 = 13,
    BattleResourceGroup6 = 14,
    BattleResourceGroup7 = 15,
    BattleResourceGroup8 = 16,
    MaxBattleResourceGroup1Decrease = 17,
    EquipWeightMax = 18,
    EquipWeight = 19,
    Count = 20,
}

public enum EItemEffectValueType
{
    Number = 0,
    PercentageBaseOnMaxHP = 1,
}

public enum EItemEffectAction
{
    None = 0,
    Stun = 1,
}

public enum EOptionContentOrigin
{
    None = 0,
    Pendulum = 1,
}

public enum ELoadingTooltipCategory
{
    None = 0,
    System = 1,
    Common = 2,
    Item = 3,
    Growth = 4,
    Dungeon = 5,
    Max = 6,
}

public enum EMainMenuType
{
    None = 0,
    Inven = 1,
    SkillTree = 2,
    CharacterStatus = 3,
    SkillCustomize = 4,
    SystemMenu = 5,
    Equipment = 6,
    Message = 7,
    MonsterLibrary = 8,
    Pendulum = 9,
    Encyclopedia = 10,
    GameOption = 11,
    PracticeExit = 12,
    GoToTitle = 13,
    Count = 14,
}

public enum ETutorialType
{
    Tutorial_Move = 0,
    Tutorial_LockOn = 1,
    Tutorial_Battle = 2,
    Tutorial_UsePotion = 3,
    Tutorial_Guard = 4,
    Tutorial_Dodge = 5,
    Tutorial_Sprint = 6,
    Tutorial_BackAttack = 7,
    Tutorial_FallAttack = 8,
    Tutorial_LevelUp = 9,
    Tutorial_DSwordSkillUnLock = 10,
    Tutorial_SpearSkillUnLock = 11,
    Tutorial_DASSkillUnLock = 12,
    Tutorial_Combat = 13,
    Tutorial_CommonSkill = 14,
    Tutorial_BurstAttack = 15,
    Tutorial_CameraMove = 16,
    Tutorial_LockOnChange = 17,
    Tutorial_WeakAttack = 18,
    Tutorial_StrongAttack = 19,
    Tutorial_ChargeAttack = 20,
    Tutorial_Transform = 21,
    Tutorial_Javelin = 22,
    Tutorial_Poise = 23,
    Tutorial_Shortcut = 24,
    Tutorial_Poise2 = 25,
    Tutorial_PerfectGuard = 26,
    Tutorial_Exhaustion = 27,
    Tutorial_Rotation = 28,
    Tutorial_Training = 29,
    Tutorial_Crack = 30,
    Tutorial_MonsterStamina = 31,
    Tutorial_berserk1 = 32,
    Tutorial_berserk2 = 33,
    Tutorial_EliteMonster = 34,
    Tutorial_JavelinAndObject = 35,
    Tutorial_Lantern = 36,
    Tutorial_MainMenu = 37,
    Tutorial_ShortcutLoad = 38,
    Count = 255,
}

public enum EMasteryPoint
{
    None = 0,
    Attack = 1,
    Guard = 2,
    JustGuard = 3,
}

public enum EMenuAbilityType
{
    None = 0,
    LevelUp = 1,
    MakeOffering = 2,
    Buy = 3,
    Sell = 4,
    WeaponSuccession = 5,
    ArmorSuccession = 6,
    Reforge = 7,
    Storage = 8,
    Disassemble = 9,
    Forge = 10,
    Talk = 11,
    Exit = 12,
    MonsterLibrary = 13,
    SoulStoneLevelUp = 14,
    Worldmap = 15,
    PhantomSkill = 16,
    Campsite = 17,
    Transfer = 18,
    ClearMission = 19,
    ClearMissionAndGoingCampsite = 20,
    SubTalk = 21,
    GoBack = 22,
    Enforce = 23,
    MovePlayround = 24,
    BuyTombStone = 25,
    BuyDanjin1 = 26,
    BuyDanjin2 = 27,
    BuyDanjin3 = 28,
    BuyDigor1 = 29,
    BuyDigor2 = 30,
    BuyDigor3 = 31,
    BuyDigor4 = 32,
    BuyDigor5 = 33,
    BuyDigor6 = 34,
    BuyDigor7 = 35,
    BuyDigor8 = 36,
    BuyDigor9 = 37,
    BuyDigor10 = 38,
    CraftSetItem = 39,
    APCGrowth = 40,
    MissionList = 41,
    MovetoTrainingField = 42,
    PlayerMemory = 43,
}

public enum EStatClass
{
    None = 0,
    ATK_Stat = 1,
    DEF_Stat = 2,
}

public enum EOptionOrigin
{
    None = 0,
    RandomOption = 1,
    InherentStat = 2,
    SetOption = 3,
    Count = 4,
}

public enum EOptionScoreType
{
    None = 0,
    All = 1,
    Attack = 2,
    Defence = 3,
}

public enum EMetaStatRange
{
    Range_0 = 0,
    Range_1 = 1,
    Range_2 = 2,
    Range_3 = 3,
    Range_Minus_1 = 4,
    Range_Minus_2 = 5,
    Range_Minus_3 = 6,
}

public enum EEndingType
{
    None = 0,
    A = 1,
    B = 2,
    C = 3,
    Max = 4,
}

public enum EKazanRecodeType
{
    None = 0,
    MissionStart = 1,
    MissionClear = 2,
    Consume = 3,
    Character = 4,
    MotionGraphic = 5,
    RTC = 6,
    Ending  = 7,
}

public enum EMissionType
{
    None = 0,
    Main = 1,
    Sub = 2,
}

public enum EMonsterLibraryGrade
{
    None = 0,
    Weak = 1,
    Normal = 2,
    Elite = 3,
    Boss = 4,
    Count = 5,
}

public enum EMonsterLibraryGoal
{
    None = 0,
    JustGuard = 1,
    KillLettingMonsterCall = 2,
    NoIllusionAndKill = 3,
    JustGuardGhostStaminaDamage = 4,
    NoAbsorbWraithAndKill = 5,
    KillWithStatusEffectBuff = 6,
    KillBeforeActivateSkin = 7,
    Kill = 8,
    PartDestruction = 9,
    NoCallSkeletonAndKill = 10,
    NoPoisonVenomAndKill = 11,
    KillCallingSandWorm = 12,
    CancelRushAndKill = 13,
    PartDestructionAndKill = 14,
    NoGhostAttackAndKill = 15,
    SurviveChiselRangeAttak = 16,
    CancelHammerThrow = 17,
    KillBlockBabySpider = 18,
    KillNoBlockBabySpider = 19,
    NoPoisonShallowSEAndKill = 20,
    NoDiseasePlagueSEAndKill = 21,
    NoRangkusBoltAndKill = 22,
    Grapple = 23,
    NoRoarAndKill = 24,
    JustGuardSwordDanceAndKill = 25,
    NoBigShieldAttackdAndKill = 26,
    JustGuardSecretSwordArt = 27,
    NoPhysicAttackAndKill = 28,
    NoFirePillarAndKill = 29,
    NoSEAttackAndKill = 30,
    DisturbSoulCharge = 31,
    KillBloodCharging = 32,
    NoDamageAndKill = 33,
    NoChoirDebuffAndKill = 34,
    NoBreathDamageAndKill = 35,
    KillWithJavelin = 36,
    KillWithThrow = 37,
    KillWithTransform = 38,
    KillWithFinalBlow = 39,
    KillWithFireStatusEffect = 40,
    KillWithWaterStatusEffect = 41,
    KillWithLightningStatusEffect = 42,
    KillWithEarthStatusEffect = 43,
    KillWithFireSecondStatusEffect = 44,
    KillWithWaterSecondStatusEffect = 45,
    KillWithLightningSecondStatusEffect = 46,
    KillWithEarthSecondStatusEffect = 47,
    KillWithDodgeAttack = 48,
    KillWithOnlyOneAttack = 49,
    ParringSuccess = 50,
    KillWithoutBattleResourceUse = 51,
    KillWithoutPotionUse = 52,
    KillWithoutGuard = 53,
    JustGuardAndKill = 54,
    NoFrenzyAndKill = 55,
    NoEnchantAndKill = 56,
    NoLaserBeamAndKill = 57,
    SelfDestructKill = 58,
    KillDuringPartDestGroggy = 59,
    NoMagicBookEnchantAndKill = 60,
    KillOnlyJustGuardAndGrapple = 61,
    KillDuringAlusiaStatusEffect = 62,
    KillDuringAirEvent = 63,
    CounterAttackAndKill = 64,
    BreakHideByLanternAndKill = 65,
    KillDuringWildBoarDown = 66,
}

public enum ERewardType
{
    None = 0,
    Equipment = 1,
    Consume = 2,
    Lacrima = 3,
    Gold = 4,
}

public enum EMonsterGradeType
{
    None = 0,
    NormalGroup = 1,
    Normal = 2,
    Elite = 3,
    Weak = 4,
    Boss = 10,
    NormalBig = 11,
    EliteSoul = 12,
    EliteSoul_B = 13,
    EliteHuman = 14,
    EliteHuman_B = 15,
}

public enum EMonsterRace
{
    None = 0,
    Human = 1,
    Dragon = 2,
    Undead = 3,
    Beast = 4,
    Devil = 5,
    Homunculus = 6,
    Illusion = 7,
}

public enum EMonsterSpecies
{
    None = 0,
    Picaroon = 1,
    Empire = 2,
    Imposter = 3,
    Demon = 4,
    DemonSlave = 5,
    DemonFollower = 6,
    Dragon = 7,
    Dragonian = 8,
    Spider = 9,
    Apes = 10,
    Skeleton = 11,
    Zombie = 12,
    Wraith = 13,
    Golem = 14,
    AbominationG = 15,
    Beast = 16,
    Statue = 17,
    Plant = 18,
    Blood = 19,
    Armor = 20,
    MartialArts = 21,
    Zealot = 22,
    Ghost = 23,
    Descendant = 24,
}

public enum EAssemblyStep
{
    None = 0,
    Q1 = 1,
    Q2 = 2,
    Q3 = 3,
}

public enum ENormalAttackType
{
    None = 0,
    Melee = 1,
    LongRange = 2,
    Max = 3,
}

public enum EOverheadGaugeType
{
    Normal = 0,
    Guard = 1,
    Remove = 2,
}

public enum ENoticesType
{
    Term = 0,
    Notice = 1,
    Count = 2,
}

public enum ETermsSubType
{
    None = 0,
    PrivacyPolicy = 1,
    TermsOfService = 2,
    Count = 3,
}

public enum EMissionCondition
{
    PreComplete = 0,
    PostComplete = 1,
    Proceeding = 2,
}

public enum EEndingCondition
{
    None = 0,
    Choice_A = 1,
    Choice_B = 2,
    Choice_C = 3,
    Selected_A = 4,
    Selected_B = 5,
    Selected_C = 6,
    Max = 7,
}

public enum EFacialPresetType
{
    None = 0,
    Normal = 1,
    Happiness = 2,
    Sadness = 3,
    Anger = 4,
    Count = 5,
}

public enum EDialogueType
{
    None = 0,
    Dialogue = 1,
    MenuDialogue = 3,
    RecipeDialogue = 4,
    OneOffDialogue = 5,
    OneOffMenuDialogue = 6,
    ZoneWhileDialogue = 7,
    EndingDialogue = 8,
    EndingMenuTitle = 9,
    EndingMenuDialogue = 10,
    ForceDialogue = 11,
    MissionMenuDialogue = 12,
    TurningPointMenuTitle = 13,
    TurningPointMenuDialogue = 14,
}

public enum EMinimapIconType
{
    None = 0,
    Monster = 1,
    NPC = 2,
    Treasure = 3,
    CollectionObject = 4,
    CollectionPoint = 5,
    CheckPoint = 6,
    Mission = 7,
}

public enum EPhantomType
{
    AType = 0,
    BType = 1,
    CType = 2,
    DType = 3,
    EType = 4,
    FType = 5,
    GType = 6,
    HType = 7,
    Count = 8,
}

public enum EPhantomGain
{
    None = 0,
    Start = 1,
    Quest = 2,
    Count = 3,
}

public enum EPlatformBonusCondition
{
    None = 0,
    Preorder = 1,
    Deluxe = 2,
    OnlyData = 3,
    Count = 4,
}

public enum EPlatformBonus
{
    None = 0,
    Reward = 1,
    Gold = 2,
}

public enum EItemOptionValue
{
    None = 0,
    Integer = 1,
    BasisPoint = 2,
    BasisPointWithoutPercent = 3,
}

public enum EPriceType
{
    None = 0,
    Gold = 1,
    Lacrima = 2,
    ConsumeItem = 3,
}

public enum EReinforceFailType
{
    None = 0,
    Distruction = 1,
    LevelReduction = 2,
}

public enum EReduceStatusType
{
    None = 0,
    Fix = 1,
    Random = 2,
    All = 3,
}

public enum ESoulStoneBonus
{
    None = 0,
    AmountLacrima = 1,
    AmountHPPotion = 2,
    AmountGold = 3,
    MaximumBattleResource1Number = 4,
    HPPosionLifeRecoveryRate = 5,
    Count = 6,
}

public enum EGameMessageType
{
    None = 0,
    SystemMessage = 1,
    ContentsSystemMessage = 2,
    PopupMessage = 3,
    AchievementMessage = 4,
    AchievementMessage_Max = 5,
}

public enum ETipMessageType
{
    None = 0,
    CreviceTitle = 1,
    TrainingTitle = 2,
    TrainingTip = 3,
}

public enum ETombstoneType
{
    None = 0,
    Tombstone = 1,
    TempTombstone = 2,
    AreaTombstone = 3,
    Count = 255,
}

public enum ETombstoneCustomCondition
{
    None = 0,
    AtLeastPhantomOpen = 1,
}

public enum EWeaponSkillStat
{
    None = 0,
    DamageAddRate = 1,
    StaminaDamageAddRate = 2,
    DamageMultiplyRate = 3,
    StaminaDamageMultiplyRate = 4,
    StaminaReductionRate = 5,
    GuardStaminaReductionRate = 6,
    JustGuardStaminaReductionRate = 7,
    StatusEffectAccumReductionRate = 8,
    StatusEffectAccumAddRate = 9,
    StatusEffectDamageAddRate = 10,
    BattleResourceAdd = 11,
    BattleResourceAddRateMax = 12,
    DamageReductionRate = 13,
    SpellTimeAdd = 14,
    SpellTimeDecreaseRate = 15,
    PlayAnimRate = 16,
    HealPointAddRateMax = 17,
    HealPointAdd = 18,
    ChangeReactionValue = 19,
    UnbreakableAnimNotifyAddTime = 20,
    CounterAttackAnimNotifyTimeDecrease = 21,
    JustDodgeCombatSpiritAddRate = 22,
    JustGuardStaminaDamageAddRate = 23,
    UnbreakableAddTimeByAgility = 24,
    BattleResourceAddRate = 25,
    BattleResourceSet = 26,
    BattleResourceAddValue = 27,
    HealthPointAddRate = 28,
    HealthPointSet = 29,
    HealthPointAddValue = 30,
    JustDodgeTimeAdd = 31,
    StaminaDamageReductionRate = 32,
}

public enum EWeaponSkillCondition
{
    None = 0,
    OtherSkill = 1,
    DamageInfo = 2,
    SpellInfo = 3,
    Animation = 4,
    WeakPoint = 5,
    Exhaustion = 6,
    FrontAttack = 7,
    BackAttack = 8,
    Guard = 9,
    JustGuard = 10,
    NormalGuard = 11,
}

public enum EWorldmapDialogueType
{
    None = 0,
    MissionStart = 1,
    MissionEnd = 2,
    AreaMove = 3,
}

public enum EWorldmapDialogueSpeaker
{
    None = 0,
    Right = 1,
    Left = 2,
}

public enum EZoneType
{
    ForDev = 0,
    Mission = 1,
    Area = 2,
    Training = 3,
    Count = 4,
}

}
