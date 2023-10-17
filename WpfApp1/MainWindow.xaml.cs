using Microsoft.EntityFrameworkCore;
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
using WpfApp1.Models;
using WpfApp1.Context;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///       

public partial class MainWindow : Window
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Pages { get; set; }
        public DateTime YearPress { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ThemesId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PressId { get; set; }

        public string Comment { get; set; }
        public int Quantity { get; set; }

 

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Name=NameBox.Text;

            if (int.TryParse(PagesBox.Text, out int pagesValue))
            {
                Pages = pagesValue;
            }
            if (int.TryParse(IDBox.Text, out int IDDD))
            {
                ID = IDDD;
            }


            YearPress = YearPressDT.SelectedDate ?? DateTime.MinValue;
           CreatedDate = CreatedDateDT.SelectedDate ?? DateTime.MinValue;

            if (int.TryParse(ThemesIDBox.Text, out int TT))
            {
                ThemesId = TT;
            }
            if (int.TryParse(AuthorIDBox.Text, out int AA))
            {
                AuthorId = AA;
            }
            if (int.TryParse(CategoryIDBox.Text, out int CC))
            {
                CategoryId = CC;
            }
            if (int.TryParse(PressIDBox.Text, out int PP))
            {
                PressId = PP;
            }
            if (int.TryParse(QuantityBox.Text, out int QQ))
            {
                Quantity = QQ;
            }
            Comment = CommentBox.Text;


      

            Book newBook = new Book(ID, Name, Pages, YearPress, ThemesId, CategoryId, AuthorId, PressId, Comment, Quantity);
            AddBookCS.AddBookFC(newBook);
           
        }
    }
}
