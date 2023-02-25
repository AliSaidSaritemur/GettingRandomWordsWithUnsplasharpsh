using System.Net;
using Unsplasharp;

namespace UnsplasharpForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnChangeImg_Click(object sender, EventArgs e)
        {
            UnsplasharpClient client = new UnsplasharpClient("Your API Key");
            string wordToBeImg = txtWordToBeSearch.Text.ToString().Trim();
            var photo = await client.GetRandomPhoto(count:1,query: wordToBeImg);
            Image image = ConverterURLtoImage(photo.First().Urls.Regular);
            pbWordImg.Image = image;    
        }
        public Image ConverterURLtoImage(string url)
        {
            WebClient wc = new();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}