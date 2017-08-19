namespace EDD_practica_1_interfaz
{
    partial class Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.DataGriv = new System.Windows.Forms.DataGridView();
            this.nodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar JSON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGriv
            // 
            this.DataGriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodo,
            this.ip,
            this.mascara,
            this.estado});
            this.DataGriv.Location = new System.Drawing.Point(12, 76);
            this.DataGriv.Name = "DataGriv";
            this.DataGriv.Size = new System.Drawing.Size(443, 308);
            this.DataGriv.TabIndex = 2;
            // 
            // nodo
            // 
            this.nodo.HeaderText = "Nodo";
            this.nodo.Name = "nodo";
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            // 
            // mascara
            // 
            this.mascara.HeaderText = "Mascara";
            this.mascara.Name = "mascara";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 409);
            this.Controls.Add(this.DataGriv);
            this.Controls.Add(this.button1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DataGriv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGriv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascara;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}