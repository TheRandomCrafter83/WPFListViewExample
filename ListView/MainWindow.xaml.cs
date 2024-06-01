using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ListView
{
    public class MyItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MyItem(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
    public class DataViewModel
    {
        private ObservableCollection<MyItem> items = [];
        public ObservableCollection<MyItem> Items {
            get {
                return items;
            }
            set {
                items = value;
            } 
        }

        public DataViewModel()
        {
            for (int i = 0; i <= 10; i++)
            {
                Items.Add(new MyItem("Name" + i, "Description for Name" + i));
            }
        }
    }


    public partial class MainWindow : Window
    {
        public DataViewModel ViewModel { get;set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new DataViewModel();
            this.DataContext = this;
        }  
    }

    
}