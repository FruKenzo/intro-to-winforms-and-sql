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
    public partial class DeleteHero : Form
    {
        public DeleteHero()
        {
            InitializeComponent();
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
