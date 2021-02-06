using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace game_2
{
    class sql
    {
        public static string conroad = "Data Source=42.192.37.235;Initial Catalog=game_2;User ID=game_2;Password=wxy60160128175/";
        public static void constr()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "CREATE TABLE ACCOUNT_(MARK INT,ACCOUNT char(30),PASSWORD INT)";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static void mess_create()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "CREATE TABLE MESSAGE(MARK INT,DOLLAR INT,EXP INT,LV INT,ZOMBIEQUN INT)";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static bool mess_exist(int find_mark)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();bool flag = false;
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM MESSAGE WHERE MARK = "+find_mark.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            while (p.Read())
            {
                flag = true;
            }
            Comm.Dispose();
            Conn.Close();
            return flag;
        }
        public static void prop_create()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "CREATE TABLE PROP(MARK INT)";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static void plant_create()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "CREATE TABLE PLANT(MARK INT,PLANT_MARK INT,PLANT_LV INT,PLANT_EXP INT,QUALITY FLOAT(53),ATTADD INT,ARMADD INT," +
                "THRADD INT,LIFADD INT,GROWTH INT)";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static void prop_insert_attritube(string name)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "ALTER TABLE PROP ADD "+name+" INT";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
            
        }
        public static void mess_insert_kong(String mymark)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "INSERT INTO MESSAGE VALUES("+mymark+",0,0,0,0)";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static void delaccount()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "DROP TABLE ACCOUNT_";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static void change_account()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "INSERT INTO ACCOUNT_ VALUES(0,0,0)";
            Comm.CommandText = sql;
            Comm.ExecuteReader();
            Comm.Dispose(); Conn.Close();
        }
        public static int account_verification(string account_,string password_)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM ACCOUNT_ WHERE ACCOUNT = " + account_.ToString();
            Comm.CommandText = sql; string ans = "0";
            SqlDataReader p = Comm.ExecuteReader();

            while (p.Read())
            {
                ans = p["mark"].ToString();
                if (password_ != p["password"].ToString()) ans = "0";
            }
            Comm.Dispose();
            Conn.Close();
            return int.Parse(ans);

        }
        public static void get_mess()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM MESSAGE WHERE MARK = "+MainWindow.mymain_interface.id.ToString() ;
            Comm.CommandText = sql; 
            SqlDataReader p = Comm.ExecuteReader();
            while (p.Read())
            {
                MainWindow.mymain_interface.peo_dollar = int.Parse(p["dollar"].ToString());
                MainWindow.mymain_interface.peo_exp = int.Parse(p["exp"].ToString());
                MainWindow.mymain_interface.peo_level = int.Parse(p["lv"].ToString());
                MainWindow.mymain_interface.peo_qun = int.Parse(p["zombiequn"].ToString());
            }
            Comm.Dispose();
            Conn.Close();

        }
        public static int get_plat_mark()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();string ans="0";
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM DATE_MESS";
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            while (p.Read())
            {
                ans = p["plant_allmark"].ToString();
            }
            Comm.Dispose();
            Conn.Close();
            return int.Parse(ans);
        }
        public static void get_plat_mark_add(int x)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open(); 
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE DATE_MESS SET PLANT_ALLMARK = "+x.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            
            Comm.Dispose();
            Conn.Close();
        }
        public static void get_plant()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM PLANT WHERE MARK = " + MainWindow.mymain_interface.id.ToString()+" ORDER BY PLANT_LV";
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            while (p.Read())
            {
                MainWindow.mymain_interface.plantware[++MainWindow.mymain_interface.allnumber] = new myplant();
                MainWindow.mymain_interface.plantware[MainWindow.mymain_interface.allnumber].update_mess(
                    int.Parse(p["plant_mark"].ToString()), int.Parse(p["plant_lv"].ToString()), int.Parse(p["plant_exp"].ToString()),
                    double.Parse(p["quality"].ToString()), int.Parse(p["attadd"].ToString()), int.Parse(p["armadd"].ToString()),
                    int.Parse(p["thradd"].ToString()), int.Parse(p["lifadd"].ToString()), int.Parse(p["growth"].ToString()),
                    int.Parse(p["plant_pos"].ToString()));
            }
            Comm.Dispose();
            Conn.Close();

        }
        public static void get_prop()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM PROP WHERE MARK = " + MainWindow.mymain_interface.id.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            while (p.Read())
            {
                for (int i = 1; i <= 141; ++i)
                    MainWindow.mymain_interface.prop_number[i] = int.Parse(p["p"+i.ToString()].ToString()); 
                for (int i = 901; i <= 945; ++i)
                    MainWindow.mymain_interface.prop_number[i] = int.Parse(p["p" + i.ToString()].ToString());
            }
            Comm.Dispose();
            Conn.Close();

        }
        public static void del_plant(int mark)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "DELETE FROM PLANT WHERE PLANT_POS = "+mark.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();

        }
        public static int account_exist(string account_)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM ACCOUNT_ WHERE ACCOUNT = " + account_.ToString();
            Comm.CommandText = sql; string ans = "0";
            SqlDataReader p = Comm.ExecuteReader();

            while (p.Read())
            {
                ans = "1";
            }
            Comm.Dispose();
            Conn.Close();
            return int.Parse(ans);

        }
        public static int get_nowmark()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "SELECT * FROM ACCOUNT_ WHERE MARK =0";
            Comm.CommandText = sql; string ans = "0";
            SqlDataReader p = Comm.ExecuteReader();

            while (p.Read())
            {
                ans = p["ACCOUNT"].ToString();
            }
            Comm.Dispose();
            Conn.Close();
            return int.Parse(ans);

        }
        public static string sqlget(string a,string b)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = a;
            Comm.CommandText = sql; string ans = "0";
            SqlDataReader p = Comm.ExecuteReader();

            while (p.Read())
            {
                ans = p[b].ToString();
            }
            Comm.Dispose();
            Conn.Close();
            return ans;

        }
        public static void update_account_mark(int number)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE ACCOUNT_ SET ACCOUNT = "+number.ToString()+" WHERE MARK = 0";
            Comm.CommandText = sql; string ans = "0";
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();

        }
        public static int account_register(string account_, string password_)
        {
            int now_mark = get_nowmark() + 1;
            update_account_mark(now_mark);
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "INSERT INTO ACCOUNT_ VALUES(" + now_mark.ToString() + "," + account_ + "," + password_ + ")";
            Comm.CommandText = sql; string ans = "0";
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
            return int.Parse(ans);

        }
        public static void sqlsolve(string a)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = a;
            Comm.CommandText = sql; 
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
        public static void update_dollar()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE MESSAGE SET DOLLAR = "+MainWindow.mymain_interface.peo_dollar.ToString()+
                " WHERE MARK = "+MainWindow.mymain_interface.id.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
        public static void update_lv()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE MESSAGE SET LV = " + MainWindow.mymain_interface.peo_level.ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
        public static void update_exp()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE MESSAGE SET EXP = " + MainWindow.mymain_interface.peo_exp.ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
        public static void update_qun()
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE MESSAGE SET ZOMBIEQUN = " + MainWindow.mymain_interface.peo_qun.ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
        public static void sql_add_prop(int mark )
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE PROP SET p"+mark.ToString()+" = "+MainWindow.mymain_interface.prop_number[mark].ToString()+
                " WHERE MARK = "+MainWindow.mymain_interface.id.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
        public static void update_plant(int pos)
        {
            SqlConnection Conn = new SqlConnection(conroad);
            Conn.Open();
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            string sql = "UPDATE PLANT SET PLANT_MARK = "+MainWindow.mymain_interface.plantware[pos].mark+",PLANT_LV = "+
                MainWindow.mymain_interface.plantware[pos].lv+",PLANT_EXP = "+MainWindow.mymain_interface.plantware[pos].exp+
                ",QUALITY = "+MainWindow.mymain_interface.plantware[pos].quality+",ATTADD = "+MainWindow.mymain_interface.plantware[pos].attadd+
                ",LIFADD = "+MainWindow.mymain_interface.plantware[pos].lifadd+",ARMADD = "+MainWindow.mymain_interface.plantware[pos].armadd+
                ",THRADD = "+MainWindow.mymain_interface.plantware[pos].thradd+",GROWTH = "+MainWindow.mymain_interface.plantware[pos].growth+
                " WHERE PLANT_POS = "+MainWindow.mymain_interface.plantware[pos].plant_pos.ToString();
            Comm.CommandText = sql;
            SqlDataReader p = Comm.ExecuteReader();
            Comm.Dispose();
            Conn.Close();
        }
    }
}
