using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloco_Pos_C.base_classes
{
    public class ZoneClass
    {
        public event EventHandler On_ZoneHighLighted = delegate { };
        
        private string zonename;
        public string ZoneName
        {
            get
            {
                return zonename;
            }
            set
            {
                zonename = value;
            }
        }
        public int ZoneParentID;
        public string ParentFullName;
        public string ParentShortlName;
        private string zoneid;
        public string ZoneID
        {
            get
            {
                return zoneid;
            }

            set
            {
                zoneid = value;
            }
        }
        private bool haschanged;
        public int ZoneOrder;

        public bool HasChanged
        {
            get
            {
                return haschanged;
            }
            set
            {
                haschanged = value;
            }
        }

        private int buildingID;
        
        public int BuildingID
        {
            get
            {
                return buildingID;
            }

            set
            {
                buildingID = value;
            }
        }

        public void HighlightZone(System.Drawing.Color thecolour)
        {
            On_ZoneHighLighted(this, new EventArgs());
        }
        public int id;

        //public int ControlType;
        //public int X_Position;
        //public int Y_Position;
        //private BayClass[] bays;

        //public BayClass GetBay(int BayID)
        //{
        //    return bays[BayID];
        //}

        //public void AddBay(BayClass the_bay)
        //{
        //    bays[bays.Length] = the_bay;
        //}

        //public bool IsBayInClass(string BayID)
        //{
        //    return true;
        //}

        public BayClass GetBays()
        {
            BayClass Bays;
            Bays = new BayClass();
            return Bays;
        }
    }

    public class BayClass
    {
        public event EventHandler On_Bay_Clicked = delegate { };
        
        private string bayname;
        public int BayLayoutID;
        public string ParentFullName;
        public string ParentShortlName;
        public int BayControlType;
        public int BayX_Position;
        public int BayY_Position;
        public string BayName
        {
            get
            {
                return bayname;
            }

            set
            {
                bayname = value;
            }
        }
        public int BayOrder;
        public int BayParentID;
        public bool IsHighlighted;
        public bool HasChanged { get; set; }
        private int bayid;
        public int BayID
        {
            get
            {
                return bayid;
            }

            set
            {

                bayid = value;
            }
        }

        public void  HighLightBay(System.Drawing.Color Col)
        {
            On_Bay_Clicked(this, new EventArgs());
        }

        public void AddShelf(string ShelfID,string ShelfName)
        {

        }
        
    }


    public class ShelfClass
    {
        private string shelfid;

        public string ShelfID
        {
            get
            {
                return shelfid;
            }

            set
            {
                shelfid = value;
            }
        }

        public void AddShelf(string ShelfID, string ShelfName)
        {

        }
    }



    public class PickClass
    {
        private string pickname;

        public string PickID
        {
            get
            {
                return pickname;
            }

            set
            {
                pickname = value;
            }
        }

        public void AddPick(string PickID, string PickName)
        {

        }
    }
}
