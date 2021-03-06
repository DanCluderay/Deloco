﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deloco_Pos_C.views
{

    public partial class frmAddLocation : Form
    {
        helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        local_datasets.LocationTypes LocTypes =new local_datasets.LocationTypes();
        string defaultType;
        local_datasets.LocationGrid LocDS;
        int _parentID;
        int _building;
        string StoreName;
        public event EventHandler On_NewLayOutAdded = delegate { };
        public frmAddLocation()
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
        }
        public frmAddLocation(int building, string LocationType,int ParentID, local_datasets.LocationGrid DS,int Ord)
        {
            InitializeComponent();
            helper_functions.globalHelper logic_global = helper_functions.globalHelper.Instance;
            defaultType = LocationType;
            LocDS = new local_datasets.LocationGrid();
            LocDS.Merge(DS);
            _parentID = ParentID;
            txtLocationPickOrder.Text = Ord.ToString();
            _building = building;
            DataRow locrow;
            if (_building==0)
            {

            }
            else
            {
                locrow = DS.Location_Grid.FindByLocGridID(_building);
                StoreName = locrow["LocName"].ToString();
            }

            this.Text = this.Text + " - " + StoreName;
            if (LocationType=="1")
            {
                this.Text = "Add new business";
            }
            else if (LocationType == "2")
            {
                this.Text = "Add new Building";
            }
            else if (LocationType == "3")
            {
                this.Text = "Add new Zone";
            }

            if (ParentID==0)
            {
                
            }
            else
            {
                txtParentID.Text = ParentID.ToString();
                DataRow[] Results;
                string expression = "LocGridID = " + ParentID.ToString();
                Results = LocDS.Location_Grid.Select(expression);
                if (Results.Length == 1)
                {
                    string LocationName = Results[0]["LocName"].ToString();
                    string LocationFullName = Results[0]["FullName"].ToString();
                    string LocationShortName = Results[0]["ShortName"].ToString();

                    txtParentName.Text = LocationFullName;
                    txtFullName.Text = LocationFullName;
                    txtShortName.Text = LocationShortName;
                    txtLocationPickOrder.Text = Ord.ToString();
               
                }
                

            }
            }


        private void frmAddLocation_Load(object sender, EventArgs e)
        {
            //get the location types
            LocTypes.Merge(logic_global.Get_LocationTypes());
            locationTypes.Clear();
            locationTypes.Merge(LocTypes);
            cmbLocationType.SelectedValue =int.Parse( defaultType.ToString());
            cmbLocationType.Enabled = false;
            //locationGrid = new local_datasets.LocationGrid();
            storecontroltypeBindingSource.Filter = "";
            locationGrid.Merge(logic_global.GetStoreLayoutDataset());
            this.Refresh();
            if( int.Parse( defaultType) == 4)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLocation();
        }
        private void AddLocation()
        {
            //location Store name
            
            //get loc name
            string Locaname = txtLocationName.Text.ToString();

            if(_building==0)
            {
                StoreName = Locaname;
            }
            //get loc type
            int LocationType = int.Parse( cmbLocationType.SelectedValue.ToString());
            //get loc order
            int Locaorder = 0;
            bool res = int.TryParse(txtLocationPickOrder.Text.ToString(), out Locaorder);
            int PID;
            bool rest = int.TryParse(txtParentID.Text, out PID);
            if(rest==false)
            {
                PID = 0;
            }
            
            int newLocationID = logic_global.CreateLocGridItem2(Locaname, LocationType, PID, txtFullName.Text,txtShortName.Text,int.Parse(txtLocationPickOrder.Text), StoreName);

            if(LocationType==4)
            {
                //We need to add Store Location Layout Data
                int BayLayoutType = 0;
                BayLayoutType = int.Parse(cmbZoneLayoutType.SelectedValue.ToString());
                logic_global.AddNewStoreLayoutRow(_building, newLocationID, BayLayoutType, 0, 0, 0,0);
                On_NewLayOutAdded(this, new EventArgs());
            }
            this.WindowState = FormWindowState.Normal;
            this.Close();
            
        }

        private void txtLocationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocationName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void CheckFullNames()
        {
            string Locreplace = txtLocationName.Text.Replace(" ","_");
            
            string pname = txtParentName.Text;
            if(pname=="")
                {

                }
            else
            {
                pname = pname + "_";
            }
            txtFullName.Text = pname  + Locreplace.ToString();
            txtShortName.Text= pname  + Locreplace.ToString();
        }

        private void txtLocationName_KeyUp(object sender, KeyEventArgs e)
        {
            CheckFullNames();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLocationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
