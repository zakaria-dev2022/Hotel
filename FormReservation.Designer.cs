namespace Hotel
{
    partial class FormReservation
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnj = new System.Windows.Forms.NumericUpDown();
            this.txtdr = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.txtid_chambre = new System.Windows.Forms.TextBox();
            this.txtid_client = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtnj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label11.Location = new System.Drawing.Point(50, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 26);
            this.label11.TabIndex = 122;
            this.label11.Text = "Nombre Jour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label10.Location = new System.Drawing.Point(50, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 26);
            this.label10.TabIndex = 121;
            this.label10.Text = "Message";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label9.Location = new System.Drawing.Point(50, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 26);
            this.label9.TabIndex = 120;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(55, 263);
            this.txtm.Multiline = true;
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(252, 77);
            this.txtm.TabIndex = 119;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(114, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 26);
            this.txtid.TabIndex = 118;
            this.txtid.Visible = false;
            // 
            // txtnj
            // 
            this.txtnj.Location = new System.Drawing.Point(55, 85);
            this.txtnj.Name = "txtnj";
            this.txtnj.Size = new System.Drawing.Size(244, 26);
            this.txtnj.TabIndex = 123;
            this.txtnj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdr
            // 
            this.txtdr.Location = new System.Drawing.Point(55, 167);
            this.txtdr.Name = "txtdr";
            this.txtdr.Size = new System.Drawing.Size(244, 26);
            this.txtdr.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(50, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 125;
            this.label1.Text = "Date Reservation";
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(416, 77);
            this.txte.Name = "txte";
            this.txte.ReadOnly = true;
            this.txte.Size = new System.Drawing.Size(274, 26);
            this.txte.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(423, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 127;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(423, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 129;
            this.label3.Text = "Type Chambre";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(416, 150);
            this.txttc.Name = "txttc";
            this.txttc.ReadOnly = true;
            this.txttc.Size = new System.Drawing.Size(274, 26);
            this.txttc.TabIndex = 128;
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.Color.White;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(72, 390);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(974, 210);
            this.tableau.TabIndex = 130;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            // 
            // supprimer
            // 
            this.supprimer.Enabled = false;
            this.supprimer.Location = new System.Drawing.Point(852, 148);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(141, 36);
            this.supprimer.TabIndex = 132;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Enabled = false;
            this.modifier.Location = new System.Drawing.Point(852, 215);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(141, 36);
            this.modifier.TabIndex = 131;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // txtid_chambre
            // 
            this.txtid_chambre.Location = new System.Drawing.Point(528, 150);
            this.txtid_chambre.Name = "txtid_chambre";
            this.txtid_chambre.Size = new System.Drawing.Size(76, 26);
            this.txtid_chambre.TabIndex = 134;
            this.txtid_chambre.Visible = false;
            // 
            // txtid_client
            // 
            this.txtid_client.Location = new System.Drawing.Point(528, 77);
            this.txtid_client.Name = "txtid_client";
            this.txtid_client.Size = new System.Drawing.Size(76, 26);
            this.txtid_client.TabIndex = 135;
            this.txtid_client.Visible = false;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 630);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdr);
            this.Controls.Add(this.txtnj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtid_client);
            this.Controls.Add(this.txtid_chambre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservation";
            this.Text = "FormReservation";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.NumericUpDown txtnj;
        private System.Windows.Forms.DateTimePicker txtdr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.TextBox txtid_chambre;
        private System.Windows.Forms.TextBox txtid_client;
    }
}