using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperheroesWinApp
{
    public partial class UpdateHero : Form
    {
        public UpdateHero()
        {
            InitializeComponent();
        }

        private void UpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
