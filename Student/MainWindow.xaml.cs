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

namespace Student {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public List<string> Studiengaenge { get; set; }
        public List<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Studiengaenge = new List<string>();
        }

        private void btnHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            if(inputStammdaten.Text.ToString().Equals("") == false)
            {
                Studiengaenge.Add(inputStammdaten.Text.ToString());
                cboStudiengang.ItemsSource = Studiengaenge;
                ListBox.ItemsSource = Studiengaenge;
                inputStammdaten.Text = "";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(vname.Text.ToString(), nname.Text.ToString(), Int32.Parse(alter), 
            Students.Add(new Student)
        }
    }

    public class Student {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }
        public bool Bezahlt { get; set; }
        public string Studiengang { get; set; }

        public Student(string vorname, string nachname, int alter, bool bezahlt, string studiengang)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
            Bezahlt = bezahlt;
            Studiengang = studiengang;
        }
    }
}
