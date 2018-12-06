using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevChef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            WORKER ChefDeCuisine = new WORKER();
            WORKER SousChef = new WORKER();
            InitializeComponent();
            using (var db = new Cuisine())
            {
                var workers = db.WORKERS.ToList(); ;

                textBox1.Text = "Tout les bosseurs";

                ChefDeCuisine = workers.First();
                SousChef = workers.Find(ID_WORKERS = 1);

                textBox1.Text = ChefDeCuisine.NOM_WORKERS;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
