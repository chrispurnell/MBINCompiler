﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0BDF1E47D45616C77)]
    public class TkLocalisationEntry : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;

        public VariableSizeString English;
        public VariableSizeString French;
        public VariableSizeString Italian;
        public VariableSizeString German;
        public VariableSizeString Spanish;
        public VariableSizeString Russian;
        public VariableSizeString Polish;
        public VariableSizeString Dutch;
        public VariableSizeString Portuguese;
        public VariableSizeString LatinAmericanSpanish;
        public VariableSizeString BrazilianPortuguese;
        public VariableSizeString SimplifiedChinese;
        public VariableSizeString TraditionalChinese;
        public VariableSizeString Korean;
        public VariableSizeString Japanese;
        public VariableSizeString USEnglish;
    }
}