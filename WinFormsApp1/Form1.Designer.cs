namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("INNS LABORAL");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("INNS PATRONAL");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("IR");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("REDUCCIONES DE LEYES", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MASKEDinssnumero = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MASKEDingresomensual = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXBtotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXBarbol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.LineColor = System.Drawing.Color.Navy;
            this.treeView1.Location = new System.Drawing.Point(35, 21);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "INNS LABORAL";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "INNS PATRONAL";
            treeNode3.Name = "Nodo2";
            treeNode3.Text = "IR";
            treeNode4.Name = "";
            treeNode4.Text = "REDUCCIONES DE LEYES";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(256, 97);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MASKEDinssnumero
            // 
            this.MASKEDinssnumero.Location = new System.Drawing.Point(191, 143);
            this.MASKEDinssnumero.Mask = "9999999";
            this.MASKEDinssnumero.Name = "MASKEDinssnumero";
            this.MASKEDinssnumero.Size = new System.Drawing.Size(100, 23);
            this.MASKEDinssnumero.TabIndex = 1;
            this.MASKEDinssnumero.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero INSS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "INGRESO MENSUAL";
            // 
            // MASKEDingresomensual
            // 
            this.MASKEDingresomensual.Location = new System.Drawing.Point(191, 199);
            this.MASKEDingresomensual.Mask = "999999";
            this.MASKEDingresomensual.Name = "MASKEDingresomensual";
            this.MASKEDingresomensual.Size = new System.Drawing.Size(100, 23);
            this.MASKEDingresomensual.TabIndex = 3;
            this.MASKEDingresomensual.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            // 
            // TXBtotal
            // 
            this.TXBtotal.Location = new System.Drawing.Point(111, 94);
            this.TXBtotal.Name = "TXBtotal";
            this.TXBtotal.Size = new System.Drawing.Size(100, 23);
            this.TXBtotal.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.TXBarbol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXBtotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 140);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADOS :";
            // 
            // TXBarbol
            // 
            this.TXBarbol.Location = new System.Drawing.Point(111, 38);
            this.TXBarbol.Name = "TXBarbol";
            this.TXBarbol.Size = new System.Drawing.Size(100, 23);
            this.TXBarbol.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ninguno";
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNsalir.ForeColor = System.Drawing.Color.White;
            this.BTNsalir.Location = new System.Drawing.Point(557, 199);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 18;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNlimpiar.ForeColor = System.Drawing.Color.White;
            this.BTNlimpiar.Location = new System.Drawing.Point(453, 200);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 17;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = false;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNcalcular.ForeColor = System.Drawing.Color.White;
            this.BTNcalcular.Location = new System.Drawing.Point(340, 200);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 16;
            this.BTNcalcular.Text = "calcular";
            this.BTNcalcular.UseVisualStyleBackColor = false;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(660, 234);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MASKEDingresomensual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MASKEDinssnumero);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private MaskedTextBox MASKEDinssnumero;
        private Label label1;
        private Label label2;
        private MaskedTextBox MASKEDingresomensual;
        private Label label3;
        private Label label4;
        private TextBox TXBtotal;
        private GroupBox groupBox1;
        private TextBox TXBarbol;
        private Label label5;
        private Button BTNsalir;
        private Button BTNlimpiar;
        private Button BTNcalcular;
    }
}