namespace FormBack
{
    partial class FormResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbRace = new ComboBox();
            cbDriver = new ComboBox();
            cbPosition = new ComboBox();
            txtBestLap = new TextBox();
            dgvResults = new DataGridView();
            ColIdResult = new DataGridViewTextBoxColumn();
            ColRaceId = new DataGridViewTextBoxColumn();
            ColDriverId = new DataGridViewTextBoxColumn();
            ColPosition = new DataGridViewTextBoxColumn();
            ColPoints = new DataGridViewTextBoxColumn();
            ColFastLap = new DataGridViewTextBoxColumn();
            btnAgregarResult = new Button();
            txtPoints = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 63);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Race";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Driver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 142);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 177);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Points";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 213);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 4;
            label5.Text = "Fast Test Lap Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 18);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 5;
            label6.Text = "Resultados de la carrera";
            // 
            // cbRace
            // 
            cbRace.FormattingEnabled = true;
            cbRace.Location = new Point(141, 60);
            cbRace.Name = "cbRace";
            cbRace.Size = new Size(121, 23);
            cbRace.TabIndex = 6;
            // 
            // cbDriver
            // 
            cbDriver.FormattingEnabled = true;
            cbDriver.Location = new Point(141, 99);
            cbDriver.Name = "cbDriver";
            cbDriver.Size = new Size(121, 23);
            cbDriver.TabIndex = 7;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(141, 139);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(121, 23);
            cbPosition.TabIndex = 8;
            // 
            // txtBestLap
            // 
            txtBestLap.Location = new Point(141, 213);
            txtBestLap.Name = "txtBestLap";
            txtBestLap.Size = new Size(121, 23);
            txtBestLap.TabIndex = 10;
            txtBestLap.TextChanged += textBox1_TextChanged;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { ColIdResult, ColRaceId, ColDriverId, ColPosition, ColPoints, ColFastLap });
            dgvResults.Location = new Point(22, 264);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(543, 150);
            dgvResults.TabIndex = 12;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // ColIdResult
            // 
            ColIdResult.HeaderText = "IdResult";
            ColIdResult.Name = "ColIdResult";
            ColIdResult.ReadOnly = true;
            ColIdResult.Visible = false;
            // 
            // ColRaceId
            // 
            ColRaceId.HeaderText = "Race";
            ColRaceId.Name = "ColRaceId";
            // 
            // ColDriverId
            // 
            ColDriverId.HeaderText = "Driver";
            ColDriverId.Name = "ColDriverId";
            // 
            // ColPosition
            // 
            ColPosition.HeaderText = "Position";
            ColPosition.Name = "ColPosition";
            // 
            // ColPoints
            // 
            ColPoints.HeaderText = "Points";
            ColPoints.Name = "ColPoints";
            // 
            // ColFastLap
            // 
            ColFastLap.HeaderText = "Fast Lap";
            ColFastLap.Name = "ColFastLap";
            // 
            // btnAgregarResult
            // 
            btnAgregarResult.Location = new Point(301, 213);
            btnAgregarResult.Name = "btnAgregarResult";
            btnAgregarResult.Size = new Size(161, 23);
            btnAgregarResult.TabIndex = 13;
            btnAgregarResult.Text = "Agregar Resultado";
            btnAgregarResult.UseVisualStyleBackColor = true;
            btnAgregarResult.Click += btnAgregarResult_Click;
            // 
            // txtPoints
            // 
            txtPoints.Location = new Point(141, 177);
            txtPoints.Name = "txtPoints";
            txtPoints.Size = new Size(121, 23);
            txtPoints.TabIndex = 14;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(50, 420);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(161, 23);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(280, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 23);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(571, 264);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(161, 23);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refrescar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPoints);
            Controls.Add(btnAgregarResult);
            Controls.Add(dgvResults);
            Controls.Add(txtBestLap);
            Controls.Add(cbPosition);
            Controls.Add(cbDriver);
            Controls.Add(cbRace);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormResult";
            Text = "FormResult";
            Load += FormResult_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbRace;
        private ComboBox cbDriver;
        private ComboBox cbPosition;
        private TextBox txtBestLap;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn ColIdResult;
        private DataGridViewTextBoxColumn ColRaceId;
        private DataGridViewTextBoxColumn ColDriverId;
        private DataGridViewTextBoxColumn ColPosition;
        private DataGridViewTextBoxColumn ColPoints;
        private DataGridViewTextBoxColumn ColFastLap;
        private Button btnAgregarResult;
        private TextBox txtPoints;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnRefresh;
    }
}