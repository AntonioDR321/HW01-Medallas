using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Cambia a Microsoft.Data.SqlClient para .NET 8.0

namespace HW01_Medallas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\INTEC\\Noveno Trimestre\\LAB. Desarollo de Software III\\HW01-Medallas\\HW01-Medallas\\Olimpiadas.mdf\";Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO tblMedallas(Id, Disciplina, Sexo, Nombres, Apellidos, FechaNacimiento, Medallas, Pais, FechaIngreso, Evento, FechaEvento, Nota, Estado) VALUES (@Id, @Disciplina, @Sexo, @Nombres, @Apellidos, @FechaNacimiento, @Medallas, @Pais, @FechaIngreso, @Evento, @FechaEvento, @Nota, @Estado)", connection);
            cmd.Parameters.AddWithValue("@Id",ID.Text);
            cmd.Parameters.AddWithValue("@Disciplina", Disciplina.Text);
            cmd.Parameters.AddWithValue("@Sexo", Sexo.Text);
            cmd.Parameters.AddWithValue("@Nombres", Nombres.Text);
            cmd.Parameters.AddWithValue("@Apellidos", Apellidos.Text);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento.Text);
            cmd.Parameters.AddWithValue("@Medallas", Medallas.Text);
            cmd.Parameters.AddWithValue("@Pais", Pais.Text);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso.Text);
            cmd.Parameters.AddWithValue("@Evento", Evento.Text);
            cmd.Parameters.AddWithValue("@FechaEvento", FechaEvento.Text);
            cmd.Parameters.AddWithValue("@Nota", Nota.Text);
            cmd.Parameters.AddWithValue("@Estado", Estado.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            ID.Text = "";
            Disciplina.Text = "";
            Sexo.Text = "";
            Nombres.Text = "";
            Apellidos.Text = "";
            FechaNacimiento.Text = "";
            Medallas.Text = "";
            Pais.Text = "";
            FechaIngreso.Text = "";
            Evento.Text = "";
            FechaEvento.Text = "";
            Nota.Text = "";
            Estado.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
    }
}
