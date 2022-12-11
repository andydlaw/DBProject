using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarthProject
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        //Global Constant
        const int NUMELEMENTS = 20;

        //string[] images =
        //{

        //        //https://upload.wikimedia.org/wikipedia/en/1/1a/Garth_Brooks-Garth_Brooks_%28album_cover%29.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/5/5e/Garth_Brooks-No_Fences_%28album_cover%29.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/5/5a/Garth_Brooks-Ropin%27_the_Wind_%28album_cover%29.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/5/57/Garth_Brooks_Beyond_the_Season.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/c/cc/Garthchase.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/4/4c/Garth_Brooks_In_Pieces.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/a/a7/Freshhorses.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/e/e2/Sevens.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/thumb/6/62/GarthBrooksintheLifeofChrisGaines.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/d/de/Garth_Brooks_Magic_of_Christmas.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/0/01/Garthscarecrow.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/2/2b/Man_Against_Machine_cover.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/1/1d/Christmastogether.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/9/93/Garth-Gunslinger-Cover.jpg",
        //        //"https://upload.wikimedia.org/wikipedia/en/8/8d/Fun_%28Garth_Brooks_album%29.jpeg"
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth00.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth01.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth02.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth03.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth04.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth05.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth06.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth07.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth08.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth09.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth10.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth11.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth12.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth13.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth14.jpg",
        //    "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth15.jpg"
        //};

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
        private void exitProgramOrNot()
        {
            //Exit Button Code
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            gotoMainPage();
        }
        private void gotoMainPage()
        {
            Form mainForm = new frmMainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(0, 16);

            //Loading Images to the splash Screen

            pb00.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb01.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb02.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb03.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb04.Image = Image.FromFile(AlbumImages.images[rInt]);

            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb05.Image = Image.FromFile(AlbumImages.images[rInt]);
            //pb06.Image = Image.FromFile(AlbumImages.images[rInt]);

            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb07.Image = Image.FromFile(AlbumImages.images[rInt]);
            //pb08.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb09.Image = Image.FromFile(AlbumImages.images[rInt]);
            //pb10.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }
            pb11.Image = Image.FromFile(AlbumImages.images[rInt]);
            //pb12.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }

            pb13.Image = Image.FromFile(AlbumImages.images[rInt]);
            //pb14.Image = Image.FromFile(AlbumImages.images[rInt]);
            if (rInt == 16) { rInt = rInt - 15; } else { rInt = rInt + 1; }

            pb15.Image = Image.FromFile(AlbumImages.images[rInt]);
            
        }

        private void mainPageMenuItem_Click(object sender, EventArgs e)
        {
            gotoMainPage();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the help buttonn for more information.",
            "HELP",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            0,
            "https://www.google.com/search?q=garth+brooks");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
    }
}
