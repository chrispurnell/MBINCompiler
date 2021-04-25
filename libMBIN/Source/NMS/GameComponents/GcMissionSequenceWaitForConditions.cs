﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, Alignment = 0x8, GUID = 0xA214A4B55D725F57, NameHash = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;
        /* 0x088 */ public List<NMSTemplate> Conditions;
        /* 0x098 */ public NMSString0x80 DebugText;
        /* 0x118 */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] EndPadding;
    }
}
