using System;
using System.IO;
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

namespace L_23._18._2020
{
    class Student
    {
       public string Group { get; set; }
     public string FIO { get; set; }
        public string Age { get; set; }
        public string Photo { get; set; }

        public Student()
        {
            
        }
      

    }



    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string dir;
       
        public MainWindow()
        {
            InitializeComponent();
            dir = Directory.GetCurrentDirectory();//путь по умолчанию

            List<Student> list_student = new List<Student>();
            list_student.Add(new Student() { Group = "СТ 2019 11", FIO = "Jhon Doe", Age = "21",Photo= dir+ @"\1.jpg" });
            list_student.Add(new Student() { Group = "СТ 2019 12", FIO = "Jhon Smith", Age = "18",Photo= dir+ @"\2.jpg"});
  
            this.listBox1.ItemsSource = list_student;

          
        }



    }
}
