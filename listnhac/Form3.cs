using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listnhac
{
    public partial class frmEdit : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ModelMediaApp"].ConnectionString;
        private int songId;
        private bool isModified = false;
        public frmEdit(int id = 0)
        {
            InitializeComponent();
            songId = id;
            if (id > 0)
            {
                LoadSongData();
            }
        }

        private void LoadSongData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Songs WHERE SongID = @SongID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SongID", songId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTitle.Text = reader["Title"].ToString();
                                txtAlbum.Text = reader["Artist"].ToString(); // Sử dụng trường Artist làm Album
                                txtFile.Text = reader["FilePath"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading song data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isModified)
            {
                this.Close();
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtFile.Text))
                {
                    MessageBox.Show("Tiêu đề và đường dẫn tệp là bắt buộc!!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!File.Exists(txtFile.Text))
                {
                    MessageBox.Show("Tệp được chỉ định không tồn tại!", "Lỗi tệp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    if (songId > 0)
                    {
                        query = @"UPDATE Songs 
                                SET Title = @Title, 
                                    Artist = @Artist, 
                                    FilePath = @FilePath
                                WHERE SongID = @SongID";
                    }
                    else
                    {
                        query = @"INSERT INTO Songs (Title, Artist, FilePath, UploadDate) 
                                VALUES (@Title, @Artist, @FilePath, GETDATE())";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@Artist", txtAlbum.Text.Trim()); // Sử dụng trường Artist làm Album
                        cmd.Parameters.AddWithValue("@FilePath", txtFile.Text);

                        if (songId > 0)
                        {
                            cmd.Parameters.AddWithValue("@SongID", songId);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving song: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "Do you want to save changes?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.m4a;*.wma|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = openFileDialog.FileName;

                    if (string.IsNullOrEmpty(txtTitle.Text))
                    {
                        txtTitle.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                        isModified = true;
                    }
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}
