namespace AutoProxy
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.programNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.gnuLgplLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.kdeLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconSvgLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameLabel.Location = new System.Drawing.Point(13, 13);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(170, 24);
            this.programNameLabel.TabIndex = 0;
            this.programNameLabel.Text = "<program name>";
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(12, 82);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(260, 22);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "<version/author info>";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(247, 150);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(12, 46);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(260, 36);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "<description>";
            // 
            // gnuLgplLink
            // 
            this.gnuLgplLink.AutoSize = true;
            this.gnuLgplLink.Location = new System.Drawing.Point(12, 312);
            this.gnuLgplLink.Name = "gnuLgplLink";
            this.gnuLgplLink.Size = new System.Drawing.Size(177, 13);
            this.gnuLgplLink.TabIndex = 5;
            this.gnuLgplLink.TabStop = true;
            this.gnuLgplLink.Text = "GNU Lesser General Public License";
            this.gnuLgplLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gnuLgplLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "and is a part of the KDE project:";
            // 
            // kdeLink
            // 
            this.kdeLink.AutoSize = true;
            this.kdeLink.Location = new System.Drawing.Point(12, 338);
            this.kdeLink.Name = "kdeLink";
            this.kdeLink.Size = new System.Drawing.Size(106, 13);
            this.kdeLink.TabIndex = 8;
            this.kdeLink.TabStop = true;
            this.kdeLink.Text = "http://www.kde.org/";
            this.kdeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kdeLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "The";
            // 
            // iconSvgLink
            // 
            this.iconSvgLink.AutoSize = true;
            this.iconSvgLink.Location = new System.Drawing.Point(44, 299);
            this.iconSvgLink.Name = "iconSvgLink";
            this.iconSvgLink.Size = new System.Drawing.Size(47, 13);
            this.iconSvgLink.TabIndex = 10;
            this.iconSvgLink.TabStop = true;
            this.iconSvgLink.Text = "tray icon";
            this.iconSvgLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iconSvgLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "is licensed under the";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconSvgLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kdeLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gnuLgplLink);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.programNameLabel);
            this.Name = "About";
            this.Text = "About";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.LinkLabel gnuLgplLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel kdeLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel iconSvgLink;
        private System.Windows.Forms.Label label3;
    }
}