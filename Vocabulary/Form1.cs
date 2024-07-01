using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=127.0.0.1;Port=3306;Database=vocabularylist;Uid=root;Pwd=1234;";

        public Form1()
        {
            InitializeComponent();
            LoadWords("English");
        }
        ~Form1()
        {
            // Dispose of unmanaged resources
            Dispose(false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //알람
            
            if (!string.IsNullOrWhiteSpace(wordTextBox.Text) && !string.IsNullOrWhiteSpace(contentBox.Text))
            {
                WordEntry entry = new WordEntry
                {
                    Title = wordTextBox.Text,
                    Language = languageComboBox.Text,
                    Content = contentBox.Text
                };
                if (WordExists(entry.Title))
                {
                    MessageBox.Show("단어가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateWord(entry);
                }
                else
                {
                    MessageBox.Show("단어가 추가되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddWord(entry);
                    if(languageComboBox.Text=="English")
                        findLanguageComboBox.SelectedIndex = 0;
                    if(languageComboBox.Text=="Japanese")
                        findLanguageComboBox.SelectedIndex = 1;
                    if(languageComboBox.Text=="Korean")
                        findLanguageComboBox.SelectedIndex = 2;
                    
                    LoadWords(languageComboBox.Text);
                }
                
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (findWordListBox.SelectedIndex >= 0)
            {
                MessageBox.Show("단어가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WordEntry selectedEntry = findWordListBox.SelectedItem as WordEntry;
                RemoveWord(selectedEntry);
                wordTextBox.Clear();
                contentBox.Clear();
                LoadWords();
            }
        }

        private void wordComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (findWordListBox.SelectedItem is WordEntry entry)
            {
                wordTextBox.Text = entry.Title;
                findWordListBox.Text = entry.Content;
            }
            else
            {
                wordTextBox.Clear();
                contentBox.Clear();
            }
        }

        private void AddWord(WordEntry entry)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO voc (Title, Language, Content) VALUES (@Title, @Language, @Content)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", entry.Title);
                cmd.Parameters.AddWithValue("@Language", entry.Language);
                cmd.Parameters.AddWithValue("@Content", entry.Content);
                cmd.ExecuteNonQuery();
            }
            LoadWords();
        }
        private void UpdateWord(WordEntry entry)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE voc SET Content = @Content WHERE Title = @Title AND Language = @Language";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", entry.Title);
                cmd.Parameters.AddWithValue("@Language", entry.Language);
                cmd.Parameters.AddWithValue("@Content", entry.Content);
                cmd.ExecuteNonQuery();
            }
        }
        private void RemoveWord(WordEntry entry)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM voc WHERE Title = @Title;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", entry.Title);
                cmd.ExecuteNonQuery();
            }
        }
        private bool WordExists(string title)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM voc WHERE Title = @Title";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }



        private void findLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            findWordListBox.SelectedIndex = -1;
            LoadWords(findLanguageComboBox.Text);
        }
        
        private void findWordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            languageComboBox.SelectedIndex = findLanguageComboBox.SelectedIndex;
            if (findWordListBox.SelectedItem is WordEntry entry)
            {
                wordTextBox.Text = entry.Title;
                contentBox.Text = entry.Content;
            }
            else
            {
                wordTextBox.Clear();
                contentBox.Clear();
            }
        }

        private void LoadWords()
        {
            LoadWords(null);
        }

        private void LoadWords(string language)
        {
            findWordListBox.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title, Language, Content FROM voc";
                if (!string.IsNullOrEmpty(language))
                {
                    query += " WHERE Language = @Language Order by Title asc";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (!string.IsNullOrEmpty(language))
                {
                    cmd.Parameters.AddWithValue("@Language", language);
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    WordEntry entry = new WordEntry
                    {
                        Title = reader.GetString("Title"),
                        Language = reader.GetString("Language"),
                        Content = reader.GetString("Content")
                    };
                    findWordListBox.Items.Add(entry);
                }
            }
        }


    }
}
