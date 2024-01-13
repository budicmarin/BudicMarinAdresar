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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        public void Init()
        {
            StoreAdresa store=new StoreAdresa();
            cbOsobe.DataSource = store.GetOsoba();
        }
        
        private void Kreiraj_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();
            osoba.Ime = txName.Text;
            osoba.Prezime=txPrezime.Text;
            osoba.Broj=txBroj.Text;
            osoba.Grad=txGrad.Text;
            osoba.Ulica=txUlica.Text;   
            osoba.Drzava=txDrzava.Text; 
            osoba.PostanskiBroj=txPostanski.Text;   

           StoreAdresa storeAdresa = new StoreAdresa();
            storeAdresa.AddOsoba(osoba);

        }
    }
}
