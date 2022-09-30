using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class DBConnection
    {
        static DBConnection instance = new DBConnection();
        private DBConnection() { }
        public static DBConnection Instance
        {
            get { 
                return instance;
            }
        }

        private String LoadConnectionString()
        {
            return "Data Source = .\\DB.db; Version = 3;";
        }

        public List<Article> LoadArticles(String searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (searchString == null)
                {
                    var output = cnn.Query<Article>("select * from Artikel", new DynamicParameters());
                    return output.ToList();
                }
                else
                {
                    var output = cnn.Query<Article>("select * from artikel where name like '%" + searchString + "%'", new DynamicParameters());
                    return output.ToList();
                }  
            }
        }

        public List<Article> LoadArticlesId(String searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (searchString == null)
                {
                    var output = cnn.Query<Article>("select * from Artikel", new DynamicParameters());
                    return output.ToList();
                }
                else
                {
                    var output = cnn.Query<Article>("select * from artikel where id like '%" + searchString + "%'", new DynamicParameters());
                    return output.ToList();
                }
            }
        }

        public void StoreArticle(Article article)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into artikel (Name, Variante, Anzahl, Raum, Regal, Fach) values (@Name, @Variante, @Anzahl, @Raum, @Regal, @Fach)", article);
            }
        }

        public void ChangeCount(int ID, int Count)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Artikel set Anzahl = " + Count +" where ID = " + ID);
            }
        }

        public void move(int ID, String room, String shelf, String part)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Artikel set raum = '" + room + "', regal = " + shelf + ", fach = " + part + " where ID = " + ID);
            }
        }

    }
}
