using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace company_management.DAO
{
    public class ImageDAO
    {
        private readonly DBConnection dBConnection;
        private string connString = Properties.Settings.Default.connStr;

        public ImageDAO()
        {
            dBConnection = new DBConnection();
        }

        /*public void SaveImageToDatabase(byte[] imageBytes, int userId)
        {
            string sqlStr = string.Format("UPDATE user SET avatar={0} WHERE id={1}", imageBytes, userId);
            dBConnection.executeQuery(sqlStr);            
        }*/

        public void ChooseImageToPictureBox(Guna2CirclePictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            // Cho phép chọn nhiều tệp cùng lúc
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        public void ShowImageInPictureBox(byte[] imageBytes, Guna2CirclePictureBox pictureBox)
        {
            if (imageBytes != null)
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        public void SaveImageToDatabase(byte[] imageBytes, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string query = "UPDATE users SET avatar=@avatar WHERE id=@idUser";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@avatar", imageBytes);
                    command.Parameters.AddWithValue("@idUser", userId);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Lưu ảnh thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lưu ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public byte[] ImageToByte(Guna2CirclePictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
