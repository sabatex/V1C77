﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C77.Models.Metadata
{
    public class RootMetadata1C77:ObjectMetadata1C77
    {
        public string Name { get; set; }
        public Dictionary<string, ConstantMetadata1C77> Константы { get; set; }
        public Dictionary<string, CatalogMetadata1C77> Справочники { get; set; }
        public Dictionary<string, CommonDocummentAttributeMetadata1C77> ОбщиеРеквизитыДокумента { get; set; }
        public Dictionary<string, DocummentMetadata1C77> Документы { get; set; }
        public Dictionary<string, EnumMetadata1C77> Перечисления { get; set; }
        //public Dictionary<string, PlanCountMetadata1C77> ПланСчетов { get; set; }
        
    }
}
