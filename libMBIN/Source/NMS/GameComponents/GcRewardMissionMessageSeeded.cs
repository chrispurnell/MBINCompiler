﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x309B4877A6240E3, NameHash = 0x56DEE85C9E579653)]
    public class GcRewardMissionMessageSeeded : NMSTemplate
    {
        public NMSString0x10 MessageID;
        public bool BroadcastInMultiplayer;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}