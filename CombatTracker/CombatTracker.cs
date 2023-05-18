using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class CombatTracker : Form
    {
        public CombatTracker()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            var ris = MessageBox.Show("Sei sicuro?", "Attenzione!", MessageBoxButtons.YesNo);
            if (ris == DialogResult.Yes)
                dataGridView1.Rows.Clear();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            //MessageBox.Show("AGGIUNTA");
        }
    }
}
