namespace WinFormsApp41
{
    public partial class Form1 : Form
    {
        Beisbolista beisbolista = new Beisbolista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            beisbolista.nombre = txtNombreJugador.Text;
            beisbolista.numeroJugador = Convert.ToInt32(txtNumeroJugador.Text);
            beisbolista.posicion=cbPosiciones.Text;
            beisbolista.numHits = Convert.ToInt32(txtNumHits.Text); 
            beisbolista.numVecesBat = Convert.ToInt32(txtNumVeces.Text);

           label6.Text = beisbolista.promedioBateo().ToString();


        }
    }
}
