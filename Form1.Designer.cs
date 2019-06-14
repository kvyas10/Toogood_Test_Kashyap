namespace Toogood_Test_Kashyap
{
    partial class Form1
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
            this.Btn_Standard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Standard
            // 
            this.Btn_Standard.Location = new System.Drawing.Point(230, 177);
            this.Btn_Standard.Name = "Btn_Standard";
            this.Btn_Standard.Size = new System.Drawing.Size(325, 45);
            this.Btn_Standard.TabIndex = 0;
            this.Btn_Standard.Text = "Convert Standard Input in Generic Structure";
            this.Btn_Standard.UseVisualStyleBackColor = true;
            this.Btn_Standard.Click += new System.EventHandler(this.Btn_Standard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Standard);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Standard;
    }
}

