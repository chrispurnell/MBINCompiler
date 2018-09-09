﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcAtlasRecvBaseList : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int NumberOfbases;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        public List<GcAtlasBase> Bases;
        public List<GcTerrainEditsBuffer> BaseTerrainEdits;     // just a guess...
    }
}
