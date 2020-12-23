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

namespace WinFormData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Doc = UseData.GetData().OrderByDescending(p => p.KwotaDokumentu).ToList();

            foreach (DokHandlowy d in Doc)
            {

                string[] d1 = {
                 d.ID.ToString(),
                 d.Kontrahent.Nazwa,
                 d.KwotaDokumentu.ToString() };

                dataGridView1.Rows.Add(d1).ToString();
                
            };
        }

        
            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            
            {
                dataGridView1.Rows.Clear();
          

                int take = Convert.ToInt32(numericUpDown1.Value);
                var Doc = UseData.GetData().OrderByDescending(p => p.KwotaDokumentu).ToList().Take(take);

                    foreach (DokHandlowy d in Doc)
                    {

                           string[] d1 = {
                            d.ID.ToString(),
                            d.Kontrahent.Nazwa,
                            d.KwotaDokumentu.ToString() };

                            dataGridView1.Rows.Add(d1).ToString();
                    };
            }
    }
}

