namespace Notepad
{
    partial class FormSettings
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
            this.example = new System.Windows.Forms.Label();
            this.labelTextEx = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.Location = new System.Drawing.Point(37, 277);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(51, 13);
            this.example.TabIndex = 0;
            this.example.Text = "Образец";
            this.example.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTextEx
            // 
            this.labelTextEx.AutoSize = true;
            this.labelTextEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextEx.Location = new System.Drawing.Point(42, 290);
            this.labelTextEx.Name = "labelTextEx";
            this.labelTextEx.Size = new System.Drawing.Size(174, 39);
            this.labelTextEx.TabIndex = 1;
            this.labelTextEx.Text = "AabbYyZz";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "14",
            "16",
            "18",
            "22",
            "26",
            "32",
            "40",
            "64",
            "72"});
            this.fontBox.Location = new System.Drawing.Point(12, 12);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(121, 21);
            this.fontBox.TabIndex = 2;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.onFontChanged);
            this.fontBox.Click += new System.EventHandler(this.onClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "жирный"});
            this.styleBox.Location = new System.Drawing.Point(160, 12);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(121, 21);
            this.styleBox.TabIndex = 3;
            this.styleBox.SelectedIndexChanged += new System.EventHandler(this.onStyleChange);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(49, 423);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 4;
            this.accept.Text = "Принять";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 494);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.labelTextEx);
            this.Controls.Add(this.example);
            this.Name = "FormSettings";
            this.Text = "Шрифт";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label example;
        private System.Windows.Forms.Label labelTextEx;
        private System.Windows.Forms.ComboBox fontBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Button accept;
    }
}