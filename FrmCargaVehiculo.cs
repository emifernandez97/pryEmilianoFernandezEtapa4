using System.Collections.Generic;
using System.Windows.Forms;

namespace pryEmilianoFernandezEtapa2
{
    public partial class FrmCargaVehiculo : Form
    {
        clsVehiculo objetoVehiculo;
        public List<String> ListaImagen = new List<String>(); //intacia Lista en memoria una lista publica tipo string

        public FrmCargaVehiculo()
        {
            InitializeComponent();
            objetoVehiculo = new clsVehiculo(); //objeto de la clase
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblTipo.Text = "";

            objetoVehiculo.CrearVehiculoABA(PctVehiculo, pryEmilianoFernandezEtapa4.Properties.Resources.Rayo_Mckuin);

            lblNombre.Text = "Rayo McQueen";
            ListaImagen.Add(lblNombre.Text);//agrega el objeto a la lista
            lblTipo.Text = "Auto";
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblTipo.Text = "";

            objetoVehiculo.CrearVehiculoABA(PctVehiculo, pryEmilianoFernandezEtapa4.Properties.Resources.CAPTAIN_removebg_preview);

            lblNombre.Text = "El Capitán";
            ListaImagen.Add(lblNombre.Text);//agrega el objeto a la lista
            lblTipo.Text = "Barco";
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblTipo.Text = "";

            objetoVehiculo.CrearVehiculoABA(PctVehiculo, pryEmilianoFernandezEtapa4.Properties.Resources.jay_jay_removebg_preview);

            lblNombre.Text = "Jay Jay";
            ListaImagen.Add(lblNombre.Text);//agrega el objeto a la lista
            lblTipo.Text = "Avión";
        }

        private void FrmCargaVehiculo_Load(object sender, EventArgs e)
        {
            // hola mundo :)
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            LstMostrar.Items.Clear();

            foreach (var lblNombre in ListaImagen) 
            {
                LstMostrar.Items.Add(lblNombre);
            }
        }
    }
}
