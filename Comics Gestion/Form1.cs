using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace Comics_Gestion
{
    public partial class Form1 : Form
    {
        private List<Comic> listaComics;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComicNegocio negocio = new ComicNegocio();
            listaComics = negocio.Listar();
            dgvComics.DataSource = listaComics;
            cargarImagen(listaComics[0].UrlImagen);
            dgvComics.Columns["UrlImagen"].Visible = false;
            
        }

        public void cargarImagen(string imagen) 
        {
            try 
            {
                pbxImagen.Load(imagen);
            }
            catch(Exception ex) 
            {
                pbxImagen.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void dgvComics_SelectionChanged(object sender, EventArgs e)
        {
            Comic seleccionado = (Comic)dgvComics.CurrentRow.DataBoundItem;
            pbxImagen.Load(seleccionado.UrlImagen);
            
        }
    }
}
