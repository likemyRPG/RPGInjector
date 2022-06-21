namespace RPGInjector
{
    partial class RPGInjector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPGInjector));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstBScripts = new System.Windows.Forms.ListBox();
            this.FCTBScript = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnScriptHub = new System.Windows.Forms.Button();
            this.buttonInject = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FCTBScript)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(374, 330);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 22;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(565, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lstBScripts
            // 
            this.lstBScripts.BackColor = System.Drawing.Color.SandyBrown;
            this.lstBScripts.FormattingEnabled = true;
            this.lstBScripts.Location = new System.Drawing.Point(550, 113);
            this.lstBScripts.Name = "lstBScripts";
            this.lstBScripts.Size = new System.Drawing.Size(100, 199);
            this.lstBScripts.TabIndex = 20;
            this.lstBScripts.SelectedIndexChanged += new System.EventHandler(this.lstBScripts_SelectedIndexChanged);
            // 
            // FCTBScript
            // 
            this.FCTBScript.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FCTBScript.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.FCTBScript.AutoScrollMinSize = new System.Drawing.Size(187, 14);
            this.FCTBScript.BackBrush = null;
            this.FCTBScript.BackColor = System.Drawing.Color.Transparent;
            this.FCTBScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FCTBScript.BookmarkColor = System.Drawing.SystemColors.ScrollBar;
            this.FCTBScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FCTBScript.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FCTBScript.CharHeight = 14;
            this.FCTBScript.CharWidth = 8;
            this.FCTBScript.CommentPrefix = "--";
            this.FCTBScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FCTBScript.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FCTBScript.IndentBackColor = System.Drawing.Color.LightYellow;
            this.FCTBScript.IsReplaceMode = false;
            this.FCTBScript.Language = FastColoredTextBoxNS.Language.Lua;
            this.FCTBScript.LeftBracket = '(';
            this.FCTBScript.LeftBracket2 = '{';
            this.FCTBScript.Location = new System.Drawing.Point(12, 58);
            this.FCTBScript.Name = "FCTBScript";
            this.FCTBScript.Paddings = new System.Windows.Forms.Padding(0);
            this.FCTBScript.RightBracket = ')';
            this.FCTBScript.RightBracket2 = '}';
            this.FCTBScript.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FCTBScript.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FCTBScript.ServiceColors")));
            this.FCTBScript.Size = new System.Drawing.Size(532, 254);
            this.FCTBScript.TabIndex = 19;
            this.FCTBScript.Text = "-- Made By likemyRPG";
            this.FCTBScript.Zoom = 100;
            // 
            // btnScriptHub
            // 
            this.btnScriptHub.Location = new System.Drawing.Point(565, 58);
            this.btnScriptHub.Name = "btnScriptHub";
            this.btnScriptHub.Size = new System.Drawing.Size(75, 23);
            this.btnScriptHub.TabIndex = 18;
            this.btnScriptHub.Text = "Script Hub";
            this.btnScriptHub.UseVisualStyleBackColor = true;
            this.btnScriptHub.Click += new System.EventHandler(this.btnScriptHub_Click);
            // 
            // buttonInject
            // 
            this.buttonInject.Location = new System.Drawing.Point(575, 325);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(75, 23);
            this.buttonInject.TabIndex = 17;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(261, 325);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 16;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(180, 325);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(99, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(18, 325);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(662, 52);
            this.pnlTop.TabIndex = 12;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(598, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(627, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(226, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Injector - v1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPG";
            // 
            // RPGInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstBScripts);
            this.Controls.Add(this.FCTBScript);
            this.Controls.Add(this.btnScriptHub);
            this.Controls.Add(this.buttonInject);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RPGInjector";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RPGInjector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FCTBScript)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstBScripts;
        private FastColoredTextBoxNS.FastColoredTextBox FCTBScript;
        private System.Windows.Forms.Button btnScriptHub;
        private System.Windows.Forms.Button buttonInject;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

