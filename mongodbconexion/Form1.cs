using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mongodbconexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MongoClient cliente = new MongoClient("mongodb://127.0.0.1:27017");
            var database = cliente.GetDatabase("prueba");
            var dbc = database.GetCollection<producto>("producto");

            var objeto = new producto() { name = "Josue", edad = 34 };
            dbc.InsertOne(objeto);
            var lista = dbc.Find(d => true).ToList();
         }
    }
}
