using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class Move : Form
    {
        int articleID;

        public Move(int particleID)
        {
            InitializeComponent();
            articleID = particleID;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            DBConnection dbConnection = DBConnection.Instance;
            dbConnection.move(articleID, textBox_room.Text, textBox_shelf.Text, textBox_part.Text);
            this.Close();
        }
    }
}
