using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projekt9
{
    public partial class Form2 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Form2()
        {
            InitializeComponent();
            ReadData();
            
        }


        public void ReadData()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("nazwiskoImie", "Nazwisko i Imię");
            dataGridView1.Columns.Add("semestrRok", "Semestr i Rok");
            dataGridView1.Columns.Add("kierunekStopienStudiow", "Kierunek i Stopień Studiów");
            dataGridView1.Columns.Add("PoznanDnia", "Poznań Dnia");
            dataGridView1.Columns.Add("przedmiot", "Przedmiot");
            dataGridView1.Columns.Add("punkty", "Punkty");
            dataGridView1.Columns.Add("prowadzacy", "Prowadzący");
            dataGridView1.Columns.Add("uzasadnienieWniosku", "Uzasadnienie Wniosku");
            dataGridView1.Columns.Add("dataPodpisStudenta", "Data Podpisu Studenta");
            dataGridView1.Columns.Add("osobaZKomisji1", "Osoba z Komisji 1");
            dataGridView1.Columns.Add("osobaZKomisji2", "Osoba z Komisji 2");
            dataGridView1.Columns.Add("osobaZKomisji3", "Osoba z Komisji 3");
            dataGridView1.Columns.Add("PoznanDnia2", "Poznań Dnia 2");
            dataGridView1.Columns.Add("podpis", "Podpis");
            dataGridView1.Columns.Add("numerAlbumu", "Numer Albumu");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Table1";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nazwiskoImie = reader.GetString(1);
                        string semestrRok = reader.GetString(2);
                        string kierunekStopienStudiow = reader.GetString(3);
                        string PoznanDnia = reader.GetString(4);
                        string przedmiot = reader.GetString(5);
                        string punkty = reader.GetString(6);
                        string prowadzacy = reader.GetString(7);
                        string uzasadnienieWniosku = reader.GetString(8);
                        string dataPodpisStudenta = reader.GetString(9);
                        string osobaZKomisji1 = reader.GetString(10);
                        string osobaZKomisji2 = reader.GetString(11);
                        string osobaZKomisji3 = reader.GetString(12);
                        string PoznanDnia2 = reader.GetString(13);
                        string podpis = reader.GetString(14);
                        string numerAlbumu = reader.GetString(15);

                        DataGridViewRow emptyRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        emptyRow.CreateCells(dataGridView1);
                        DataGridViewRow row = (DataGridViewRow)emptyRow.Clone();
                        row.CreateCells(dataGridView1);

                        row.Cells[0].Value = id;
                        row.Cells[1].Value = nazwiskoImie;
                        row.Cells[2].Value = semestrRok;
                        row.Cells[3].Value = kierunekStopienStudiow;
                        row.Cells[4].Value = PoznanDnia;
                        row.Cells[5].Value = przedmiot;
                        row.Cells[6].Value = punkty;
                        row.Cells[7].Value = prowadzacy;
                        row.Cells[8].Value = uzasadnienieWniosku;
                        row.Cells[9].Value = dataPodpisStudenta;
                        row.Cells[10].Value = osobaZKomisji1;
                        row.Cells[11].Value = osobaZKomisji2;
                        row.Cells[12].Value = osobaZKomisji3;
                        row.Cells[13].Value = PoznanDnia2;
                        row.Cells[14].Value = podpis;
                        row.Cells[15].Value = numerAlbumu;

                        dataGridView1.Rows.Add(row);
                        dataGridView1.Refresh();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
