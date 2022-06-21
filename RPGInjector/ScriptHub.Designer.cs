namespace RPGInjector
{
    partial class ScriptHub
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
            this.btnMadCityScript = new System.Windows.Forms.Button();
            this.btnAdoptMeScript = new System.Windows.Forms.Button();
            this.btnJailbreakScript = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMadCityScript
            // 
            this.btnMadCityScript.Location = new System.Drawing.Point(12, 129);
            this.btnMadCityScript.Name = "btnMadCityScript";
            this.btnMadCityScript.Size = new System.Drawing.Size(113, 46);
            this.btnMadCityScript.TabIndex = 17;
            this.btnMadCityScript.Text = "Mad City Script";
            this.btnMadCityScript.UseVisualStyleBackColor = true;
            this.btnMadCityScript.Click += new System.EventHandler(this.btnMadCityScript_Click);
            // 
            // btnAdoptMeScript
            // 
            this.btnAdoptMeScript.Location = new System.Drawing.Point(12, 77);
            this.btnAdoptMeScript.Name = "btnAdoptMeScript";
            this.btnAdoptMeScript.Size = new System.Drawing.Size(113, 46);
            this.btnAdoptMeScript.TabIndex = 16;
            this.btnAdoptMeScript.Text = "Adopt Me Script";
            this.btnAdoptMeScript.UseVisualStyleBackColor = true;
            // 
            // btnJailbreakScript
            // 
            this.btnJailbreakScript.Location = new System.Drawing.Point(12, 25);
            this.btnJailbreakScript.Name = "btnJailbreakScript";
            this.btnJailbreakScript.Size = new System.Drawing.Size(113, 46);
            this.btnJailbreakScript.TabIndex = 15;
            this.btnJailbreakScript.Text = "Jailbreak Script";
            this.btnJailbreakScript.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(627, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.btnMadCityScript);
            this.Controls.Add(this.btnAdoptMeScript);
            this.Controls.Add(this.btnJailbreakScript);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScriptHub";
            this.Text = "ScriptHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMadCityScript;
        private System.Windows.Forms.Button btnAdoptMeScript;
        private System.Windows.Forms.Button btnJailbreakScript;
        private System.Windows.Forms.Button btnClose;
    }
}