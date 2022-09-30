using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lagerverwaltung;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lagerverwaltung
{
    public partial class Take : Form
    {
        int articleID;

        public Take(int particleID)
        {
            InitializeComponent();
            articleID = particleID;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Tools tools = Tools.Instance;
            DBConnection dbConnection = DBConnection.Instance;
            dbConnection.ChangeCount(articleID, tools.getArticleCount(articleID) - int.Parse(textBox1.Text));
            this.Close();
        }
    }
}