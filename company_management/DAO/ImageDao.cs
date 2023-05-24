using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AutoMapper;
using company_management.Entity;
using company_management.Utilities;
using Guna.UI2.WinForms;
using System.Linq;
// ReSharper disable All

namespace company_management.DAO
{
    public class ImageDao
    {
        private readonly company_management_Entities _dbContext;
        private readonly IMapper _mapper;
        private readonly string _connString = Properties.Settings.Default.connStr;

        public ImageDao()
        {
            _dbContext = new company_management_Entities();
            _mapper = MapperContainer.GetMapper();
        }
        
        public void ChooseImageToPictureBox(Guna2CirclePictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image Files (*.bmp;*.jpg;*.jpeg,*.png,*.gif)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";

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

        public void SaveUserAvatar(byte[] imageBytes, int userId)
        {
            var user = _dbContext.users.FirstOrDefault(u => u.id == userId);

            if (user != null)
            {
                user.avatar = imageBytes;
                _dbContext.SaveChanges();
                MessageBox.Show("Lưu ảnh thành công!");
            }
            else
            {
                MessageBox.Show("Lưu ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveTeamAvatar(byte[] imageBytes, int idTeam)
        {
            var team = _dbContext.teams.FirstOrDefault(t => t.id == idTeam);

            if (team != null)
            {
                team.avatar = imageBytes;
                _dbContext.SaveChanges();
                MessageBox.Show("Lưu ảnh thành công!");
            }
            else
            {
                MessageBox.Show("Lưu ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
