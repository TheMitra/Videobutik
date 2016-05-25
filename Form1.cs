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

namespace Videobutik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VisaDatabaseKunder();
            VisaDatabaseFilmer();
            VisaDatabaseUthyrt();
        }

        public void VisaDatabaseKunder()
        {
            // @ gör att '\'inte blir ett backslash som förstör koden. 
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'K:\Programmering 2\Videobutik\DatabaseVideobutik.mdf'; Integrated Security = True";
            // SqlConnection måste läggas till i 'using' ( using System.Data.SqlClient; )
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Öppna databasen
            sqlConnection.Open();
            string cmd = "SELECT * FROM Kunder;";
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);


            listViewKunder.Items.Clear();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listViewKunder.Items.Add(sqlDataReader.GetInt32(0).ToString());
                listViewKunder.Items[listViewKunder.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(1));
                listViewKunder.Items[listViewKunder.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(2));
                listViewKunder.Items[listViewKunder.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(3));
                
            }

            sqlConnection.Close();
        }

        public void VisaDatabaseFilmer()
        {
            // @ gör att '\'inte blir ett backslash som förstör koden. 
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'K:\Programmering 2\Videobutik\DatabaseVideobutik.mdf'; Integrated Security = True";
            // SqlConnection måste läggas till i 'using' ( using System.Data.SqlClient; )
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Öppna databasen
            sqlConnection.Open();
            string cmd = "SELECT * FROM Filmer;";
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

            listViewFilmer.Items.Clear();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listViewFilmer.Items.Add(sqlDataReader.GetInt32(0).ToString());
                listViewFilmer.Items[listViewFilmer.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(1));
                listViewFilmer.Items[listViewFilmer.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(2));
                listViewFilmer.Items[listViewFilmer.Items.Count - 1].SubItems.Add(sqlDataReader.GetString(3));
                
            }

            sqlConnection.Close();

        }

        public void VisaDatabaseUthyrt()
        {
            // @ gör att '\'inte blir ett backslash som förstör koden. 
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'K:\Programmering 2\Videobutik\DatabaseVideobutik.mdf'; Integrated Security = True";
            // SqlConnection måste läggas till i 'using' ( using System.Data.SqlClient; )
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Öppna databasen
            sqlConnection.Open();
            string cmd = "SELECT * FROM Filmer, Kunder, Uthyrningar WHERE Uthyrningar.KundID = Kunder.ID AND Uthyrningar.FilmID=Filmer.ID;";
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

            listViewUthyrt.Items.Clear();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listViewUthyrt.Items.Add(sqlDataReader.GetInt32(0).ToString());
                DateTime uthyrningsDatum = (DateTime)sqlDataReader["Datum"];
                listViewUthyrt.Items[listViewUthyrt.Items.Count - 1].SubItems.Add(uthyrningsDatum.ToString());
                listViewUthyrt.Items[listViewUthyrt.Items.Count - 1].SubItems.Add((string)sqlDataReader["Förnamn"] + " " + (string)sqlDataReader["Efternamn"]);
                listViewUthyrt.Items[listViewUthyrt.Items.Count - 1].SubItems.Add((string)sqlDataReader["Title"]);

            }

            sqlConnection.Close();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // @ gör att '\'inte blir ett backslash som förstör koden. 
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'K:\Programmering 2\Videobutik\DatabaseVideobutik.mdf'; Integrated Security = True";
            // SqlConnection måste läggas till i 'using' ( using System.Data.SqlClient; )
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Öppna databasen
            sqlConnection.Open();
            string cmd = "INSERT INTO Kunder(Förnamn, Efternamn, Personnummer) VALUES ('" + textBoxNamn.Text + "', '" + textBoxEfternamn.Text +"', '"+ textBoxPersonnummer.Text + "');";
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

            sqlCommand.ExecuteNonQuery();
            
            sqlConnection.Close();

            VisaDatabaseKunder();
        }

        private void listViewKunder_DoubleClick(object sender, EventArgs e)
        {
            if(listViewKunder.SelectedItems.Count > 0)
            {
                int selected = listViewKunder.SelectedItems[0].Index;

                // @ gör att '\'inte blir ett backslash som förstör koden. 
                string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'K:\Programmering 2\Videobutik\DatabaseVideobutik.mdf'; Integrated Security = True";
                // SqlConnection måste läggas till i 'using' ( using System.Data.SqlClient; )
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                // Öppna databasen
                sqlConnection.Open();
                string cmd = "DELETE FROM Kunder WHERE ID = "+ listViewKunder.Items[selected].Text + "";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                VisaDatabaseKunder();
            }
        }
    }
}
