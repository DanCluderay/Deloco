using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloco_Pos_C.base_classes
{
    public class productclass
    {
        public int ProductID { get; set; }
        public int BrandProduct { get; set; }
        public string ProductName { get; set; }
        public string ProductFullName { get; set; }
        public string PreFix { get; set; }
        public string PostFix { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public bool BrandInName { get; set; }
        public string BrandProductName { get; set; }
        public string BrandProductSize { get; set; }
        
        public double ProductRRP { get; set; }

        public int SizeUnit { get; set; }
        public int SizeRelative { get; set; }
        public int ProductItemWidth { get; set; }
        public int ProductItemLenght { get; set; }
        public int ProductItemHeight { get; set; }
        public int ProductTotalVolume { get; set; }
        public double ProductRealWeight { get; set; }
        public double ProductVolumetricWeight { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductLongDescription { get; set; }

        public int ProductVateCode { get; set; }
        public int InnerPackQty { get; set; }
        public bool IsCasePick { get; set; }

        public double ProductItemRRP { get; set; }

        public bool ISLocked { get; set; }
        public int IsLockedBy { get; set; }
        
    }
}
