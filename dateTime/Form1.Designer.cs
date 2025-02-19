namespace dateTime
{
    partial class frmDataTime
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
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaCalculo = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblFechaNacimiento = new Label();
            lblCalculo = new Label();
            btnCalcular = new Button();
            label1 = new Label();
            txtboxCurp = new TextBox();
            btnCurp = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(3, 34);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(291, 27);
            dtpFechaNacimiento.TabIndex = 0;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // dtpFechaCalculo
            // 
            dtpFechaCalculo.Enabled = false;
            dtpFechaCalculo.Location = new Point(3, 126);
            dtpFechaCalculo.Name = "dtpFechaCalculo";
            dtpFechaCalculo.Size = new Size(291, 27);
            dtpFechaCalculo.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.3250656F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.67493F));
            tableLayoutPanel1.Controls.Add(dtpFechaCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(lblFechaNacimiento, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCalculo, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFechaNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.9047623F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.0952377F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(726, 154);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(3, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(152, 20);
            lblFechaNacimiento.TabIndex = 3;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            lblFechaNacimiento.Click += label1_Click;
            // 
            // lblCalculo
            // 
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(3, 84);
            lblCalculo.Name = "lblCalculo";
            lblCalculo.Size = new Size(124, 20);
            lblCalculo.TabIndex = 4;
            lblCalculo.Text = "Fecha de Calculo:";
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(469, 126);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(254, 25);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 190);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 3;
            label1.Text = "CURP";
            label1.Click += label1_Click_1;
            // 
            // txtboxCurp
            // 
            txtboxCurp.Location = new Point(20, 213);
            txtboxCurp.Name = "txtboxCurp";
            txtboxCurp.Size = new Size(286, 27);
            txtboxCurp.TabIndex = 4;
            txtboxCurp.TextChanged += txtboxCurp_TextChanged;
            // 
            // btnCurp
            // 
            btnCurp.Enabled = false;
            btnCurp.Location = new Point(25, 259);
            btnCurp.Name = "btnCurp";
            btnCurp.Size = new Size(94, 29);
            btnCurp.TabIndex = 5;
            btnCurp.Text = "CURP";
            btnCurp.UseVisualStyleBackColor = true;
            btnCurp.Click += btnCurp_Click;
            // 
            // frmDataTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCurp);
            Controls.Add(txtboxCurp);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDataTime";
            Text = "frmVarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaCalculo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblFechaNacimiento;
        private Label lblCalculo;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtboxCurp;
        private Button btnCurp;
    }
}
