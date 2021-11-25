namespace FuncionarioFinal
{
    partial class FUNCIONARIOS
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.btnEDITAR = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEXIBIR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.Label();
            this.txtSALARIO = new System.Windows.Forms.Label();
            this.txtEMPRESA = new System.Windows.Forms.Label();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.txtNOME2 = new System.Windows.Forms.TextBox();
            this.txtEMPRESA2 = new System.Windows.Forms.TextBox();
            this.msbSALARIO2 = new System.Windows.Forms.MaskedTextBox();
            this.dgnDados = new System.Windows.Forms.DataGridView();
            this.cbbCARGO2 = new System.Windows.Forms.ComboBox();
            this.txtCARGO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgnDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnINCLUIR
            // 
            this.btnINCLUIR.Location = new System.Drawing.Point(59, 415);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(75, 23);
            this.btnINCLUIR.TabIndex = 1;
            this.btnINCLUIR.Text = "INCLUIR";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // btnEDITAR
            // 
            this.btnEDITAR.Location = new System.Drawing.Point(181, 415);
            this.btnEDITAR.Name = "btnEDITAR";
            this.btnEDITAR.Size = new System.Drawing.Size(75, 23);
            this.btnEDITAR.TabIndex = 2;
            this.btnEDITAR.Text = "EDITAR";
            this.btnEDITAR.UseVisualStyleBackColor = true;
            this.btnEDITAR.Click += new System.EventHandler(this.btnEDITAR_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(330, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEXIBIR
            // 
            this.btnEXIBIR.Location = new System.Drawing.Point(483, 415);
            this.btnEXIBIR.Name = "btnEXIBIR";
            this.btnEXIBIR.Size = new System.Drawing.Size(75, 23);
            this.btnEXIBIR.TabIndex = 2;
            this.btnEXIBIR.Text = "EXIBIR";
            this.btnEXIBIR.UseVisualStyleBackColor = true;
            this.btnEXIBIR.Click += new System.EventHandler(this.btnEXIBIR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(641, 415);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(90, 23);
            this.btnCONSULTAR.TabIndex = 2;
            this.btnCONSULTAR.Text = "CONSULTAR";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(72, 246);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(21, 13);
            this.txtID.TabIndex = 3;
            this.txtID.Text = "ID:";
            // 
            // txtNOME
            // 
            this.txtNOME.AutoSize = true;
            this.txtNOME.Location = new System.Drawing.Point(72, 296);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(42, 13);
            this.txtNOME.TabIndex = 3;
            this.txtNOME.Text = "NOME:";
            // 
            // txtSALARIO
            // 
            this.txtSALARIO.AutoSize = true;
            this.txtSALARIO.Location = new System.Drawing.Point(72, 343);
            this.txtSALARIO.Name = "txtSALARIO";
            this.txtSALARIO.Size = new System.Drawing.Size(56, 13);
            this.txtSALARIO.TabIndex = 3;
            this.txtSALARIO.Text = "SALARIO:";
            // 
            // txtEMPRESA
            // 
            this.txtEMPRESA.AutoSize = true;
            this.txtEMPRESA.Location = new System.Drawing.Point(72, 385);
            this.txtEMPRESA.Name = "txtEMPRESA";
            this.txtEMPRESA.Size = new System.Drawing.Size(62, 13);
            this.txtEMPRESA.TabIndex = 3;
            this.txtEMPRESA.Text = "EMPRESA:";
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(156, 243);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(100, 20);
            this.txtID2.TabIndex = 4;
            // 
            // txtNOME2
            // 
            this.txtNOME2.Location = new System.Drawing.Point(156, 293);
            this.txtNOME2.Name = "txtNOME2";
            this.txtNOME2.Size = new System.Drawing.Size(100, 20);
            this.txtNOME2.TabIndex = 4;
            // 
            // txtEMPRESA2
            // 
            this.txtEMPRESA2.Location = new System.Drawing.Point(156, 382);
            this.txtEMPRESA2.Name = "txtEMPRESA2";
            this.txtEMPRESA2.Size = new System.Drawing.Size(100, 20);
            this.txtEMPRESA2.TabIndex = 4;
            // 
            // msbSALARIO2
            // 
            this.msbSALARIO2.Location = new System.Drawing.Point(156, 340);
            this.msbSALARIO2.Mask = "$000.000,00";
            this.msbSALARIO2.Name = "msbSALARIO2";
            this.msbSALARIO2.Size = new System.Drawing.Size(100, 20);
            this.msbSALARIO2.TabIndex = 5;
            // 
            // dgnDados
            // 
            this.dgnDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnDados.Location = new System.Drawing.Point(59, 28);
            this.dgnDados.Name = "dgnDados";
            this.dgnDados.Size = new System.Drawing.Size(672, 201);
            this.dgnDados.TabIndex = 6;
            this.dgnDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgnDados_CellContentClick);
            // 
            // cbbCARGO2
            // 
            this.cbbCARGO2.FormattingEnabled = true;
            this.cbbCARGO2.Items.AddRange(new object[] {
            "Programador",
            "Designer",
            "Administração"});
            this.cbbCARGO2.Location = new System.Drawing.Point(569, 296);
            this.cbbCARGO2.Name = "cbbCARGO2";
            this.cbbCARGO2.Size = new System.Drawing.Size(121, 21);
            this.cbbCARGO2.TabIndex = 11;
            // 
            // txtCARGO
            // 
            this.txtCARGO.AutoSize = true;
            this.txtCARGO.Location = new System.Drawing.Point(516, 299);
            this.txtCARGO.Name = "txtCARGO";
            this.txtCARGO.Size = new System.Drawing.Size(48, 13);
            this.txtCARGO.TabIndex = 12;
            this.txtCARGO.Text = "CARGO:";
            // 
            // FUNCIONARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCARGO);
            this.Controls.Add(this.dgnDados);
            this.Controls.Add(this.msbSALARIO2);
            this.Controls.Add(this.txtEMPRESA2);
            this.Controls.Add(this.txtNOME2);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.txtEMPRESA);
            this.Controls.Add(this.txtSALARIO);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnEXIBIR);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEDITAR);
            this.Controls.Add(this.btnINCLUIR);
            this.Controls.Add(this.cbbCARGO2);
            this.Name = "FUNCIONARIOS";
            this.Text = "Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgnDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.Button btnEDITAR;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEXIBIR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtNOME;
        private System.Windows.Forms.Label txtSALARIO;
        private System.Windows.Forms.Label txtEMPRESA;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.TextBox txtNOME2;
        private System.Windows.Forms.TextBox txtEMPRESA2;
        private System.Windows.Forms.MaskedTextBox msbSALARIO2;
        private System.Windows.Forms.DataGridView dgnDados;
        private System.Windows.Forms.ComboBox cbbCARGO2;
        private System.Windows.Forms.Label txtCARGO;
    }
}

