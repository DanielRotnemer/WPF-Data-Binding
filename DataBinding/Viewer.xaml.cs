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

namespace DataBinding
{
    public partial class Viewer : Window
    {
        private static Model model = new Model { Number = 1234, Text = "ABCDEF" };

        public Viewer()
        {
            InitializeComponent();
            DataContext = model;
        }

        public static Model Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
