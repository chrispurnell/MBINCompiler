using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x8D71FA6CE0ED29EA, NameHash = 0xB76095BD04FCB5D2)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        public NMSString0x10 ProductId;
        public GcFrigateStatType StatModified;
        public int ValueChange;
        public NMSString0x20A SelectionDescription;
        public NMSString0x20A ModuleDescription;
    }
}
