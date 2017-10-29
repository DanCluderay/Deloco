using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloco_Pos_C.base_classes
{
    public class productclass
    {
        public int BrandProductID { get; set; }
        public string FullProductName { get; set; }
        public string PreFix { get; set; }
        public string PostFox { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public bool BrandInName { get; set; }
        public string BrandProductName { get; set; }
        public string BrandProductSize { get; set; }

        public string SizeString { get; set; }

        public double ProductRRP { get; set; }

        public int ProductUnitSize { get; set; }
        public int ProductRelativeSize { get; set; }
        public int ItemWidth { get; set; }
        public int ItemLegnth { get; set; }
        public int ItemHeight { get; set; }
        public int ItemVolume { get; set; }
        public double ItemRealWeight { get; set; }
        public double ItemVolumetricWeight { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductLongDescription { get; set; }
        public double ProductRRP { get; set; }
        public int ProductVATCode { get; set; }
        public int InnerPackQTY { get; set; }
        public bool IsCasePick { get; set; }

        public bool IsLocked { get; set; }
        public int IsLockedBy { get; set; }

    }
}
