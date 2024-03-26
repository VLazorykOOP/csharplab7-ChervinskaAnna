using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Enter text");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select to remove");
            }
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open image: " + ex.Message);
                }
            }
        }

        private void saveFileDialogButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Open an image first.");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            saveFileDialog1.Title = "Save Image As";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not save image: " + ex.Message);
                }
            }
        }

        private void convertToGrayScaleButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Open an image first.");
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox.Image);
            Bitmap grayScaleImage = ToGrayScale(originalImage);
            pictureBox.Image = grayScaleImage;
        }

        private Bitmap ToGrayScale(Bitmap originalImage)
        {
            Bitmap grayScaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    int grayScaleValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
                    Color grayScaleColor = Color.FromArgb(grayScaleValue, grayScaleValue, grayScaleValue);
                    grayScaleImage.SetPixel(x, y, grayScaleColor);
                }
            }

            return grayScaleImage;
        }

    }
}
