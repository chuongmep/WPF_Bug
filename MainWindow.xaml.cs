using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Learning_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanging
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            
        }

        private string _name = "Chung";

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChange(nameof(FullName));
            } 
        }

        private string _fullName;

        public string FullName
        {
            get
            {
                return "Mr"+_name;
            } 
            set { _fullName = value; }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public void OnPropertyChange(string propName)
        {
            if (PropertyChanging != null) PropertyChanging.Invoke(this, new PropertyChangingEventArgs(nameof(propName)));
        }

        private string _value; 

        public string MyProperty
        {
            get { return _value; }
            set { _value = value; }
        }


    }
}
