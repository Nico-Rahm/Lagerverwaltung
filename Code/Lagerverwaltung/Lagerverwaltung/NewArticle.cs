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
    public partial class NewArticle : Form
    {
        public NewArticle()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Article tempArticle = new Article();
            tempArticle.Name = textBox_name.Text;
            tempArticle.Variante = textBox_variant.Text;
            tempArticle.Anzahl = int.Parse(textBox_Count.Text);
            tempArticle.Raum = textBox_room.Text;
            tempArticle.Regal = int.Parse(textBox_shelf.Text);
            tempArticle.Fach = int.Parse(textBox_Part.Text);

            DBConnection dbConnection = DBConnection.Instance;
            dbConnection.StoreArticle(tempArticle);
            this.Close();
        }
    }
}
