using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloco_Pos_C.base_classes
{
    public class ZoneClass
    {
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


        public int id;

        public int ControlType;
        public int X_Position;
        public int Y_Position;


        public BayClass[] Bays { get; private set; }

        public void AddBay(string BayName, string BayID)
        {

        }

        public bool IsBayInClass(string BayID)
        {
            return true;
        }

        public BayClass GetBays()
        {
            BayClass Bays;
            Bays = new BayClass();
            return Bays;
        }
    }

    public class BayClass
    {
        private string bayname;
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

        private string bayid;
        public string BayID
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
