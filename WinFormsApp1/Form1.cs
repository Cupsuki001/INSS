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
            double   ley, tot , por;
           

            if (MASKEDinssnumero.Text == "" && MASKEDingresomensual.Text == "") 
            {
                MessageBox.Show("Se necesita ingresar los datos necesario");
                MASKEDinssnumero.Focus();
            }
            else if(MASKEDinssnumero.Text != "1234567") 
            {
                MessageBox.Show("EL NUMERO DEL INSS QUE INGRESO ES INCORRECTO");
                MASKEDinssnumero.Text = "";
                MASKEDinssnumero.Focus();
                MASKEDingresomensual.Text = "";
               
            }
            else 
            {
                double ing = Convert.ToDouble(MASKEDingresomensual.Text);

                if (ing >= 6000 && ing <= 500000)
                {

                    if (treeView1.SelectedNode.Text.Equals("INNS LABORAL"))
                    {
                        ley = ing * 0.07;
                        tot = ing - ley;

                        TXBtotal.Text = tot.ToString();
                        TXBarbol.Text = ley.ToString();
                    }
                    else if (treeView1.SelectedNode.Text.Equals("INNS PATRONAL"))
                    {
                        ley = ing * 0.22;
                        tot = ing;

                        TXBtotal.Text = tot.ToString();
                        TXBarbol.Text = ley.ToString();
                    }
                    else if (treeView1.SelectedNode.Text.Equals("IR"))
                    {
                        ley = ing * 0.11;
                        tot = ing - ley;

                        TXBtotal.Text = tot.ToString();
                        TXBarbol.Text = ley.ToString();
                    }
                    else 
                    {
                        MessageBox.Show("INGRESE UNA DEDUCCION PARA CALCULAR");
                        MASKEDinssnumero.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Los ingresos tiene que estar en 6,000 o 500,000");
                    MASKEDingresomensual.Text = "";
                    MASKEDingresomensual.Focus();
                }
            }
           
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            MASKEDingresomensual.Text = "";
            MASKEDinssnumero.Text = "";
            TXBarbol.Text = "";
            TXBtotal.Text = "";

        }
    }
}