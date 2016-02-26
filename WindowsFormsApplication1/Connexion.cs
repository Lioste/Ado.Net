using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Connexion : Form
    {

        bool active = false;
        private SqlConnection sqlConnect;
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//conexion
        {
            textBox3.Clear();
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "server=(" + textBox1.Text + "); database = " + textBox2.Text + "; Integrated Security = true";
            try
            {
                sqlConnect.Open();
                label4.Text = "Connecté"+ "Serveur : (" + textBox1.Text + ") Base de données : (" + textBox2.Text + ")";
                active = true;
            }
            catch (Exception er)
            {

                MessageBox.Show("Erreur de connexion à la base\n\rImpossible d'ouvrir la base de données : "+textBox2.Text+"\n\rDu serveur "+textBox1.Text, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label4.Text = "Erreur";
                textBox3.Text += er;
                active = false;
            

            }                     
            
            
            

        }

        private void button2_Click(object sender, EventArgs e)//deco
        {
            if (active)
            {
                sqlConnect.Close();
                active = false;
                label4.Text = "Déconnecté";
             
            }
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//quiter
        {
            if(active)
                sqlConnect.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
