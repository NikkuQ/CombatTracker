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
        private int resurrect = 1;

        private bool start = true;
        private bool close;

        public CombatTracker()
        {
            InitializeComponent();
            Player();
            dataGridView1.Columns["col_StatusImage"].DefaultCellStyle.NullValue = null;
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
            dataGridView1.Rows[0].Cells["col_HP"].Value = 999;
            dataGridView1.Rows[1].Cells["col_name"].Value = "MacBeth";
            dataGridView1.Rows[1].Cells["col_HP"].Value = 999;
            dataGridView1.Rows[2].Cells["col_name"].Value = "Samuel";
            dataGridView1.Rows[2].Cells["col_HP"].Value = 999;

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
            {
                dataGridView1.Rows[index].Cells["col_HP"].Value = 0;
                resurrect = hp;
            }
            else
                dataGridView1.Rows[index].Cells["col_HP"].Value = resurrect;

            CheckHP(index);
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int index = dataGridView1.CurrentCell.RowIndex;

            string name = clickedButton.Name;
            string status = (dataGridView1.Rows[index].Cells["col_StatusText"].Value != null)? dataGridView1.Rows[index].Cells["col_StatusText"].Value.ToString() : "";

            Image img = new Bitmap(1, 1);

            switch (name)
            {
                case "btn_Blinded":
                    status = AddRemoveStatus(status, "blinded,");
                    break;
                case "btn_Charmed":
                    status = AddRemoveStatus(status, "charmed,");
                    break;
                case "btn_Deaf":
                    status = AddRemoveStatus(status, "deaf,"); 
                    break;
                case "btn_Frightened":
                    status = AddRemoveStatus(status, "frightened,");
                    break;
                case "btn_Grappled":
                    status = AddRemoveStatus(status, "grappled,");
                    break;
                case "btn_Incapacitated":
                    status = AddRemoveStatus(status, "incapacitated,");
                    break;
                case "btn_Invisible":
                    status = AddRemoveStatus(status, "invisible,");
                    break;
                case "btn_Paralyzed":
                    status = AddRemoveStatus(status, "paralyzed,");
                    break;
                case "btn_Petrified":
                    status = AddRemoveStatus(status, "petrified,");
                    break;
                case "btn_Poisoned":
                    status = AddRemoveStatus(status, "poisoned,");
                    break;
                case "btn_Prone":
                    status = AddRemoveStatus(status, "prone,");
                    break;
                case "btn_Restrained":
                    status = AddRemoveStatus(status, "restrained,");
                    break;
                case "btn_Stunned":
                    status = AddRemoveStatus(status, "stunned,");
                    break;
                case "btn_Unconcious":
                    status = AddRemoveStatus(status, "unconcious,");
                    break;
            }

            dataGridView1.Rows[index].Cells["col_StatusText"].Value = status;

            if (status.Contains("blinded,"))
                img = MergeTwoImages(Properties.Resources.hide, img);
            if (status.Contains("charmed,"))
                img = MergeTwoImages(Properties.Resources.love, img);
            if (status.Contains("deaf,"))
                img = MergeTwoImages(Properties.Resources.deaf, img);
            if (status.Contains("frightened,"))
                img = MergeTwoImages(Properties.Resources.black_cat, img);
            if (status.Contains("grappled,"))
                img = MergeTwoImages(Properties.Resources.hello, img);
            if (status.Contains("incapacitated,"))
                img = MergeTwoImages(Properties.Resources.forbidden, img);
            if (status.Contains("invisible,"))
                img = MergeTwoImages(Properties.Resources.invisibility, img);
            if (status.Contains("paralyzed,"))
                img = MergeTwoImages(Properties.Resources.thunder, img);
            if (status.Contains("petrified,"))
                img = MergeTwoImages(Properties.Resources.granite, img);
            if (status.Contains("poisoned,"))
                img = MergeTwoImages(Properties.Resources.poison, img);
            if (status.Contains("prone,"))
                img = MergeTwoImages(Properties.Resources.no_racism, img);
            if (status.Contains("restrained,"))
                img = MergeTwoImages(Properties.Resources.rope, img);
            if (status.Contains("stunned,"))
                img = MergeTwoImages(Properties.Resources.flashbang, img);
            if (status.Contains("unconcious,"))
                img = MergeTwoImages(Properties.Resources.zzz_sleep_symbol, img);
            //if (status.Contains("deaf,"))
            //    img = MergeTwoImages(Properties.Resources., img);

            dataGridView1.Rows[index].Cells["col_StatusImage"].Value = img;
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

        private string AddRemoveStatus(string status, string addRemove)
        {
            if (!status.Contains(addRemove))
                status += addRemove;
            else
                status = status.Replace(addRemove, "");

            return status;
        }
    }
}
