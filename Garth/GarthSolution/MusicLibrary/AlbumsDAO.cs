using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class AlbumsDAO
    {
        
        //public List<Album> albums = new List<Album>();
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GarthDB;Integrated Security=SSPI";
        public List<Album> getAllAlbums()
        {
            string term = "";

            List<Album> albumsToReturn = new List<Album>();


            //opening new connection

            SqlConnection connection = new SqlConnection(connString);

            //open connection to server
            connection.Open();

            string searchPhrase = "%" + term + "%";


            //define sql statement
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @term";

            command.Parameters.AddWithValue("@term", searchPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            { 
                while (reader.Read())
                {

                    //pulling album information

                    Album a = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5)

                    };

                    albumsToReturn.Add(a);
                }
            }
            
            //Close Connection to server
            connection.Close();
            return albumsToReturn;
        }

        public List<Album> getSearchedAlbums(string term)
        {
            List<Album> albumsToReturn = new List<Album>();

            SqlConnection connection = new SqlConnection(connString);

            //open connection to server
            connection.Open();

            string searchPhrase = "%" + term + "%";


            //define sql statement
            SqlCommand command = new SqlCommand();

            //sql stament to search for information

            command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @term";

            command.Parameters.AddWithValue("@term", searchPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5)

                    };

                    albumsToReturn.Add(a);
                }
            }

            //Close Connection to server
            connection.Close();
            return albumsToReturn;
        }
        public int addNewAlbum(Album a)
        {
            //Connect to SQL Server
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Define SQL statement to insert new ablum
            SqlCommand command = new SqlCommand("INSERT INTO albums(albumName, albumArtist, albumYear, albumDesc, albumURL) VALUES(@albumname, @albumartist, @albumyear, @albumdesc, @albumurl)", connection);
            command.Parameters.AddWithValue("@albumname", a.AlbumName);
            command.Parameters.AddWithValue("@albumartist", a.AlbumArtist);
            command.Parameters.AddWithValue("@albumyear", a.AlbumYear);
            command.Parameters.AddWithValue("@albumdesc", a.AlbumDesc);
            command.Parameters.AddWithValue("@albumurl", a.AlbumURL);

            int numRows = command.ExecuteNonQuery();
            connection.Close();
            return numRows;
        }
        // Display all songs for this album in separate dataGridView
        public List <Song> getSongsForAlbum(int albumID)
        {
            List<Song> songsToReturn = new List<Song>();

            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM songs WHERE AlbumID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Song s = new Song
                    {
                        AlbumID = reader.GetInt32(0),
                        SongNumber = reader.GetInt32(1),
                        SongName = reader.GetString(2),
                        SongDuration = reader.GetString(3)
                    };
                    songsToReturn.Add(s);
                }
            }
            connection.Close();

            return songsToReturn;
        }

        public List<AlbumFacts> getFactsForAlbum(int albumID)
        {
            List<AlbumFacts> factsToReturn = new List<AlbumFacts>();

            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM AlbumFacts WHERE AlbumID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AlbumFacts s = new AlbumFacts
                    {
                        AlbumID = reader.GetInt32(0),
                        AlbumReleaseDate = reader.GetString(1),
                        AlbumStudio = reader.GetString(2),
                        AlbumDuration = reader.GetString(3),
                        AlbumLabel = reader.GetString(4)
                    };
                    factsToReturn.Add(s);
                }
            }
            connection.Close();

            return factsToReturn;
        }
    }


}

