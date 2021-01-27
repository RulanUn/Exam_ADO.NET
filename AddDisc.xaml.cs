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
    public partial class AddDisc : Window
    {
        public AddDisc()
        {
            InitializeComponent();
        }

        private void AddCd(object sender, RoutedEventArgs e)
        {
            string nameCd = NameCd.Text;
            string nameBand = NameBand.Text;
            string namePublisher = NamePublisher.Text;
            int amountTrack = Convert.ToInt32(AmountTrack.Text);
            string nameGenre = NameGenre.Text;
            string yearPublisher = YearPublisher.Text;
            double netCoast = Convert.ToInt32(NetCoast.Text);
            double salePrice = Convert.ToInt32(SalePrice.Text);
            int amountDisc = Convert.ToInt32(AmountDisc.Text);
            string dateIncome = DateIncome.Text;
        }
    }
}
