namespace pryEmilianoFernandezEtapa2
{
    partial class FrmCargaVehiculo
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
            btnAuto = new Button();
            PctVehiculo = new PictureBox();
            btnAvion = new Button();
            btnBarco = new Button();
            label1 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            lblTipo = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            LstMostrar = new ListBox();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(9, 403);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(101, 60);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "Cargar Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += BtnCargar_Click;
            // 
            // PctVehiculo
            // 
            PctVehiculo.BackColor = Color.White;
            PctVehiculo.BorderStyle = BorderStyle.Fixed3D;
            PctVehiculo.Location = new Point(19, 22);
            PctVehiculo.Name = "PctVehiculo";
            PctVehiculo.Size = new Size(341, 260);
            PctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctVehiculo.TabIndex = 1;
            PctVehiculo.TabStop = false;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(249, 403);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(101, 60);
            btnAvion.TabIndex = 2;
            btnAvion.Text = "Cargar Avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(129, 403);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(101, 60);
            btnBarco.TabIndex = 3;
            btnBarco.Text = "Cargar Barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 312);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 351);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 5;
            label2.Text = "Tipo:";
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Location = new Point(178, 302);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(141, 26);
            lblNombre.TabIndex = 6;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            lblTipo.BorderStyle = BorderStyle.Fixed3D;
            lblTipo.Location = new Point(178, 341);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(141, 26);
            lblTipo.TabIndex = 7;
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PctVehiculo);
            groupBox1.Controls.Add(lblTipo);
            groupBox1.Controls.Add(btnAuto);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(btnAvion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnBarco);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 471);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LstMostrar);
            groupBox2.Controls.Add(btnListar);
            groupBox2.Location = new Point(396, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 471);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // LstMostrar
            // 
            LstMostrar.FormattingEnabled = true;
            LstMostrar.ItemHeight = 16;
            LstMostrar.Location = new Point(47, 22);
            LstMostrar.Name = "LstMostrar";
            LstMostrar.Size = new Size(209, 260);
            LstMostrar.TabIndex = 1;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(25, 403);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(254, 59);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // FrmCargaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 477);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCargaVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etapa 4";
            Load += FrmCargaVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAuto;
        private PictureBox PctVehiculo;
        private Button btnAvion;
        private Button btnBarco;
        private Label label1;
        private Label label2;
        private Label lblNombre;
        private Label lblTipo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox LstMostrar;
        private Button btnListar;
    }
}
