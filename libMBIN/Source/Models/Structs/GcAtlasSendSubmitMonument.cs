﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1D0)]
    public class GcAtlasSendSubmitMonument : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public GcAtlasMonument Monument;
		public enum MonumentRolesEnum { Creator, CoCreator }
		/* 0x1A0 */ public MonumentRolesEnum MonumentRoles;
        [NMS(Size = 0x20)]
        /* 0x1A4 */ public string OtherUser;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1C4 */ public byte[] EndPadding;
    }
}
