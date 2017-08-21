namespace EDD_practica_1_interfaz
{
    partial class Respuesta_de_mensajes
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CarneOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inordenOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mensajes Recientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mensajes Antiguos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarneOp,
            this.ipOp,
            this.inordenOp,
            this.postOP,
            this.resultOp});
            this.dataGridView1.Location = new System.Drawing.Point(24, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // CarneOp
            // 
            this.CarneOp.HeaderText = "Carnet";
            this.CarneOp.Name = "CarneOp";
            // 
            // ipOp
            // 
            this.ipOp.HeaderText = "IP";
            this.ipOp.Name = "ipOp";
            // 
            // inordenOp
            // 
            this.inordenOp.HeaderText = "Inorden";
            this.inordenOp.Name = "inordenOp";
            // 
            // postOP
            // 
            this.postOP.HeaderText = "Postorden";
            this.postOP.Name = "postOP";
            // 
            // resultOp
            // 
            this.resultOp.HeaderText = "Resultado";
            this.resultOp.Name = "resultOp";
            // 
            // Respuesta_de_mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 281);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Respuesta_de_mensajes";
            this.Text = "Respuesta_de_mensajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarneOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn inordenOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn postOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultOp;
    }
}