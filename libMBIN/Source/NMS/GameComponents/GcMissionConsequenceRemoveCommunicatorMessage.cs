﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x6B9AF43F59587621, NameHash = 0xE2DF0C2D3E6E3BF8)]
    public class GcMissionConsequenceRemoveCommunicatorMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Comms;
    }
}