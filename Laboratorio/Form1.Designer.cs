namespace Biblioteca
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvTablaProbabilidad = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnCalcularTabla = new Button();
            btnSimular = new Button();
            dataGridView1 = new DataGridView();
            cNroFila = new DataGridViewTextBoxColumn();
            cReloj = new DataGridViewTextBoxColumn();
            cEvento = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            cTiempoLlegada = new DataGridViewTextBoxColumn();
            cRNDTipoOperacion = new DataGridViewTextBoxColumn();
            cTipoOperacion = new DataGridViewTextBoxColumn();
            cTiempoTrabajo = new DataGridViewTextBoxColumn();
            cRNDDuracion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cFinFormateoInicial = new DataGridViewTextBoxColumn();
            cFinAtencion = new DataGridViewTextBoxColumn();
            cEstado = new DataGridViewTextBoxColumn();
            cCola = new DataGridViewTextBoxColumn();
            cColaFormateoSinTecnico = new DataGridViewTextBoxColumn();
            cPuesto1 = new DataGridViewTextBoxColumn();
            cPuesto2 = new DataGridViewTextBoxColumn();
            cPuesto3 = new DataGridViewTextBoxColumn();
            cPuesto4 = new DataGridViewTextBoxColumn();
            cPuesto5 = new DataGridViewTextBoxColumn();
            cPuesto6 = new DataGridViewTextBoxColumn();
            cPuesto7 = new DataGridViewTextBoxColumn();
            cPuesto8 = new DataGridViewTextBoxColumn();
            cPuesto9 = new DataGridViewTextBoxColumn();
            cPuesto10 = new DataGridViewTextBoxColumn();
            cContPcAtend = new DataGridViewTextBoxColumn();
            cContPCNoAt = new DataGridViewTextBoxColumn();
            cAcumPermanencia = new DataGridViewTextBoxColumn();
            cPrPermanencia = new DataGridViewTextBoxColumn();
            cPrPcNoAt = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIteraciones = new TextBox();
            txtTiempo = new TextBox();
            txtHasta = new TextBox();
            txtDesde = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtIntervaloB = new TextBox();
            txtIntervaloA = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtRetorno = new TextBox();
            txtPrDeRetiro = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtPromedioPermanencia = new TextBox();
            txtPorcentaje = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            txtTiempoEntreLlegada = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTablaProbabilidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvTablaProbabilidad
            // 
            dgvTablaProbabilidad.AllowUserToAddRows = false;
            dgvTablaProbabilidad.AllowUserToDeleteRows = false;
            dgvTablaProbabilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaProbabilidad.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvTablaProbabilidad.Location = new Point(196, 114);
            dgvTablaProbabilidad.Name = "dgvTablaProbabilidad";
            dgvTablaProbabilidad.RowHeadersVisible = false;
            dgvTablaProbabilidad.RowTemplate.Height = 25;
            dgvTablaProbabilidad.Size = new Size(646, 150);
            dgvTablaProbabilidad.TabIndex = 0;
            dgvTablaProbabilidad.KeyPress += dgvTablaProbabilidad_KeyPress;
            // 
            // Column1
            // 
            Column1.HeaderText = "Operacion";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            Column2.DefaultCellStyle = dataGridViewCellStyle6;
            Column2.HeaderText = "P()";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle7;
            Column3.HeaderText = "P() Ac";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle8;
            Column4.HeaderText = "Inf";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            Column5.DefaultCellStyle = dataGridViewCellStyle9;
            Column5.HeaderText = "Sup";
            Column5.Name = "Column5";
            // 
            // btnCalcularTabla
            // 
            btnCalcularTabla.Location = new Point(906, 208);
            btnCalcularTabla.Name = "btnCalcularTabla";
            btnCalcularTabla.Size = new Size(98, 23);
            btnCalcularTabla.TabIndex = 1;
            btnCalcularTabla.Text = "Calcular Tabla";
            btnCalcularTabla.UseVisualStyleBackColor = true;
            btnCalcularTabla.Click += btnCalcularTabla_Click;
            // 
            // btnSimular
            // 
            btnSimular.Location = new Point(906, 241);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(98, 23);
            btnSimular.TabIndex = 2;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = true;
            btnSimular.Click += Simular_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cNroFila, cReloj, cEvento, Column6, cTiempoLlegada, cRNDTipoOperacion, cTipoOperacion, cTiempoTrabajo, cRNDDuracion, dataGridViewTextBoxColumn1, cFinFormateoInicial, cFinAtencion, cEstado, cCola, cColaFormateoSinTecnico, cPuesto1, cPuesto2, cPuesto3, cPuesto4, cPuesto5, cPuesto6, cPuesto7, cPuesto8, cPuesto9, cPuesto10, cContPcAtend, cContPCNoAt, cAcumPermanencia, cPrPermanencia, cPrPcNoAt });
            dataGridView1.Location = new Point(12, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1029, 399);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cNroFila
            // 
            cNroFila.HeaderText = "Nro Fila";
            cNroFila.Name = "cNroFila";
            cNroFila.Resizable = DataGridViewTriState.False;
            cNroFila.Width = 73;
            // 
            // cReloj
            // 
            cReloj.HeaderText = "Reloj";
            cReloj.Name = "cReloj";
            cReloj.Width = 58;
            // 
            // cEvento
            // 
            cEvento.HeaderText = "Evento";
            cEvento.Name = "cEvento";
            cEvento.Width = 68;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tiempo entre llegada";
            Column6.Name = "Column6";
            Column6.Width = 143;
            // 
            // cTiempoLlegada
            // 
            cTiempoLlegada.HeaderText = "Tiempo Llegada";
            cTiempoLlegada.Name = "cTiempoLlegada";
            cTiempoLlegada.Width = 116;
            // 
            // cRNDTipoOperacion
            // 
            cRNDTipoOperacion.HeaderText = "RND";
            cRNDTipoOperacion.Name = "cRNDTipoOperacion";
            cRNDTipoOperacion.Width = 56;
            // 
            // cTipoOperacion
            // 
            cTipoOperacion.HeaderText = "Tipo Operacion";
            cTipoOperacion.Name = "cTipoOperacion";
            cTipoOperacion.Width = 96;
            // 
            // cTiempoTrabajo
            // 
            cTiempoTrabajo.HeaderText = "Tiempo Operacion";
            cTiempoTrabajo.Name = "cTiempoTrabajo";
            cTiempoTrabajo.Width = 113;
            // 
            // cRNDDuracion
            // 
            cRNDDuracion.HeaderText = "RND";
            cRNDDuracion.Name = "cRNDDuracion";
            cRNDDuracion.Width = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Duracion";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // cFinFormateoInicial
            // 
            cFinFormateoInicial.HeaderText = "Fin Formateo Inicial";
            cFinFormateoInicial.Name = "cFinFormateoInicial";
            cFinFormateoInicial.Width = 136;
            // 
            // cFinAtencion
            // 
            cFinAtencion.HeaderText = "Fin atencion";
            cFinAtencion.Name = "cFinAtencion";
            cFinAtencion.Width = 97;
            // 
            // cEstado
            // 
            cEstado.HeaderText = "Estado";
            cEstado.Name = "cEstado";
            cEstado.Width = 67;
            // 
            // cCola
            // 
            cCola.HeaderText = "Cola";
            cCola.Name = "cCola";
            cCola.Width = 56;
            // 
            // cColaFormateoSinTecnico
            // 
            cColaFormateoSinTecnico.HeaderText = "Cola Formateo Esperando Tecnio";
            cColaFormateoSinTecnico.Name = "cColaFormateoSinTecnico";
            cColaFormateoSinTecnico.Width = 205;
            // 
            // cPuesto1
            // 
            cPuesto1.HeaderText = "Puesto 01";
            cPuesto1.Name = "cPuesto1";
            cPuesto1.Width = 83;
            // 
            // cPuesto2
            // 
            cPuesto2.HeaderText = "Puesto 02";
            cPuesto2.Name = "cPuesto2";
            cPuesto2.Width = 83;
            // 
            // cPuesto3
            // 
            cPuesto3.HeaderText = "Puesto 03";
            cPuesto3.Name = "cPuesto3";
            cPuesto3.Width = 83;
            // 
            // cPuesto4
            // 
            cPuesto4.HeaderText = "Puesto 04";
            cPuesto4.Name = "cPuesto4";
            cPuesto4.Width = 83;
            // 
            // cPuesto5
            // 
            cPuesto5.HeaderText = "Puesto 05";
            cPuesto5.Name = "cPuesto5";
            cPuesto5.Width = 83;
            // 
            // cPuesto6
            // 
            cPuesto6.HeaderText = "Puesto 06";
            cPuesto6.Name = "cPuesto6";
            cPuesto6.Width = 83;
            // 
            // cPuesto7
            // 
            cPuesto7.HeaderText = "Puesto 07";
            cPuesto7.Name = "cPuesto7";
            cPuesto7.Width = 83;
            // 
            // cPuesto8
            // 
            cPuesto8.HeaderText = "Puesto 08";
            cPuesto8.Name = "cPuesto8";
            cPuesto8.Width = 83;
            // 
            // cPuesto9
            // 
            cPuesto9.HeaderText = "Puesto 09";
            cPuesto9.Name = "cPuesto9";
            cPuesto9.Width = 83;
            // 
            // cPuesto10
            // 
            cPuesto10.HeaderText = "Puesto 10";
            cPuesto10.Name = "cPuesto10";
            cPuesto10.Width = 83;
            // 
            // cContPcAtend
            // 
            cContPcAtend.HeaderText = "Contador Cliente atendidas";
            cContPcAtend.Name = "cContPcAtend";
            cContPcAtend.Width = 154;
            // 
            // cContPCNoAt
            // 
            cContPCNoAt.HeaderText = "Contador Cliente no atendidas";
            cContPCNoAt.Name = "cContPCNoAt";
            cContPCNoAt.Width = 171;
            // 
            // cAcumPermanencia
            // 
            cAcumPermanencia.HeaderText = "Acumulador de permanencia de Cliente";
            cAcumPermanencia.Name = "cAcumPermanencia";
            cAcumPermanencia.Width = 220;
            // 
            // cPrPermanencia
            // 
            cPrPermanencia.HeaderText = "Promedio de permanencia";
            cPrPermanencia.Name = "cPrPermanencia";
            cPrPermanencia.Width = 172;
            // 
            // cPrPcNoAt
            // 
            dataGridViewCellStyle10.Format = "P";
            cPrPcNoAt.DefaultCellStyle = dataGridViewCellStyle10;
            cPrPcNoAt.HeaderText = "Porcentaje Cliente no atendidas";
            cPrPcNoAt.Name = "cPrPcNoAt";
            cPrPcNoAt.Width = 177;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Iteraciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 65);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Tiempo";
            // 
            // txtIteraciones
            // 
            txtIteraciones.Location = new Point(116, 24);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(100, 23);
            txtIteraciones.TabIndex = 6;
            txtIteraciones.Text = "10000";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(116, 62);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 7;
            txtTiempo.Text = "10000";
            // 
            // txtHasta
            // 
            txtHasta.Location = new Point(341, 62);
            txtHasta.Name = "txtHasta";
            txtHasta.Size = new Size(100, 23);
            txtHasta.TabIndex = 11;
            txtHasta.Text = "10000";
            // 
            // txtDesde
            // 
            txtDesde.Location = new Point(341, 24);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(100, 23);
            txtDesde.TabIndex = 10;
            txtDesde.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 65);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 9;
            label3.Text = "Tiempo  Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 27);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Tiempo Desde";
            // 
            // txtIntervaloB
            // 
            txtIntervaloB.Location = new Point(541, 62);
            txtIntervaloB.Name = "txtIntervaloB";
            txtIntervaloB.Size = new Size(100, 23);
            txtIntervaloB.TabIndex = 15;
            txtIntervaloB.Text = "5";
            // 
            // txtIntervaloA
            // 
            txtIntervaloA.Location = new Point(541, 27);
            txtIntervaloA.Name = "txtIntervaloA";
            txtIntervaloA.Size = new Size(100, 23);
            txtIntervaloA.TabIndex = 14;
            txtIntervaloA.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 62);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 13;
            label5.Text = "Intervalo B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 30);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 12;
            label6.Text = "Intervalo A";
            // 
            // txtRetorno
            // 
            txtRetorno.Location = new Point(754, 52);
            txtRetorno.Name = "txtRetorno";
            txtRetorno.Size = new Size(88, 23);
            txtRetorno.TabIndex = 19;
            txtRetorno.Text = "30";
            // 
            // txtPrDeRetiro
            // 
            txtPrDeRetiro.Location = new Point(754, 23);
            txtPrDeRetiro.Name = "txtPrDeRetiro";
            txtPrDeRetiro.Size = new Size(88, 23);
            txtPrDeRetiro.TabIndex = 18;
            txtPrDeRetiro.Text = "60";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 55);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 17;
            label7.Text = "Tiempo retorno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 27);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 16;
            label8.Text = "Pr de se Retira";
            // 
            // txtPromedioPermanencia
            // 
            txtPromedioPermanencia.Location = new Point(850, 76);
            txtPromedioPermanencia.Name = "txtPromedioPermanencia";
            txtPromedioPermanencia.Size = new Size(100, 23);
            txtPromedioPermanencia.TabIndex = 21;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(850, 162);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(100, 23);
            txtPorcentaje.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(70, 145);
            label11.Name = "label11";
            label11.Size = new Size(96, 15);
            label11.TabIndex = 24;
            label11.Text = "Cambio de placa";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(71, 170);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 25;
            label12.Text = "Ampliación Memoria\t";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(71, 195);
            label13.Name = "label13";
            label13.Size = new Size(106, 15);
            label13.TabIndex = 26;
            label13.Text = "Formateo de Disco\t";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(71, 220);
            label14.Name = "label14";
            label14.Size = new Size(104, 15);
            label14.TabIndex = 27;
            label14.Text = "Agregar CD o DVD\t";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(70, 245);
            label15.Name = "label15";
            label15.Size = new Size(116, 15);
            label15.TabIndex = 28;
            label15.Text = "Cambio de Memoria\t";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(850, 20);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(166, 50);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "Promedio de Permanencia en laboratorio de un equipo ";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(850, 120);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(166, 41);
            richTextBox2.TabIndex = 30;
            richTextBox2.Text = "Porcentaje de equipos que no pueden ser atendidos";
            // 
            // txtTiempoEntreLlegada
            // 
            txtTiempoEntreLlegada.Location = new Point(754, 76);
            txtTiempoEntreLlegada.Name = "txtTiempoEntreLlegada";
            txtTiempoEntreLlegada.Size = new Size(88, 23);
            txtTiempoEntreLlegada.TabIndex = 32;
            txtTiempoEntreLlegada.Text = "4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(659, 79);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 31;
            label9.Text = "Tiempo LLegada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 681);
            Controls.Add(txtTiempoEntreLlegada);
            Controls.Add(label9);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtPromedioPermanencia);
            Controls.Add(txtRetorno);
            Controls.Add(txtPrDeRetiro);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtIntervaloB);
            Controls.Add(txtIntervaloA);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtHasta);
            Controls.Add(txtDesde);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtTiempo);
            Controls.Add(txtIteraciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSimular);
            Controls.Add(btnCalcularTabla);
            Controls.Add(dgvTablaProbabilidad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaProbabilidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTablaProbabilidad;
        private Button btnCalcularTabla;
        private Button btnSimular;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtIteraciones;
        private TextBox txtTiempo;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Label label3;
        private Label label4;
        private TextBox txtIntervaloB;
        private TextBox txtIntervaloA;
        private Label label5;
        private Label label6;
        private TextBox txtRetorno;
        private TextBox txtPrDeRetiro;
        private Label label7;
        private Label label8;
        private TextBox txtPromedioPermanencia;
        private TextBox txtPorcentaje;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn cNroFila;
        private DataGridViewTextBoxColumn cReloj;
        private DataGridViewTextBoxColumn cEvento;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn cTiempoLlegada;
        private DataGridViewTextBoxColumn cRNDTipoOperacion;
        private DataGridViewTextBoxColumn cTipoOperacion;
        private DataGridViewTextBoxColumn cTiempoTrabajo;
        private DataGridViewTextBoxColumn cRNDDuracion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cFinFormateoInicial;
        private DataGridViewTextBoxColumn cFinAtencion;
        private DataGridViewTextBoxColumn cEstado;
        private DataGridViewTextBoxColumn cCola;
        private DataGridViewTextBoxColumn cColaFormateoSinTecnico;
        private DataGridViewTextBoxColumn cPuesto1;
        private DataGridViewTextBoxColumn cPuesto2;
        private DataGridViewTextBoxColumn cPuesto3;
        private DataGridViewTextBoxColumn cPuesto4;
        private DataGridViewTextBoxColumn cPuesto5;
        private DataGridViewTextBoxColumn cPuesto6;
        private DataGridViewTextBoxColumn cPuesto7;
        private DataGridViewTextBoxColumn cPuesto8;
        private DataGridViewTextBoxColumn cPuesto9;
        private DataGridViewTextBoxColumn cPuesto10;
        private DataGridViewTextBoxColumn cContPcAtend;
        private DataGridViewTextBoxColumn cContPCNoAt;
        private DataGridViewTextBoxColumn cAcumPermanencia;
        private DataGridViewTextBoxColumn cPrPermanencia;
        private DataGridViewTextBoxColumn cPrPcNoAt;
        private TextBox txtTiempoEntreLlegada;
        private Label label9;
    }
}