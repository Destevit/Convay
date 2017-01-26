namespace Convay.WinFormsGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicubicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicubicHQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinearHQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fps = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fpsCounter = new System.Windows.Forms.Timer(this.components);
            this.interpolatedPictureBox1 = new Convay.WinFormsGame.InterpolatedPictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interpolatedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.demoToolStripMenuItem,
            this.fps,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Tag = "";
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.randomizeToolStripMenuItem});
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.gridToolStripMenuItem.Text = "&Grid";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.createToolStripMenuItem.Tag = "";
            this.createToolStripMenuItem.Text = "&Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.randomizeToolStripMenuItem.Text = "&Randomize";
            this.randomizeToolStripMenuItem.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interpolationToolStripMenuItem,
            this.sizeModeToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToolStripMenuItem,
            this.bilinearToolStripMenuItem,
            this.bicubicToolStripMenuItem,
            this.highToolStripMenuItem,
            this.sharpToolStripMenuItem,
            this.bicubicHQToolStripMenuItem,
            this.bilinearHQToolStripMenuItem});
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.interpolationToolStripMenuItem.Text = "&Interpolation";
            this.interpolationToolStripMenuItem.DropDownOpening += new System.EventHandler(this.interpolationToolStripMenuItem_DropDownOpening);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lowToolStripMenuItem.Tag = "tsmi/i/l";
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // bilinearToolStripMenuItem
            // 
            this.bilinearToolStripMenuItem.Name = "bilinearToolStripMenuItem";
            this.bilinearToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bilinearToolStripMenuItem.Tag = "tsmi/i/br";
            this.bilinearToolStripMenuItem.Text = "Bilinear";
            this.bilinearToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // bicubicToolStripMenuItem
            // 
            this.bicubicToolStripMenuItem.Name = "bicubicToolStripMenuItem";
            this.bicubicToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bicubicToolStripMenuItem.Tag = "tsmi/i/bc";
            this.bicubicToolStripMenuItem.Text = "Bicubic";
            this.bicubicToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.highToolStripMenuItem.Tag = "tsmi/i/h";
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // sharpToolStripMenuItem
            // 
            this.sharpToolStripMenuItem.Name = "sharpToolStripMenuItem";
            this.sharpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sharpToolStripMenuItem.Tag = "tsmi/i/nn";
            this.sharpToolStripMenuItem.Text = "Sharp";
            this.sharpToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // bicubicHQToolStripMenuItem
            // 
            this.bicubicHQToolStripMenuItem.Name = "bicubicHQToolStripMenuItem";
            this.bicubicHQToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bicubicHQToolStripMenuItem.Tag = "tsmi/i/hqbc";
            this.bicubicHQToolStripMenuItem.Text = "Bicubic HQ";
            this.bicubicHQToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // bilinearHQToolStripMenuItem
            // 
            this.bilinearHQToolStripMenuItem.Name = "bilinearHQToolStripMenuItem";
            this.bilinearHQToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bilinearHQToolStripMenuItem.Tag = "tsmi/i/hqbr";
            this.bilinearHQToolStripMenuItem.Text = "Bilinear HQ";
            this.bilinearHQToolStripMenuItem.Click += new System.EventHandler(this.interpolationDownStripMenuItem_Click);
            // 
            // sizeModeToolStripMenuItem
            // 
            this.sizeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.sizeModeToolStripMenuItem.Name = "sizeModeToolStripMenuItem";
            this.sizeModeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sizeModeToolStripMenuItem.Text = "&Size mode";
            this.sizeModeToolStripMenuItem.DropDownOpening += new System.EventHandler(this.sizeModeToolStripMenuItem_DropDownOpening);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zoomToolStripMenuItem.Tag = "tsmi/sm/z";
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.sizeModeDownStripMenuItem_Click);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.stretchToolStripMenuItem.Tag = "tsmi/sm/s";
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.sizeModeDownStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Tag = "tsmi/sm/c";
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.sizeModeDownStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.extendedToolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.colorsToolStripMenuItem.Text = "&Colors";
            this.colorsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.colorsToolStripMenuItem_DropDownOpening);
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // extendedToolStripMenuItem
            // 
            this.extendedToolStripMenuItem.Name = "extendedToolStripMenuItem";
            this.extendedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.extendedToolStripMenuItem.Text = "Extended";
            this.extendedToolStripMenuItem.Click += new System.EventHandler(this.extendedToolStripMenuItem_Click);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(124, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRulesToolStripMenuItem});
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rulesToolStripMenuItem.Text = "&Rules";
            // 
            // setRulesToolStripMenuItem
            // 
            this.setRulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesTextBox});
            this.setRulesToolStripMenuItem.Name = "setRulesToolStripMenuItem";
            this.setRulesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.setRulesToolStripMenuItem.Text = "&Set rules";
            this.setRulesToolStripMenuItem.DropDownClosed += new System.EventHandler(this.setRulesToolStripMenuItem_DropDownClosed);
            this.setRulesToolStripMenuItem.DropDownOpening += new System.EventHandler(this.setRulesToolStripMenuItem_DropDownOpening);
            // 
            // gameRulesTextBox
            // 
            this.gameRulesTextBox.Name = "gameRulesTextBox";
            this.gameRulesTextBox.Size = new System.Drawing.Size(152, 23);
            this.gameRulesTextBox.Text = "GameRule?";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.intervalToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startToolStripMenuItem.Text = "St&art";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.stopToolStripMenuItem.Text = "St&op";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // intervalToolStripMenuItem
            // 
            this.intervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervalTextBoxToolStripMenuItem});
            this.intervalToolStripMenuItem.Name = "intervalToolStripMenuItem";
            this.intervalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.intervalToolStripMenuItem.Text = "&Interval";
            this.intervalToolStripMenuItem.DropDownClosed += new System.EventHandler(this.intervalToolStripMenuItem_DropDownClosed);
            this.intervalToolStripMenuItem.DropDownOpening += new System.EventHandler(this.intervalToolStripMenuItem_DropDownOpening);
            // 
            // intervalTextBoxToolStripMenuItem
            // 
            this.intervalTextBoxToolStripMenuItem.Name = "intervalTextBoxToolStripMenuItem";
            this.intervalTextBoxToolStripMenuItem.Size = new System.Drawing.Size(154, 23);
            this.intervalTextBoxToolStripMenuItem.Text = "0";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.demoToolStripMenuItem.Text = "&Demo";
            this.demoToolStripMenuItem.Click += new System.EventHandler(this.demoToolStripMenuItem_Click);
            // 
            // fps
            // 
            this.fps.Enabled = false;
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(35, 20);
            this.fps.Text = "fps";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.infoToolStripMenuItem.Text = "hover for info";
            this.infoToolStripMenuItem.MouseEnter += new System.EventHandler(this.enToolStripMenuItem_MouseEnter);
            this.infoToolStripMenuItem.MouseLeave += new System.EventHandler(this.enToolStripMenuItem_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "glg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "glg";
            // 
            // fpsCounter
            // 
            this.fpsCounter.Enabled = true;
            this.fpsCounter.Interval = 1000;
            this.fpsCounter.Tick += new System.EventHandler(this.fpsCounter_Tick);
            // 
            // interpolatedPictureBox1
            // 
            this.interpolatedPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.interpolatedPictureBox1.Location = new System.Drawing.Point(0, 24);
            this.interpolatedPictureBox1.Name = "interpolatedPictureBox1";
            this.interpolatedPictureBox1.Size = new System.Drawing.Size(455, 337);
            this.interpolatedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.interpolatedPictureBox1.TabIndex = 1;
            this.interpolatedPictureBox1.TabStop = false;
            this.interpolatedPictureBox1.Click += new System.EventHandler(this.interpolatedPictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 361);
            this.Controls.Add(this.interpolatedPictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Game of Life";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interpolatedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private InterpolatedPictureBox interpolatedPictureBox1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilinearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicubicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicubicHQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilinearHQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox gameRulesTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox intervalTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer fpsCounter;
        private System.Windows.Forms.ToolStripMenuItem fps;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

