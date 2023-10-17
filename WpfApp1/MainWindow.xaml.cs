using System;
using System.Collections.Generic;
using System.Windows;
using WpfApp1.Context;
using WpfApp1.Models;

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
        public DateTime ModifiredDate { get; set; }

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
          ModifiredDate = ModifiredDateDT.SelectedDate ?? DateTime.MinValue;

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

     

            using (var context = new LibraryDBContext())
            {
                var newBook = new Book
                {
                    ID = ID,
                    Name = Name,
                    AuthorId = AuthorId,
                    CategoryId = CategoryId,
                    Comment = Comment,
                    CreatedDate = CreatedDate,
                    ModifiedDate = ModifiredDate,
                    Pages = Pages,
                    PressId = PressId,
                    Quantity = Quantity,
                    ThemesId = ThemesId,
                    YearPress = YearPress
            };
                List<Book> books = new List<Book>();    
                context.Books = books;
                context.SaveChanges();
            }


        }
    }
}
