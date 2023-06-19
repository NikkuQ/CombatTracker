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
        private int i = 2;
        private int output;

        private bool start = true;
        private bool close;


        //private bool blinded;
        //private bool charmed;
        //private bool deaf;
        //private bool frightned;
        //private bool grappled;
        //private bool incapacitated;
        //private bool invisible;
        //private bool paralyzed;
        //private bool petrified;
        //private bool poisoned;
        //private bool prone;
        //private bool restrained;
        //private bool stunned;
        //private bool unconcious;

        //List<Image> status = new List<Image>();

        public CombatTracker()
        {
            InitializeComponent();
            Player();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            if (close)
                dataGridView1.Rows.RemoveAt(i);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            var ris = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (ris == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                start = true;
                Player(); 
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!start)
            {
                i++;

                var AddForm = new AddStats();
                AddForm.ShowDialog();

                close = AddForm.CheckClose();

                if (!close)
                {
                    string[] valori = AddForm.AddValues();

                    dataGridView1.Rows[i].Cells["col_init"].Value = int.Parse(valori[0]);
                    dataGridView1.Rows[i].Cells["col_name"].Value = valori[1];
                    dataGridView1.Rows[i].Cells["col_HP"].Value = int.Parse(valori[2]);

                    dataGridView1.Sort(col_Init, ListSortDirection.Descending);
                }
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            i--;
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            string init = (dataGridView1.Rows[index].Cells["col_init"].Value != null)? dataGridView1.Rows[index].Cells["col_init"].Value.ToString() : "0";
            string nome = dataGridView1.Rows[index].Cells["col_name"].Value.ToString();
            string pf = (dataGridView1.Rows[index].Cells["col_HP"].Value != null)? dataGridView1.Rows[index].Cells["col_HP"].Value.ToString() : "0";

            var AddForm = new AddStats();
            AddForm.ModifyValues(init, nome, pf);
            AddForm.ShowDialog();

            string[] valori = AddForm.AddValues();

            dataGridView1.Rows[index].Cells["col_init"].Value = int.Parse(valori[0]);
            dataGridView1.Rows[index].Cells["col_name"].Value = valori[1];
            dataGridView1.Rows[index].Cells["col_HP"].Value = int.Parse(valori[2]);

            CheckHP(index);

            dataGridView1.Sort(col_Init, ListSortDirection.Descending);
        }

        private void btn_Dmg_Click(object sender, EventArgs e)
        {
            if (CheckVal())
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                string dato = dataGridView1.Rows[index].Cells["col_HP"].Value.ToString();

                int ris = int.Parse(dato) - output;

                dataGridView1.Rows[index].Cells["col_HP"].Value = ris;

                CheckHP(index);
            }
        }

        private void btn_Heal_Click(object sender, EventArgs e)
        {
            if (CheckVal())
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                string dato = dataGridView1.Rows[index].Cells["col_HP"].Value.ToString();

                int ris = int.Parse(dato) + output;

                dataGridView1.Rows[index].Cells["col_HP"].Value = ris;

                CheckHP(index);
            }
        }

        private bool CheckVal()
        {
            if (int.TryParse(tb_Val.Text, out output))
                return true;
            else
                return false;
        }

        private void Player()
        {
            for(int i = 0; i < 3; i++)
                dataGridView1.Rows.Add();

            dataGridView1.Rows[0].Cells["col_name"].Value = "Tenente";
            dataGridView1.Rows[0].Cells["col_HP"].Value = "999";
            dataGridView1.Rows[1].Cells["col_name"].Value = "MacBeth";
            dataGridView1.Rows[1].Cells["col_HP"].Value = "999";
            dataGridView1.Rows[2].Cells["col_name"].Value = "Samuel";
            dataGridView1.Rows[2].Cells["col_HP"].Value = "999";

            start = false;
        }

        private void CheckHP(int index)
        {
            if (int.Parse(dataGridView1.Rows[index].Cells["col_HP"].Value.ToString()) <= 0)
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Red;

            else
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Modify_Click(sender, e);
        }

        private void btn_Kill_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            int hp = int.Parse(dataGridView1.Rows[index].Cells["col_HP"].Value.ToString());

            if (hp > 0)
                dataGridView1.Rows[index].Cells["col_HP"].Value = "0";
            else
                dataGridView1.Rows[index].Cells["col_HP"].Value = "999";

            CheckHP(index);
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            string name = clickedButton.Name;

            int index = dataGridView1.CurrentCell.RowIndex;

            Image img = new Image();

            bool blinded;
            bool charmed;
            bool deaf;
            bool frightned;
            bool grappled;
            bool incapacitated;
            bool invisible;
            bool paralyzed;
            bool petrified;
            bool poisoned;
            bool prone;
            bool restrained;
            bool stunned;
            bool unconcious;

            //status.Add(Properties.Resources.edit);

            switch (name)
            {
                case "btn_Blinded":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Charmed":
                    img = Properties.Resources.hide;
                    //status.Add(Properties.Resources.love);
                    //foreach (Image img in status)
                    //    dataGridView1.Rows[index].Cells["col_Status"].Value = img;
                    break;
                case "btn_Deaf":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Frightened":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Grappled":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Incapacitated":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Invisible":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Paralyzed":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Petrified":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Poisoned":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Prone":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Restrained":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Stunned":
                    img = Properties.Resources.hide;
                    break;
                case "btn_Unconcious":
                    img = Properties.Resources.hide;
                    break;
            }

            var final = MergeTwoImages(img, status);
            //dataGridView1.Rows[index].Cells["col_Status"].Value = img;
        }

        public static Bitmap MergeTwoImages(Image firstImage, Image secondImage)
        {
            if (firstImage == null)
            {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null)
            {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width + secondImage.Width + 1;

            int outputImageHeight = firstImage.Height > secondImage.Height ? firstImage.Height : secondImage.Height;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(firstImage.Width + 1, 0), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }
    }
}
