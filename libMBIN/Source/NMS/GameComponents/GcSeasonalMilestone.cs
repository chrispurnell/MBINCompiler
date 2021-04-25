using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x758, GUID = 0x1B69111BCBFD9AF7, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Mission;
        /* 0x010 */ public NMSString0x20 Title;
        /* 0x030 */ public NMSString0x20 TitleUpper;
        /* 0x050 */ public NMSString0x20 Description;
        /* 0x070 */ public NMSString0x20 DescriptionDone;
        /* 0x090 */ public NMSString0x10 Id;
        /* 0x0A0 */ public float Amount;
        /* 0x0A4 */ public int StageIndex;
        /* 0x0A8 */ public int MilestoneIndex;
        /* 0x0AC */ public TkTextureResource Icon;
        /* 0x130 */ public TkTextureResource IconGrey;
        /* 0x1B4 */ public TkTextureResource MissionIcon;
        /* 0x238 */ public TkTextureResource MissionIconSelected;
        /* 0x2BC */ public TkTextureResource MissionIconNotSelected;
        /* 0x340 */ public NMSString0x10 Reward;
        /* 0x350 */ public bool IsRendezvous;
        /* 0x351 */ public bool IsStageControl;
        /* 0x352 */ public NMSString0x200 RewardDescription;
        /* 0x552 */ public NMSString0x200 CantClaimRewardDescription;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x752 */ public byte[] EndPadding;
    }
}
