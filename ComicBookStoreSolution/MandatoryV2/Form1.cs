using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComicClassLibraryForm;

namespace MandatoryV2
{
    public partial class Form1 : Form
    {
        private ClassBookForm book = new ClassBookForm();
        private bool loggedIn = false; //jelzi hogy be van-e lépve a felhasználó

        public Form1()
        {
            InitializeComponent();
            //legördülő menü
            comboBox1.Items.AddRange(new string[] 
            {
                "Batman",
                "Joker",
                "Cat",
                "TheRiddler",
                "Pinguin"
            });
            comboBox1.SelectedIndex = 0;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Theme", 130);
            listView1.Columns.Add("Stock", 100);
            listView1.Columns.Add("Price (USD)", 100);
            listView1.Columns.Add("Total value (USD)", 150);
            listView1.Columns.Add("Sold", 100);



            SetButtons(false);
        }

        // belépés előtt minden tiltott, belépés után engedélyezett
        private void SetButtons(bool enabled)
        {
            comboBox1.Visible = Visible;
            buttonSell.Visible = Visible;
            buttonStatus.Visible = Visible;
            buttonValue.Visible = Visible;
            buttonStock.Visible = Visible;
            buttonQuit.Visible = Visible;
        }

        //sor hozzáadása a listhez
        private void AddRow(string theme, int stock, int price)
        {
            ListViewItem item = new ListViewItem(theme);
            item.SubItems.Add(stock.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add((stock * price).ToString());
            listView1.Items.Add(item);
        }
        //törlés majd adatok feltöltése
        private void ShowTable()
        {
            listView1.Items.Clear();
            AddRow("Batman", book.BatmanStock, ClassBookForm.BatmanPrice);
            AddRow("Joker", book.JokerStock, ClassBookForm.JokerPrice);
            AddRow("Cat", book.CatStock, ClassBookForm.CatPrice);
            AddRow("TheRiddler", book.TheRiddlerStock, ClassBookForm.TheRiddlerPrice);
            AddRow("Pinguin", book.PinguinStock, ClassBookForm.PinguinPrice);
            
        }

        private void textBoxAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxAdmin.Text == "admin" && textBoxPassword.Text == "1234")
            {
                MessageBox.Show("Login successful!");
                loggedIn = true;
                SetButtons(true);

                // A belépési rész eltűnik
                textBoxAdmin.Visible = false;
                textBoxPassword.Visible = false;
                buttonLogin.Visible = false;
                labelUser.Visible = false;
                labelPassword.Visible = false;
                listView1.Visible = Visible;          
                

                // A többi rész megjelenik
                SetButtons(true);
            }
            
            else
            {
                MessageBox.Show("You are not authorized to access this service");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (book.OneBookSold(comboBox1.Text))
            {
                MessageBox.Show("Sale registered.");
            }
                
            else
            {
                MessageBox.Show("Out of stock.");
            }
                

            ShowTable();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total stock: " + book.TotalStock() + "\nStatus: " + book.GetStockStatus());
        }

        private void buttonValue_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
    }
}