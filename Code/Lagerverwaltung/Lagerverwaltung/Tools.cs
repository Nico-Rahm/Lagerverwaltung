using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class Tools
    {
        static Tools instance = new Tools();

        private Tools() { }

        public static Tools Instance
        {
            get
            {
                return instance;
            }
        }

        public int getArticleCount(int id)
        {
            List<Article> articles = new List<Article>();
            DBConnection dbConnection = DBConnection.Instance;
            articles = dbConnection.LoadArticlesId(id.ToString());
            int oldCount = articles[0].Anzahl;
            return oldCount;
        }
    }
}
