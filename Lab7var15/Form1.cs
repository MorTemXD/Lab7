using System.Windows.Forms;
using CoinCollection.Data;
using CoinCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace CoinCollection
{
    public partial class Form1 : Form
    {
        private readonly CoinCollectionDbContext _dbContext;

        public Form1(CoinCollectionDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void LoadCoins()
        {
            listBox1.DataSource = _dbContext.Coins.ToList();
            listBox1.DisplayMember = "DisplayString";
            listBox1.ValueMember = "Id";
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int id = (int)listBox1.SelectedValue;
                Coin coin = _dbContext.Coins.Find(id);

                if (coin != null)
                {
                    try
                    {
                        _dbContext.Coins.Remove(coin);
                        _dbContext.SaveChanges();
                        MessageBox.Show("Монету успішно видалено.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка видалення монети: {ex.Message}");
                    }
                }
                LoadCoins();
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxYear.Text, out int year))
            {
                Coin coin = new Coin
                {
                    Year = year,
                    Country = textBoxCountry.Text,
                    Nominal = textBoxNominal.Text,
                    Condition = textBoxCondition.Text
                };

                try
                {
                    _dbContext.Coins.Add(coin);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Монета додана успішно.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка додавання монети: {ex.Message}");
                }

                LoadCoins();
                ClearTextboxes();
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int id = (int)listBox1.SelectedValue;
                Coin coin = _dbContext.Coins.Find(id);

                if (coin != null)
                {
                    if (int.TryParse(textBoxYear.Text, out int year))
                    {
                        coin.Year = year;
                    }

                    if (!string.IsNullOrEmpty(textBoxCountry.Text))
                    {
                        coin.Country = textBoxCountry.Text;
                    }

                    if (!string.IsNullOrEmpty(textBoxNominal.Text))
                    {
                        coin.Nominal = textBoxNominal.Text;
                    }

                    if (!string.IsNullOrEmpty(textBoxCondition.Text))
                    {
                        coin.Condition = textBoxCondition.Text;
                    }

                    try
                    {
                        _dbContext.Attach(coin).State = EntityState.Modified;
                        _dbContext.SaveChanges();
                        MessageBox.Show("Монету успішно оновлено.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка оновлення монети: {ex.Message}");
                    }

                    LoadCoins();
                    ClearTextboxes();
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadCoins();
        }

        private void ClearTextboxes()
        {
            textBoxYear.Clear();
            textBoxCountry.Clear();
            textBoxNominal.Clear();
            textBoxCondition.Clear();
        }
    }
}