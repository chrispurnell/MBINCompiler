using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD6A0, GUID = 0x6C64322C18E67BAA, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x10, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01D4 */ public byte[] Padding1D4;
        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        /* 0x03E8 */ public NMSString0x80 TechnologyTable;
        /* 0x0468 */ public NMSString0x80 SubstanceTable;
        /* 0x04E8 */ public NMSString0x80 ProductTable;
        /* 0x0568 */ public NMSString0x80 ProceduralProductTable;
        /* 0x05E8 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x0668 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x06E8 */ public List<TkRawID> LegacyRepairTable;
        /* 0x06F8 */ public NMSString0x80 ConsumableItemTable;
        /* 0x0778 */ public NMSString0x80 RecipeTable;
        /* 0x07F8 */ public NMSString0x80 AlienWordsTable;
        /* 0x0878 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x72, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0888 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x72, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x08FC */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0AC4 */ public TkCurveType[] WeightingCurves;
        /* 0x0AE0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x0AF0 */ public NMSString0x80 RewardTable;
        /* 0x0B70 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x0BF0 */ public NMSString0x80 InventoryTable;
        /* 0x0C70 */ public NMSString0x80 DamageTable;
        /* 0x0CF0 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x0D70 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x0DF0 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x0E70 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x0EF0 */ public NMSString0x80 CostTable;
        /* 0x0F70 */ public NMSString0x80 TradingCostTable;
        /* 0x0FF0 */ public NMSString0x80 TradingClassDataTable;
        /* 0x1070 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x10F0 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x1170 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1180 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xF, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1340 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1430 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x14A0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1520 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1620 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1740 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x18CC */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1A58 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1BE4 */ public float[] WeightedTextWeights;
        /* 0x1BF0 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x6CA8 */ public byte[] Padding6CA8;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6CB0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6D10 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6D40 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6DD0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7274 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xC680 */ public GcStats[] Stats;
        /* 0xC6D0 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xC6E0 */ public GcTechList[] PlanetTechShops;
        /* 0xC7E0 */ public GcTradeSettings TradeSettings;
        /* 0xD588 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xD5A8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xD5C8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xD5E8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xD608 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xD628 */ public List<int> SuitUpgradePrices;
        /* 0xD638 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xD648 */ public List<int> SuitCargoUpgradePrices;
        /* 0xD658 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xD668 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xD678 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD68C */ public byte[] PaddingD68C;
        /* 0xD690 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}
