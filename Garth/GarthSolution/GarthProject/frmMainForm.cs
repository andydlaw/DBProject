using MusicLibrary;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GarthProject
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        BindingSource albumBindingSource = new BindingSource();
        BindingSource songBindingSource= new BindingSource();
        AlbumsDAO albumsDAO = new AlbumsDAO();

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadAllMusicData();



        }
        //        string[] images =
        //{

        //                //https://upload.wikimedia.org/wikipedia/en/1/1a/Garth_Brooks-Garth_Brooks_%28album_cover%29.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/5/5e/Garth_Brooks-No_Fences_%28album_cover%29.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/5/5a/Garth_Brooks-Ropin%27_the_Wind_%28album_cover%29.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/5/57/Garth_Brooks_Beyond_the_Season.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/c/cc/Garthchase.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/4/4c/Garth_Brooks_In_Pieces.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/a/a7/Freshhorses.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/e/e2/Sevens.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/thumb/6/62/GarthBrooksintheLifeofChrisGaines.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/d/de/Garth_Brooks_Magic_of_Christmas.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/0/01/Garthscarecrow.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/2/2b/Man_Against_Machine_cover.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/1/1d/Christmastogether.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/9/93/Garth-Gunslinger-Cover.jpg",
        //                //"https://upload.wikimedia.org/wikipedia/en/8/8d/Fun_%28Garth_Brooks_album%29.jpeg"
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth00.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth01.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth02.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth03.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth04.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth05.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth06.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth07.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth08.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth09.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth10.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth11.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth12.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth13.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth14.jpg",
        //            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth15.jpg"
        //        };

        private void loadAllMusicData()
        {
            //Album g1 = new Album
            //{
            //    Id = 1,
            //    AlbumName = "Garth Brooks",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1989,
            //    AlbumDesc = "Garth Brooks is the debut studio album of American country music artist Garth Brooks, released on April 12, 1989, through Capitol Nashville. It was both a critical and chart success, peaking at No. 13 on the Billboard 200 and at No. 2 on the Top Country Albums chart. The album has been certified diamond by the Recording Industry Association of America (RIAA) for shipments over ten million copies.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/1/1a/Garth_Brooks-Garth_Brooks_%28album_cover%29.jpg"

            //};

            //Album g2 = new Album
            //{
            //    Id = 2,
            //    AlbumName = "No Fences",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1990,
            //    AlbumDesc = "No Fences is the second studio album by the American country music artist Garth Brooks. It was released on August 27, 1990, and reached No. 1 on Billboard's Top Country Albums chart. The album also reached No. 3 on the Billboard 200. On the latter chart it stayed in the top 40 for 126 weeks No Fences remains Brooks' best-selling studio album to date with 18 million copies shipped in the US, and is the album that made him an international star. It was his first album issued in Europe (the original European release contained the four singles from his US debut as bonus tracks).",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/5/5e/Garth_Brooks-No_Fences_%28album_cover%29.jpg"
            //};


            //Album g3 = new Album
            //{
            //    Id = 3,
            //    AlbumName = "Ropin' The Wind",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1991,
            //    AlbumDesc = "Ropin' the Wind is the third studio album by the American country music artist Garth Brooks. It was released on September 2, 1991, and was his first studio album to debut at No. 1 the Billboard 200 chart and the Top Country Albums chart. It was the first album by a country singer to top both of these charts since Kenny Rogers just over a decade earlier. It had four runs at No. 1 between September 28, 1991, and April 3, 1992, spending a combined 18 weeks at the top, eventually being certified 14× Platinum by the RIAA in 1998. In the UK, it reached the Top 50 pop albums list and went to No. 1 for several months on the country charts. It is the last studio album on Capitol Records Nashville until the 1995 album Fresh Horses.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/5/5a/Garth_Brooks-Ropin%27_the_Wind_%28album_cover%29.jpg"
            //};


            //Album g4 = new Album
            //{
            //    Id = 4,
            //    AlbumName = "Beyond The Season",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1992,
            //    AlbumDesc = "Beyond the Season is the first Christmas album by American country music artist Garth Brooks. It was released on August 25, 1992, however it was the first album on Liberty Records, and peaked at number 2 on both of Billboard magazine's Billboard 200 and Top Country Albums sales charts that year. Beyond the Season was also the best-selling Christmas/holiday album of 1992 in the United States with sales of 1,542,000 copies for the year according to Nielsen SoundScan. As of November 2014, the album has cumulative sales of 2,650,000 copies in the U.S. and is the seventeenth best-selling Christmas/holiday album in the U.S. during the entire SoundScan era (March 1991 – present).",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/5/57/Garth_Brooks_Beyond_the_Season.jpg"
            //};


            //Album g5 = new Album
            //{
            //    Id = 5,
            //    AlbumName = "The Chase",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1992,
            //    AlbumDesc = "The Chase is the fourth studio album by American country music artist Garth Brooks. It was released on September 14, 1992, through Liberty Records and sold 403,000 copies in its first week, The Chase debuted at number one on the Billboard 200 chart and Top Country Albums chart and has been certified diamond by the RIAA. It was also successful internationally, reaching number one on the UK country albums chart and remained in the top ten for many months.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/c/cc/Garthchase.jpg"
            //};


            //Album g6 = new Album
            //{
            //    Id = 6,
            //    AlbumName = "In Pieces",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1993,
            //    AlbumDesc = "In Pieces is the fifth studio album by American country music artist Garth Brooks. It was released on August 31, 1993, by Liberty Records. It debuted at #1 on the Billboard 200 and the Top Country Albums chart.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/4/4c/Garth_Brooks_In_Pieces.jpg"
            //};


            //Album g7 = new Album
            //{
            //    Id = 7,
            //    AlbumName = "Fresh Horses",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1995,
            //    AlbumDesc = "Fresh Horses is the sixth studio album by American country music artist Garth Brooks. It was released on November 21, 1995. Fresh Horses peaked at number two on the Billboard 200 chart, and number one on the Top Country Albums chart.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/a/a7/Freshhorses.jpg"
            //};


            //Album g8 = new Album
            //{
            //    Id = 8,
            //    AlbumName = "Sevens",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1997,
            //    AlbumDesc = "Sevens is the seventh studio album by American country music artist Garth Brooks. It was released on November 25, 1997, and debuted at #1 on the Billboard 200, and on the Top Country Albums chart. To date, it is Brooks' last studio album to be certified diamond by the RIAA. The album also topped the Country album charts in Britain for several months and crossed over into the mainstream pop charts. His duet with Trisha Yearwood, In Another's Eyes, won the Grammy Award for Best Country Collaboration with Vocals at the Grammy Awards of 1998. Sevens was nominated for the Best Country Album Grammy the following year.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/e/e2/Sevens.jpg"
            //};


            //Album g9 = new Album
            //{
            //    Id = 9,
            //    AlbumName = "Garth Brooks In... The Life Of Chris Gaines",
            //    AlbumArtist = "Chris Gaines",
            //    AlbumYear = 1999,
            //    AlbumDesc = "Garth Brooks in...the Life of Chris Gaines, also titled Greatest Hits, is an album by American country music artist Garth Brooks, in which Brooks assumes the fictitious persona of Australian rock artist Chris Gaines. Originally, this album was intended to be the soundtrack for a movie called The Lamb that would star Brooks as a rock star recalling the different periods of his life. This album was purposely released a year in advance from the scheduled film release date to pique interest in Brooks performing rock instead of country. The Lamb, however, was never filmed due to financial and management problems.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/thumb/6/62/GarthBrooksintheLifeofChrisGaines.jpg/318px-GarthBrooksintheLifeofChrisGaines.jpg"
            //};


            //Album g10 = new Album
            //{
            //    Id = 10,
            //    AlbumName = "Garth Brooks & The Magic Of Christmas",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 1999,
            //    AlbumDesc = "Garth Brooks & the Magic of Christmas is the second holiday album by American country music artist Garth Brooks. It was released on November 23, 1999, peaked at number seven on the Billboard 200 chart, and number one on the Top Country Albums chart. Two years after this album's release, Brooks released a reissue of this album, Songs from Call Me Claus, which contained most of the songs from this release. The only tracks which were not carried over were White Christmas, God Rest Ye Merry, Gentlemen, and Go Tell It on the Mountain (all of which are remixed versions of the same songs from his first Christmas album, Beyond the Season).",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/d/de/Garth_Brooks_Magic_of_Christmas.jpg"
            //};


            //Album g11 = new Album
            //{
            //    Id = 11,
            //    AlbumName = "Scarecrow",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 2001,
            //    AlbumDesc = "Scarecrow is the eighth studio album by American country music artist Garth Brooks. It was released on November 13, 2001, and debuted at #1 on the Billboard 200 chart, and the Top Country Albums chart. It has been certified 5× platinum RIAA and was named Best Selling Album at the 2002 Canadian Country Music Association Awards.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/0/01/Garthscarecrow.jpg"
            //};


            //Album g12 = new Album
            //{
            //    Id = 12,
            //    AlbumName = "Man Against Machine",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 2014,
            //    AlbumDesc = "Man Against Machine is the ninth studio album by American country music artist Garth Brooks. It was released on November 11, 2014 by RCA Records Nashville and Pearl Records. Brooks confirmed the album in July 2014 while announcing his comeback world tour. Brooks' first new studio album since Scarecrow, which was released in 2001, it was his first album released digitally, exclusively to his online music store, GhostTunes. The album's lead single, People Loving People, was released on September 3, 2014.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/2/2b/Man_Against_Machine_cover.jpg"
            //};


            //Album g13 = new Album
            //{
            //    Id = 13,
            //    AlbumName = "Christmas Together",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 2016,
            //    AlbumDesc = "Christmas Together is a Christmas duets studio album by American country music artists Garth Brooks and Trisha Yearwood, released by Pearl Records on November 11, 2016.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/1/1d/Christmastogether.jpg"
            //};


            //Album g14 = new Album
            //{
            //    Id = 14,
            //    AlbumName = "Gunslinger",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 2016,
            //    AlbumDesc = "Gunslinger is the tenth studio album by American country music artist Garth Brooks, released on November 25, 2016 by Pearl Records. The album's lead single, Baby, Let's Lay Down and Dance, was released on October 13, 2016.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/9/93/Garth-Gunslinger-Cover.jpg"
            //};


            //Album g15 = new Album
            //{
            //    Id = 15,
            //    AlbumName = "Fun",
            //    AlbumArtist = "Garth Brooks",
            //    AlbumYear = 2020,
            //    AlbumDesc = "Fun is the eleventh studio album by American country music artist Garth Brooks. Announced in 2018, the album experienced production delays and its release was postponed due to the COVID-19 pandemic, eventually culminating in a release date of November 20, 2020 The lead single, All Day Long, was released on June 19, 2018, followed by a second single, Stronger Than Me, on November 19, 2018. The third single, Dive Bar, a duet featuring Blake Shelton, was released on June 18, 2019. The fourth single, Shallow, a duet featuring Trisha Yearwood, was released on December 1, 2020. The fifth single, That's What Cowboys Do was released on June 29, 2021. A selection of seven tracks were available for streaming via Amazon Music prior to the album's release.",
            //    AlbumURL = "https://upload.wikimedia.org/wikipedia/en/8/8d/Fun_%28Garth_Brooks_album%29.jpeg"
            //};


            //albumsDAO.albums.Add(g1);
            //albumsDAO.albums.Add(g2);
            //albumsDAO.albums.Add(g3);
            //albumsDAO.albums.Add(g4);
            //albumsDAO.albums.Add(g5);
            //albumsDAO.albums.Add(g6);
            //albumsDAO.albums.Add(g7);
            //albumsDAO.albums.Add(g8);
            //albumsDAO.albums.Add(g9);
            //albumsDAO.albums.Add(g10);
            //albumsDAO.albums.Add(g11);
            //albumsDAO.albums.Add(g12);
            //albumsDAO.albums.Add(g13);
            //albumsDAO.albums.Add(g14);
            //albumsDAO.albums.Add(g15);

            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect list of albums to DataGridViewControl
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();
            dgvAlbums.DataSource = albumBindingSource;
        }

        private void gotoSplashScreen()
        {
            Form splashScreen = new frmSplashScreen();
            this.Hide();
            splashScreen.ShowDialog();
        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            gotoSplashScreen();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
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

        private void splashScreenMenuItem_Click(object sender, EventArgs e)
        {
            gotoSplashScreen();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void loadDataMenuItem_Click(object sender, EventArgs e)
        {
            loadAllMusicData();
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

        private void btnAlbumSearch_Click(object sender, EventArgs e)
        {
            if (txtAlbumSearch.Text == "")
            {
                MessageBox.Show("Cannot have and empty search field.", "EMPTY SEARCH FIELD", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAlbumSearch.Focus();
            }
            else
            {
                loadSearchMusicData();

            }

        }
        private void loadSearchMusicData()
        {

            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect list of albums to DataGridViewControl
            albumBindingSource.DataSource = albumsDAO.getSearchedAlbums(txtAlbumSearch.Text);
            dgvAlbums.DataSource = albumBindingSource;
            pbCurrentAlbum.Image = null;

        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rowClicked = dgv.CurrentCell.RowIndex;
            string imageURL = dgv.Rows[rowClicked].Cells[0].Value.ToString();

            //pbCurrentAlbum.Load(imageURL);
            int p = Convert.ToInt32(imageURL);
            pbCurrentAlbum.Image = Image.FromFile(AlbumImages.images[p]);

            AlbumsDAO albumsDAO = new AlbumsDAO();

            songBindingSource.DataSource = albumsDAO.getSongsForAlbum((int)dgvAlbums.Rows[rowClicked].Cells[0].Value);
            dgvSongs.DataSource = songBindingSource;
}

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                addAlbumToAlbumsTable();
            };


        }
        private void addAlbumToAlbumsTable()
        {
            Album album = new Album
            {
                AlbumName = txtAlbumName.Text,
                AlbumArtist = txtAlbumArtist.Text,
                AlbumDesc = txtAlbumDesc.Text,
                AlbumURL = txtAlbumURL.Text,
                AlbumYear = Int32.Parse(txtAlbumYear.Text)
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addNewAlbum(album);
            MessageBox.Show("Number of New Albums Inserted " + result.ToString(), "NEW RECORD INSERTED?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //calling validator class

            Validator validator = new Validator();


            //Checking for blanks
            errorMessage += validator.IsPresent(txtAlbumYear.Text,
            txtAlbumYear.Tag.ToString());
            errorMessage += validator.IsPresent(txtAlbumArtist.Text,
            txtAlbumArtist.Tag.ToString());
            errorMessage += validator.IsPresent(txtAlbumDesc.Text,
            txtAlbumDesc.Tag.ToString());
            errorMessage += validator.IsPresent(txtAlbumName.Text,
            txtAlbumName.Tag.ToString());
            errorMessage += validator.IsPresent(txtAlbumURL.Text,
            txtAlbumURL.Tag.ToString());

            //checking for range starting from birth year.

            errorMessage += validator.IsWithinRange(txtAlbumYear.Text,
            txtAlbumYear.Tag.ToString(),
            1962, 2062);




            errorMessage += validator.IsInt32(txtAlbumYear.Text, txtAlbumYear.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        

        private void clearOutAddNewRecordFields()
        {
            txtAlbumName.Text = "";
            txtAlbumArtist.Text = "";
            txtAlbumDesc.Text = "";
            txtAlbumURL.Text = "";
            txtAlbumYear.Text = "";
        }
    }
}
