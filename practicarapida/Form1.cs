namespace practicarapida
{
    public partial class frmPractica1 : Form
    {
        public frmPractica1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPractica1_Load(object sender, EventArgs e)
        {

        }


        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            int suma = numero1 + numero2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            int suma = numero1 + numero2;
            string r = suma.ToString();
            txtResultado.Text = r;
            lstLista.Items.Add($"Suma: {numero1} + {numero2} = {suma}");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            int resta = numero1 - numero2;
            string r = resta.ToString();
            txtResultado.Text = r;
            lstLista.Items.Add($"Resta: {numero1} - {numero2} = {resta}");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            int multiplicacion = numero1 * numero2;
            string r = multiplicacion.ToString();
            txtResultado.Text = r;
            lstLista.Items.Add($"Multiplicación: {numero1} * {numero2} = {multiplicacion}");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            int division = numero1 / numero2;
            string r = division.ToString();
            txtResultado.Text = r;
            lstLista.Items.Add($"División: {numero1} / {numero2} = {division}");
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
