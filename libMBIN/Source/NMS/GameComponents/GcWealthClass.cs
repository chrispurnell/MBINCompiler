﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0BEB3844828C75A77)]
    public class GcWealthClass : NMSTemplate
    {
		public enum WealthClassEnum { Poor, Average, Wealthy }
		public WealthClassEnum WealthClass;
    }
}