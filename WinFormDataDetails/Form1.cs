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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            MessageBox.Show(name.ToString());

            Form2 OrdersForm = new Form2();
            OrdersForm.LoadOrders(name);
            OrdersForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Doc = UseData.GetData().ToList();

            foreach (DokHandlowy d in Doc)
            {

                string[] kontrahent = 
                {
                 
                 d.Kontrahent.Nazwa
                                        
                };

                dataGridView1.Rows.Add(kontrahent).ToString();

            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
