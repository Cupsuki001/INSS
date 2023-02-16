namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXBarbol.Enabled = false;
            TXBtotal.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Text.Equals("INNS LABORAL")) 
            {
                label5.Text = "Inss laboral :";
            }
            else if(treeView1.SelectedNode.Text.Equals("INNS PATRONAL")) 
            {
                label5.Text = "Inss patronal :";
            }
            else if(treeView1.SelectedNode.Text.Equals("IR"))
            {
                label5.Text = "IR :";
            }
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double codg, ing, ley, tot , por; 

            if(MASKEDinssnumero.Text == "" && MASKEDingresomensual.Text == "") 
            {
                MessageBox.Show("Se necesita ingresar los datos necesario");
                MASKEDinssnumero.Focus();
            }
            if(MASKEDinssnumero.Text != "1234567") 
            {
                MessageBox.Show("eL NUMERO QUE INGRESO ES INCORRECTO");
                MASKEDinssnumero.Focus();
            }
           
        }
    }
}