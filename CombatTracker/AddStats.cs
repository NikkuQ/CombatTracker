using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class AddStats : Form
    {
        private static string _init;
        private static string _nome;
        private static string _pf;

        private bool close = true;

        SoundPlayer sp;

        public string Init
        {
            get => _init;
            set => _init = value;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string PF
        {
            get => _pf;
            set => _pf = value;
        }

        public AddStats()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            _init = tb_Init.Text;
            _nome = tb_Nome.Text;
            _pf = tb_PF.Text;

            if (_init == "" && _nome == "" && _pf == "")
            {
                close = true;
                this.Close();
            }
            else if (int.TryParse(_init, out int out1) && int.TryParse(_pf, out int out2))
            {
                close = false;
                this.Close();
            }
            else
                PlaySound();

        }

        public string[] AddValues()
        {
            string[] valori = { _init, _nome, _pf };

            _init = "";
            _nome = "";
            _pf = "";

            return valori;
        }

        private void PlaySound()
        {
            sp = new SoundPlayer(Properties.Resources.Windows_Critical_Stop);
            sp.Play();
        }

        public void ModifyValues(string init, string nome, string pf)
        {
            tb_Init.Text = init;
            tb_Nome.Text = nome;
            tb_PF.Text = pf;
        }

        public bool CheckClose()
        {
            return close;
        }
    }
}
