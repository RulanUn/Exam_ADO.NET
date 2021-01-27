using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Exam_VarII
{
    public partial class Pop : Window
    {
        string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=RecordStore; Integrated Security=True";
        DataSet ds = new DataSet();

        public Pop()
        {
            InitializeComponent();

            string sqlPop = "SELECT c.name AS Альбом, b.name AS Исполнитель, p.name AS Издатель, amountTrack AS Треков, g.name AS Жанр, yearPublication AS  Издан, " +
                "netCost AS Себестоимость, salePrice AS Продажа, amountDisc AS Количество, dateIncome AS Поступил,  amountSale AS Проданно " +
                "FROM CD c JOIN Band b ON c.id_band = b.id " +
                "JOIN Publisher p ON c.id_publisher = p.id " +
                "JOIN Genre g ON c.id_genre = g.id " +
                "WHERE g.name = 'Поп'";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapterPop = new SqlDataAdapter(sqlPop, connection);
                adapterPop.Fill(ds, "Pop");

                dgMain.ItemsSource = ds.Tables["Pop"].DefaultView;
            }
        }
    }
}
