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
using static CalculationMethods_L3_WPF.GaussianMethod;

namespace CalculationMethods_L3_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            double[,] system =
            {
                {Double.Parse(TBx1_1.Text.Replace('.', ',')), Double.Parse(TBx2_1.Text.Replace('.', ',')), 
                    Double.Parse(TBx3_1.Text.Replace('.', ',')), Double.Parse(TBx4_1.Text.Replace('.', ',')), 
                    Double.Parse(TBv1.Text.Replace('.', ','))},
                {Double.Parse(TBx1_2.Text.Replace('.', ',')), Double.Parse(TBx2_2.Text.Replace('.', ',')), 
                    Double.Parse(TBx3_2.Text.Replace('.', ',')), Double.Parse(TBx4_2.Text.Replace('.', ',')), 
                    Double.Parse(TBv2.Text.Replace('.', ','))},
                {Double.Parse(TBx1_3.Text.Replace('.', ',')), Double.Parse(TBx2_3.Text.Replace('.', ',')), 
                    Double.Parse(TBx3_3.Text.Replace('.', ',')), Double.Parse(TBx4_3.Text.Replace('.', ',')),
                    Double.Parse(TBv3.Text.Replace('.', ','))},
                {Double.Parse(TBx1_4.Text.Replace('.', ',')), Double.Parse(TBx2_4.Text.Replace('.', ',')), 
                    Double.Parse(TBx3_4.Text.Replace('.', ',')), Double.Parse(TBx4_4.Text.Replace('.', ',')), 
                    Double.Parse(TBv4.Text.Replace('.', ','))}
            };
            
            TbOutput.Text = Gauss(system);
        }
    }
}