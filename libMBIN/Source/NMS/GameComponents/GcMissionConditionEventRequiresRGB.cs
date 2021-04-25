using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x7C8690206AE1767F, NameHash = 0x36CE03A85A61CBFB)]
    public class GcMissionConditionEventRequiresRGB : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Event;
        /* 0x20 */ public bool IgnoreIfPlayerHasAccess;
        /* 0x24 */ public GcGalaxyStarTypes StarType;
    }
}
