﻿namespace system
{
    partial class Balance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.displaygrid = new System.Windows.Forms.DataGridView();
            this.sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.displaygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(131, 99);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(109, 39);
            this.value.TabIndex = 1;
            this.value.Text = "label3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(39, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // displaygrid
            // 
            this.displaygrid.AllowUserToDeleteRows = false;
            this.displaygrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displaygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaygrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdate,
            this.strans});
            this.displaygrid.Location = new System.Drawing.Point(287, 86);
            this.displaygrid.Name = "displaygrid";
            this.displaygrid.Size = new System.Drawing.Size(301, 158);
            this.displaygrid.TabIndex = 6;
            // 
            // sdate
            // 
            this.sdate.HeaderText = "Date";
            this.sdate.Name = "sdate";
            this.sdate.ReadOnly = true;
            // 
            // strans
            // 
            this.strans.HeaderText = "Transaction";
            this.strans.Name = "strans";
            this.strans.ReadOnly = true;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.displaygrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Balance";
            this.Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)(this.displaygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView displaygrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn strans;
    }
}