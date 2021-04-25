﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0xA0, GUID = 0x7F57711DB208B3F0, NameHash = 0xD15F5E0AAE5AA74)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Event;
        /* 0x20 */ public NMSString0x80 DebugText;
    }
}
