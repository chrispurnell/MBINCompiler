﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x1F893025804FBD28, NameHash = 0x7355BB5E5AC6EB4A)]
    public class GcInteractionBuffer : NMSTemplate
    {
        public List<GcInteractionData> Interactions;
        public int CurrentPos;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
