namespace Google_Translate_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_comma = new System.Windows.Forms.CheckBox();
            this.checkBox_dot = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.webBrowser7 = new System.Windows.Forms.WebBrowser();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.webBrowser10 = new System.Windows.Forms.WebBrowser();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.comboBoxLanguageFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLanguageTo = new System.Windows.Forms.ComboBox();
            this.tabPage7.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(12, 3);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(413, 23);
            this.buttonTranslate.TabIndex = 1;
            this.buttonTranslate.Text = "\".\"이나 \". \" 다음인 경우를 제외하고 newLine 삭제 후 Translate 수행";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(984, 137);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "그냥 번역";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_comma
            // 
            this.checkBox_comma.AutoSize = true;
            this.checkBox_comma.Location = new System.Drawing.Point(680, 7);
            this.checkBox_comma.Name = "checkBox_comma";
            this.checkBox_comma.Size = new System.Drawing.Size(84, 16);
            this.checkBox_comma.TabIndex = 7;
            this.checkBox_comma.Text = ", 다음 개행";
            this.checkBox_comma.UseVisualStyleBackColor = true;
            // 
            // checkBox_dot
            // 
            this.checkBox_dot.AutoSize = true;
            this.checkBox_dot.Location = new System.Drawing.Point(770, 7);
            this.checkBox_dot.Name = "checkBox_dot";
            this.checkBox_dot.Size = new System.Drawing.Size(84, 16);
            this.checkBox_dot.TabIndex = 8;
            this.checkBox_dot.Text = ". 다음 개행";
            this.checkBox_dot.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.webBrowser7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(976, 638);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "excite영일사전";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // webBrowser7
            // 
            this.webBrowser7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser7.Location = new System.Drawing.Point(3, 3);
            this.webBrowser7.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser7.Name = "webBrowser7";
            this.webBrowser7.ScriptErrorsSuppressed = true;
            this.webBrowser7.Size = new System.Drawing.Size(970, 632);
            this.webBrowser7.TabIndex = 0;
            this.webBrowser7.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.webBrowser10);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(976, 638);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Merriam Webster";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // webBrowser10
            // 
            this.webBrowser10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser10.Location = new System.Drawing.Point(3, 3);
            this.webBrowser10.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser10.Name = "webBrowser10";
            this.webBrowser10.ScriptErrorsSuppressed = true;
            this.webBrowser10.Size = new System.Drawing.Size(970, 632);
            this.webBrowser10.TabIndex = 0;
            this.webBrowser10.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webBrowser5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(976, 638);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "네이버사전";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // webBrowser5
            // 
            this.webBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser5.Location = new System.Drawing.Point(3, 3);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.ScriptErrorsSuppressed = true;
            this.webBrowser5.Size = new System.Drawing.Size(970, 632);
            this.webBrowser5.TabIndex = 0;
            this.webBrowser5.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Revers 스펠 및 문법 체크";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(970, 632);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "구글 번역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(970, 632);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Tag = "";
            this.webBrowser1.Url = new System.Uri("https://translate.google.com/", System.UriKind.Absolute);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 664);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // comboBoxLanguageFrom
            // 
            this.comboBoxLanguageFrom.FormattingEnabled = true;
            this.comboBoxLanguageFrom.Location = new System.Drawing.Point(439, 5);
            this.comboBoxLanguageFrom.Name = "comboBoxLanguageFrom";
            this.comboBoxLanguageFrom.Size = new System.Drawing.Size(90, 20);
            this.comboBoxLanguageFrom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "to";
            // 
            // comboBoxLanguageTo
            // 
            this.comboBoxLanguageTo.FormattingEnabled = true;
            this.comboBoxLanguageTo.Location = new System.Drawing.Point(553, 5);
            this.comboBoxLanguageTo.Name = "comboBoxLanguageTo";
            this.comboBoxLanguageTo.Size = new System.Drawing.Size(90, 20);
            this.comboBoxLanguageTo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 380);
            this.Controls.Add(this.comboBoxLanguageTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLanguageFrom);
            this.Controls.Add(this.checkBox_dot);
            this.Controls.Add(this.checkBox_comma);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTranslate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Google Translate Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage7.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_comma;
        private System.Windows.Forms.CheckBox checkBox_dot;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.WebBrowser webBrowser7;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.WebBrowser webBrowser10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBoxLanguageFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLanguageTo;
    }
}

