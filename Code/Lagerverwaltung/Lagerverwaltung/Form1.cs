namespace Lagerverwaltung
{
    public partial class Storemanagement : Form
    {
        String selectedRowName;
        int selectedRowID;
        int selectedArticleID;
        public int count;


        public Storemanagement()
        {
            InitializeComponent();
        }

        private void Storemagemanagement_Load(object sender, EventArgs e)
        {
            radioButton_name.Checked = true;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            List<Article> articles = new List<Article>();
            if (textBox_search.Text == "")
            {
                DBConnection dbConnection = DBConnection.Instance;
                articles = dbConnection.LoadArticles(null);
            }

            else if(radioButton_name.Checked)
            {
                DBConnection dbConnection = DBConnection.Instance;
                articles = dbConnection.LoadArticles(textBox_search.Text);
            }

            int rowCount = 0;
            foreach (Article article in articles)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1[0, rowCount].Value = article.Id;
                dataGridView1[1, rowCount].Value = article.Name;
                dataGridView1[2, rowCount].Value = article.Variante;
                dataGridView1[3, rowCount].Value = article.Anzahl;
                dataGridView1[4, rowCount].Value = article.Raum;
                dataGridView1[5, rowCount].Value = article.Regal;
                dataGridView1[6, rowCount].Value = article.Fach;
                rowCount++;
            }
        }

        private void button_take_Click(object sender, EventArgs e)
        {
            Take take = new Take(selectedArticleID);
            take.Visible = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRowIndex = e.RowIndex;
            selectedRowID = int.Parse(dataGridView1.Rows[iRowIndex].Cells[0].Value.ToString());
            selectedArticleID = selectedRowID;
            selectedRowName = dataGridView1.Rows[iRowIndex].Cells[1].Value.ToString();
        }

        private void button_store_Click(object sender, EventArgs e)
        {
            Store store = new Store(selectedArticleID);
            store.Visible = true;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            NewArticle newArticle = new NewArticle();
            newArticle.Visible = true;
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            Move move = new Move(selectedArticleID);
            move.Visible = true;
        }
    }
}