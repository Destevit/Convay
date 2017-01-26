namespace Convay.WinFormsGame
{
    partial class SettingsForm
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parallelEngine = new System.Windows.Forms.RadioButton();
            this.engineStandard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.byteGridType = new System.Windows.Forms.RadioButton();
            this.gridCorePointType = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.unsafeType = new System.Windows.Forms.RadioButton();
            this.safeType = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(41, 282);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(122, 282);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parallelEngine);
            this.groupBox1.Controls.Add(this.engineStandard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Engine type";
            // 
            // parallelEngine
            // 
            this.parallelEngine.AutoSize = true;
            this.parallelEngine.Location = new System.Drawing.Point(6, 43);
            this.parallelEngine.Name = "parallelEngine";
            this.parallelEngine.Size = new System.Drawing.Size(92, 17);
            this.parallelEngine.TabIndex = 1;
            this.parallelEngine.TabStop = true;
            this.parallelEngine.Text = "&ParallelEngine";
            this.parallelEngine.UseVisualStyleBackColor = true;
            // 
            // engineStandard
            // 
            this.engineStandard.AutoSize = true;
            this.engineStandard.Location = new System.Drawing.Point(7, 20);
            this.engineStandard.Name = "engineStandard";
            this.engineStandard.Size = new System.Drawing.Size(58, 17);
            this.engineStandard.TabIndex = 0;
            this.engineStandard.TabStop = true;
            this.engineStandard.Text = "&Engine";
            this.engineStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.byteGridType);
            this.groupBox2.Controls.Add(this.gridCorePointType);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "You must recreate your grid\r\nfor the changes to take effect";
            // 
            // byteGridType
            // 
            this.byteGridType.AutoSize = true;
            this.byteGridType.Location = new System.Drawing.Point(7, 44);
            this.byteGridType.Name = "byteGridType";
            this.byteGridType.Size = new System.Drawing.Size(65, 17);
            this.byteGridType.TabIndex = 1;
            this.byteGridType.TabStop = true;
            this.byteGridType.Text = "B&yteGrid";
            this.byteGridType.UseVisualStyleBackColor = true;
            // 
            // gridCorePointType
            // 
            this.gridCorePointType.AutoSize = true;
            this.gridCorePointType.Location = new System.Drawing.Point(7, 20);
            this.gridCorePointType.Name = "gridCorePointType";
            this.gridCorePointType.Size = new System.Drawing.Size(142, 17);
            this.gridCorePointType.TabIndex = 0;
            this.gridCorePointType.TabStop = true;
            this.gridCorePointType.Text = "&GenericGrid<Core.Point>";
            this.gridCorePointType.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.unsafeType);
            this.groupBox3.Controls.Add(this.safeType);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 89);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drawing type";
            // 
            // unsafeType
            // 
            this.unsafeType.AutoSize = true;
            this.unsafeType.Location = new System.Drawing.Point(6, 38);
            this.unsafeType.Name = "unsafeType";
            this.unsafeType.Size = new System.Drawing.Size(128, 17);
            this.unsafeType.TabIndex = 2;
            this.unsafeType.TabStop = true;
            this.unsafeType.Text = "&Pointers and LockBits";
            this.unsafeType.UseVisualStyleBackColor = true;
            // 
            // safeType
            // 
            this.safeType.AutoSize = true;
            this.safeType.Location = new System.Drawing.Point(6, 19);
            this.safeType.Name = "safeType";
            this.safeType.Size = new System.Drawing.Size(69, 17);
            this.safeType.TabIndex = 1;
            this.safeType.TabStop = true;
            this.safeType.Text = "&SetPixel()";
            this.safeType.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Only for simple mode";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 317);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton parallelEngine;
        private System.Windows.Forms.RadioButton engineStandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton byteGridType;
        private System.Windows.Forms.RadioButton gridCorePointType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton unsafeType;
        private System.Windows.Forms.RadioButton safeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}