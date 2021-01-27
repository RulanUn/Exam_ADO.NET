using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
using System.Data.Entity;

namespace Exam_VarII
{
    public partial class FindeGenre : Window
    {

        public FindeGenre()
        {
            InitializeComponent();

        }

        private void Button_FindeGenre(object sender, RoutedEventArgs e)
        {

        }

        private void Pop_Selected(object sender, RoutedEventArgs e)
        {
            Pop pop = new Pop();
            pop.Show();
        }

        private void Rock_Selected(object sender, RoutedEventArgs e)
        {
            Rock rock = new Rock();
            rock.Show();
        }

        private void Jaz_Selected(object sender, RoutedEventArgs e)
        {
            Jaz jaz = new Jaz();
            jaz.Show();
        }

        private void Classic_Selected(object sender, RoutedEventArgs e)
        {
            Classic classic = new Classic();
            classic.Show();
        }

        private void Metall_Selected(object sender, RoutedEventArgs e)
        {
            Metall metall = new Metall();
            metall.Show();
        }

        private void Bluz_Selected(object sender, RoutedEventArgs e)
        {
            Bluz bluz = new Bluz();
            bluz.Show();
        }

        private void Rep_Selected(object sender, RoutedEventArgs e)
        {
            Rep rep = new Rep();
            rep.Show();
        }

        private void cmbDeviceDefinitionId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
