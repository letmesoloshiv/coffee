namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblDining = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItems
            // 
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(66)))), ((int)(((byte)(26)))));
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(13, 53);
            this.dgItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.Size = new System.Drawing.Size(596, 231);
            this.dgItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items:";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.txtPayment.Location = new System.Drawing.Point(52, 381);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(323, 27);
            this.txtPayment.TabIndex = 2;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.btnPurchase.Location = new System.Drawing.Point(383, 377);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(163, 35);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblTotal.Location = new System.Drawing.Point(388, 310);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: ";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblPoints.Location = new System.Drawing.Point(388, 330);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(62, 20);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Points: ";
            // 
            // lblDining
            // 
            this.lblDining.AutoSize = true;
            this.lblDining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblDining.Location = new System.Drawing.Point(26, 330);
            this.lblDining.Name = "lblDining";
            this.lblDining.Size = new System.Drawing.Size(64, 20);
            this.lblDining.TabIndex = 6;
            this.lblDining.Text = "Dining :";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblMember.Location = new System.Drawing.Point(26, 310);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(80, 20);
            this.lblMember.TabIndex = 7;
            this.lblMember.Text = "Member :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(66)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(622, 454);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblDining);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgItems);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblDining;
        private System.Windows.Forms.Label lblMember;
    }
}