using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using projekt9;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace baza_danych
{
    public partial class Form1 : Form
    {
        DatabaseManager databaseManager = new DatabaseManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void wczytaj_dane_Click(object sender, EventArgs e)
        {
            DataTable data = databaseManager.ReadData();
            Form2 form2 = new Form2(data);
            form2.Show();
        }

        private void zapisz_dane_Click(object sender, EventArgs e)
        {
            databaseManager.WriteData(box1.Text, box2.Text, box3.Text, box4.Text, box5.Text, box6.Text, box7.Text, box8.Text, box9.Text, box10.Text, box11.Text, box12.Text, box13.Text, box14.Text, box15.Text);
        }
    }
        public class DatabaseManager
        {
            private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DataTable ReadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Wniosek";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return dataTable;
        }
        public void WriteData(string PoznanDnia, string numerAlbumu, string nazwiskoImie, string semestrRok, string kierunekStopienStudiow, string przedmiot, string punkty, string prowadzacy, string uzasadnienieWniosku, string osobaZKomisji1, string osobaZKomisji2, string osobaZKomisji3, string PoznanDnia2, string dataPodpisStudenta, string podpis)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Wniosek ( Poznan_dnia, numer_albumu, nazwisko_imie, semestr_rok, kierunek_i_stopien_studiow, przedmiot, punkty, prowadz¹cy, uzasadnienie_wniosku, osoba_z_komisji_1, osoba_z_komisji_2, osoba_z_komisji_3, Poznan_dnia2, data_podpis_studenta, podpis) " +
                               "VALUES ( @Poznan_dnia, @numer_albumu, @nazwisko_imie, @semestr_rok, @kierunek_i_stopien_studiow, @przedmiot, @punkty, @prowadz¹cy, @uzasadnienie_wniosku, @osoba_z_komisji_1, @osoba_z_komisji_2, @osoba_z_komisji_3, @Poznan_dnia2, @data_podpis_studenta, @podpis)";

                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Poznan_dnia", PoznanDnia);
                command.Parameters.AddWithValue("@numer_albumu", numerAlbumu);
                command.Parameters.AddWithValue("@nazwisko_imie", nazwiskoImie);
                command.Parameters.AddWithValue("@semestr_rok", semestrRok);
                command.Parameters.AddWithValue("@kierunek_i_stopien_studiow", kierunekStopienStudiow);
                command.Parameters.AddWithValue("@przedmiot", przedmiot);
                command.Parameters.AddWithValue("@punkty", punkty);
                command.Parameters.AddWithValue("@prowadz¹cy", prowadzacy);
                command.Parameters.AddWithValue("@uzasadnienie_wniosku", uzasadnienieWniosku);
                command.Parameters.AddWithValue("@osoba_z_komisji_1", osobaZKomisji1);
                command.Parameters.AddWithValue("@osoba_z_komisji_2", osobaZKomisji2);
                command.Parameters.AddWithValue("@osoba_z_komisji_3", osobaZKomisji3);
                command.Parameters.AddWithValue("@Poznan_dnia2", PoznanDnia2);
                command.Parameters.AddWithValue("@data_podpis_studenta", dataPodpisStudenta);
                command.Parameters.AddWithValue("@podpis", podpis);
                try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted.");
                        //connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }


}
