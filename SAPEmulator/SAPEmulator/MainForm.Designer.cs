namespace SAPEmulator
{
    partial class MainForm
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
            this.OpenSap1Btn = new System.Windows.Forms.Button();
            this.OpenSap2Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenSap1Btn
            // 
            this.OpenSap1Btn.Location = new System.Drawing.Point(64, 49);
            this.OpenSap1Btn.Name = "OpenSap1Btn";
            this.OpenSap1Btn.Size = new System.Drawing.Size(75, 23);
            this.OpenSap1Btn.TabIndex = 0;
            this.OpenSap1Btn.Text = "SAP 1";
            this.OpenSap1Btn.UseVisualStyleBackColor = true;
            this.OpenSap1Btn.Click += new System.EventHandler(this.OpenSap1Btn_Click);
            // 
            // OpenSap2Btn
            // 
            this.OpenSap2Btn.Location = new System.Drawing.Point(64, 79);
            this.OpenSap2Btn.Name = "OpenSap2Btn";
            this.OpenSap2Btn.Size = new System.Drawing.Size(75, 23);
            this.OpenSap2Btn.TabIndex = 1;
            this.OpenSap2Btn.Text = "SAP 2";
            this.OpenSap2Btn.UseVisualStyleBackColor = true;
            this.OpenSap2Btn.Click += new System.EventHandler(this.OpenSap2Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 177);
            this.Controls.Add(this.OpenSap2Btn);
            this.Controls.Add(this.OpenSap1Btn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSap1Btn;
        private System.Windows.Forms.Button OpenSap2Btn;
    }
}