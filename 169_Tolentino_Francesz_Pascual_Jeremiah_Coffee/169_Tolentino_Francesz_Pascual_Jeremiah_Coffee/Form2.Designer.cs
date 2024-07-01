namespace _169_Tolentino_Francesz_Pascual_Jeremiah_Coffee
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
            this.lblTot = new System.Windows.Forms.Label();
            this.lblPts = new System.Windows.Forms.Label();
            this.lblDine = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblDining = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnPur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(38, 9);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(34, 13);
            this.lblTot.TabIndex = 0;
            this.lblTot.Text = "Total:";
            this.lblTot.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Location = new System.Drawing.Point(38, 39);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(39, 13);
            this.lblPts.TabIndex = 1;
            this.lblPts.Text = "Points:";
            // 
            // lblDine
            // 
            this.lblDine.AutoSize = true;
            this.lblDine.Location = new System.Drawing.Point(230, 34);
            this.lblDine.Name = "lblDine";
            this.lblDine.Size = new System.Drawing.Size(43, 13);
            this.lblDine.TabIndex = 2;
            this.lblDine.Text = "Dining: ";
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.Location = new System.Drawing.Point(230, 9);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(45, 13);
            this.lblMem.TabIndex = 2;
            this.lblMem.Text = "Member";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(41, 97);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(372, 189);
            this.dgvDisplay.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(78, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(78, 39);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Points";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(281, 9);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(45, 13);
            this.lblMember.TabIndex = 6;
            this.lblMember.Text = "Member";
            // 
            // lblDining
            // 
            this.lblDining.AutoSize = true;
            this.lblDining.Location = new System.Drawing.Point(279, 34);
            this.lblDining.Name = "lblDining";
            this.lblDining.Size = new System.Drawing.Size(43, 13);
            this.lblDining.TabIndex = 7;
            this.lblDining.Text = "Dining: ";
            // 
            // txtPayment
            // 
            this.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayment.Location = new System.Drawing.Point(81, 312);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(170, 20);
            this.txtPayment.TabIndex = 8;
            // 
            // btnPur
            // 
            this.btnPur.Location = new System.Drawing.Point(284, 309);
            this.btnPur.Name = "btnPur";
            this.btnPur.Size = new System.Drawing.Size(75, 23);
            this.btnPur.TabIndex = 9;
            this.btnPur.Text = "Purchase";
            this.btnPur.UseVisualStyleBackColor = true;
            this.btnPur.Click += new System.EventHandler(this.btnPur_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 354);
            this.Controls.Add(this.btnPur);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblDining);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.lblMem);
            this.Controls.Add(this.lblDine);
            this.Controls.Add(this.lblPts);
            this.Controls.Add(this.lblTot);
            this.Name = "Form2";
            this.Text = "+-";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.Label lblDine;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblDining;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnPur;
    }
}