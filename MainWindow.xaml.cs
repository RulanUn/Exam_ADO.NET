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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Exam_VarII
{

    public class DiscContext:DbContext
    {
        public DiscContext()
            :base("DBConnection")
        { }

        public DbSet<Disc> Discs { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void ShowProduct(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            AddDisc addDisc = new AddDisc();
            addDisc.Show();
        }

        private void DeletProduct(object sender, RoutedEventArgs e)
        {
        }

        private void UpdateProduct(object sender, RoutedEventArgs e)
        {
        }

        private void SaleProduct(object sender, RoutedEventArgs e)
        {

        }

        private void FindeProductName(object sender, RoutedEventArgs e)
        {

        }

        private void FindeProductSinger(object sender, RoutedEventArgs e)
        {

        }

        private void FindeProductGenre(object sender, RoutedEventArgs e)
        {
            FindeGenre findeGenre = new FindeGenre();
            findeGenre.Show();
        }

        private void ShowNew(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=RecordStore; Integrated Security=True";
            DataSet ds = new DataSet();

            string sqlNew = "SELECT TOP 3 b.name AS Band, c.dateIncome FROM CD c JOIN Band b ON c.id_band = b.id ORDER BY dateIncome DESC";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapterNew = new SqlDataAdapter(sqlNew, connection);
                adapterNew.Fill(ds, "New");

                dgMain.ItemsSource = ds.Tables["New"].DefaultView;
            }
        }

        private void ShowBestSaler(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=RecordStore; Integrated Security=True";
            DataSet ds = new DataSet();

            string sqlBestSaler = "SELECT TOP 3 c.name AS BestCd, c.amountSale FROM CD c JOIN Band b ON c.id_band = b.id ORDER BY amountSale DESC";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapterBestSaler = new SqlDataAdapter(sqlBestSaler, connection);
                adapterBestSaler.Fill(ds, "BestSaler");

                dgMain.ItemsSource = ds.Tables["BestSaler"].DefaultView;
            }
        }

        private void ShowMostPopular(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=RecordStore; Integrated Security=True";
            DataSet ds = new DataSet();

            string sqlMostPopular = "SELECT TOP 3 b.name AS BestBand, c.amountSale FROM CD c JOIN Band b ON c.id_band = b.id ORDER BY amountSale DESC";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapterMostPopular = new SqlDataAdapter(sqlMostPopular, connection);
                adapterMostPopular.Fill(ds, "MostPopular");

                dgMain.ItemsSource = ds.Tables["MostPopular"].DefaultView;
            }
        }

        private void dgMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
