using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, Alignment = 0x8, GUID = 0xF4F36BE36E16AFF7, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 MissionID;
        /* 0x080 */ public NMSString0x80 DebugText;
    }
}