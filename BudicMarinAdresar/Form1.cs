using BudicMarinAdresar.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudicMarinAdresar
{
    public partial class Form1 : Form
    {
        StoreAdresa storeAdresa = new StoreAdresa();   
        List<Osoba> osobe=new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            osobe=storeAdresa.GetOsoba();
            dgAdresar.DataSource = storeAdresa.GetOsoba();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Add dodaj = new Add();
            dodaj.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txSearch.Text == "")
            {
                Init();
            }
            else
            {
                dgAdresar.DataSource = storeAdresa.GetOsobaByData(txSearch.Text);
            }
           

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            dgAdresar.ClearSelection();
       
        }
    }
}
