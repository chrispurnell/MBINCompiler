﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, Alignment = 0x8, GUID = 0x9A4892E019812B3B, NameHash = 0xD6D2BF5DDCCD9F49)]
    public class GcRewardScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
		public enum ScanEventTableEnum { Space, Planet, Missions, Tutorial, MissionsCreative, NPCPlanetSite }
		/* 0x20 */ public ScanEventTableEnum ScanEventTable;
        /* 0x24 */ public bool DoAerialScan;
        /* 0x25 */ public bool UseMissionSeedForEvent;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x26 */ public byte[] EndPadding;
    }
}
