using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad1;

namespace WinFormDataDetails
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void Form2_Load(object sender, EventArgs e)
        {
          
        }
        internal void LoadOrders(string IID)
        {
            var Doc = UseData.GetData().Where(p => p.Kontrahent.Nazwa == IID).ToList();

            var SubListNames = Doc.Select(x => x.Pozycje)
                   .SelectMany(x => x)
                   .ToList();
           

            foreach (PozycjaDokHandlowego d in SubListNames)
            {

                string[] d1 = {
               d.ID.ToString(),
                d.Nazwa,
                d.Ilosc.ToString(),
                d.Cena.ToString()};

             

                dataGridView1.Rows.Add(d1);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

