using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library.UserControls.Books
{
    public partial class BooksPanel : UserControl,ISaveBooks,IUpdate,IEditBook
    {
        IUpdate update;
        int _id;
        string _who;
        bool searched;
        AddNewBooks newbooks;
        List<Book> books;
        List<Book> searchbooks;
        List<BooksDataPanel> booksdatas;
        public BooksPanel()
        {
            InitializeComponent();
            booksdatas = new List<BooksDataPanel>();
            newbooks = new AddNewBooks(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            books = Task.Run(() => Connector.connections[0].GetBooks()).Result;
            Initialize();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        public BooksPanel(int id, string who,IUpdate update)
        {
            InitializeComponent();
            booksdatas = new List<BooksDataPanel>();
            this.update = update;
            _id = id;
            _who = who;
            searchbox.Enabled = false;
            searchbtn.Enabled = false;
            this.addcinstructorbtn.Click += new System.EventHandler(this.close_Click);
            addcinstructorbtn.Text = "Close";
            switch (who)
            {
                case "instructor":
                    books = Task.Run(() => Connector.connections[0].GetBooksByInstructor(id)).Result;
                    Initialize();
                    break;
                case "material":
                    books = Task.Run(() => Connector.connections[0].GetBooksByMaterial(id)).Result;
                    Initialize();
                    break;
                case "course":
                    books = Task.Run(() => Connector.connections[0].GetBooksByCourse(id)).Result;
                    Initialize();
                    break;
                default:
                    ParentChanged -= this.BooksPanel_ParentChanged;
                    this.Dispose(true);
                    break;
            }
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        async void Initialize()
        {
            searched = false;
            panel1.Controls.Clear();
            booksdatas.Clear();
            panel1.SuspendLayout();
            await Task.Run(() =>
            {
            if (books.Count >= 7)
            {
               
                for (int i = 0; i < books.Count; i++)
                {
                    BooksDataPanel panel = new BooksDataPanel(this);
                    panel.Dock = DockStyle.Top;
                    panel.namelb.Text = books[i].Name;
                    panel.publisher.Text = books[i].Publisher;
                    panel.author.Text = (books[i].Authors.Count != 0) ? books[i].Authors[0] : "UnKnown Author";
                    panel.chapternolb.Text += books[i].ChapterCount;
                    panel.pagenolb.Text += books[i].PageCount;
                    panel.datelb.Text += books[i].Date;
                    panel.Width = 764;
                    booksdatas.Add(panel);
                } 
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    var panel = new BooksDataPanel(this);
                    panel.Dock = DockStyle.Top;
                    panel.namelb.Text = books[i].Name;
                    panel.publisher.Text = books[i].Publisher;
                    panel.author.Text = (books[i].Authors.Count != 0) ? books[i].Authors[0] : "UnKnown Author";
                    panel.chapternolb.Text += books[i].ChapterCount;
                    panel.pagenolb.Text += books[i].PageCount;
                    panel.datelb.Text += books[i].Date;
                    panel.Width = 781;
                    booksdatas.Add(panel);
                }
            }
            });
            panel1.Controls.AddRange(booksdatas.ToArray());
            panel1.ResumeLayout();
        }
        private void Addcinstructorbtn_Click(object sender, EventArgs e)
        {
            newbooks = new AddNewBooks(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newbooks.Size = this.Size;
            this.Controls.Add(newbooks);
            newbooks.BringToFront();
        }
        public void SaveBooks(Book book)
        {
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            books.Add(book);
            Initialize();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            if (searchbox.Text == "" && searched)
            {
                pictureBox1.Visible = true;
                panel1.Enabled = false;
                Initialize();
                pictureBox1.Visible = false;
                panel1.Enabled = true;
            }
            else
            {
                return;
            }
        }
        private void Searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") searchbox.Text = "";
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") return;
            else
            {
                SearchInitialize(searchbox.Text.TrimStart().TrimEnd());
                searchbooks.Clear();
            }
        }
       async void SearchInitialize(string Name)
        {
            searched = true;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            searchbooks = Task.Run(() => Connector.connections[0].SearchBooks(Name)).Result;
            panel1.Controls.Clear();
            booksdatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (searchbooks.Count >= 7)
                {
                    for (int i = 0; i < searchbooks.Count; i++)
                    {
                        BooksDataPanel panel = new BooksDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchbooks[i].Name;
                        panel.publisher.Text = searchbooks[i].Publisher;
                        panel.author.Text = (searchbooks[i].Authors.Count != 0) ? searchbooks[i].Authors[0] : "UnKnown Author";
                        panel.chapternolb.Text += searchbooks[i].ChapterCount;
                        panel.pagenolb.Text += searchbooks[i].PageCount;
                        panel.datelb.Text += searchbooks[i].Date;
                        panel.Width = 764;
                        booksdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < searchbooks.Count; i++)
                    {
                        var panel = new BooksDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchbooks[i].Name;
                        panel.publisher.Text = searchbooks[i].Publisher;
                        panel.author.Text = (searchbooks[i].Authors.Count != 0) ? searchbooks[i].Authors[0] : "UnKnown Author";
                        panel.chapternolb.Text += searchbooks[i].ChapterCount;
                        panel.pagenolb.Text += searchbooks[i].PageCount;
                        panel.datelb.Text += searchbooks[i].Date;
                        panel.Width = 781;
                        booksdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(booksdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        new public void Update()
        {
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            if (_id != 0)
            {
                switch (_who)
                {
                    case "instructor":
                        books = Task.Run(() => Connector.connections[0].GetBooksByInstructor(_id)).Result;
                        Initialize();
                        break;
                    case "material":
                        books = Task.Run(() => Connector.connections[0].GetBooksByMaterial(_id)).Result;
                        Initialize();
                        break;
                    case "course":
                        books = Task.Run(() => Connector.connections[0].GetBooksByCourse(_id)).Result;
                        Initialize();
                        break;
                    default:
                        ParentChanged -= BooksPanel_ParentChanged;
                        this.Dispose(true);
                        break;
                }
            }
            else
            {
                books = Task.Run(() => Connector.connections[0].GetBooks()).Result;
                Initialize();
            }
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        public void EditBook(BooksDataPanel caller)
        {
            var calling = new EditBooks(Connector.connections[0].GetBook(books[panel1.Controls.IndexOf(caller)].Id), this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            calling.Size = this.Size;
            this.Controls.Add(calling);
            calling.BringToFront();
        }
        private void close_Click(object sender, EventArgs e)
        {
            update.Update();
            ParentChanged -= this.BooksPanel_ParentChanged;
            this.Dispose(true);
        }
        public void Open(object caller, string who)
        {
            Book book = Connector.connections[0].GetBook(books[panel1.Controls.IndexOf((BooksDataPanel)caller)].Id);
            if (File.Exists(book.Location))
            {
                System.Diagnostics.Process.Start(@book.Location);
            }
            else
            {
                MessageBox.Show("File Doesn't Exists\n" +
                    @book.Location, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BooksPanel_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != this.Size)
            {
                this.Size = Parent.Size;
            }
        }
        public void _update()
        {
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            books = Task.Run(() => Connector.connections[0].GetBooks()).Result;
            Initialize();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void searchbox_Validated(object sender, EventArgs e)
        {
            if(searchbox.Text == "")searchbox.Text = "Search Here!";
        }
        private void Bookspl_Click(object sender, EventArgs e)
        {
            bookspl.Focus();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
