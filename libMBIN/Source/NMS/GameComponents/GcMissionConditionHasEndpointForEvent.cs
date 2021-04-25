using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0xAAD32DFB31A5AB4B, NameHash = 0x9C35F879928BF0CE)]
    public class GcMissionConditionHasEndpointForEvent : NMSTemplate
    {
        public NMSString0x20 EventID;
        public float MaxDistance;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
