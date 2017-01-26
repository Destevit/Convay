namespace Convay.WinFormsGame
{
    partial class CreateGridForm
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
            this.gridHeightText = new System.Windows.Forms.Label();
            this.gridHeight = new System.Windows.Forms.TextBox();
            this.gridWidthText = new System.Windows.Forms.Label();
            this.gridWidth = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gridHeightText
            // 
            this.gridHeightText.AutoSize = true;
            this.gridHeightText.Location = new System.Drawing.Point(13, 13);
            this.gridHeightText.Name = "gridHeightText";
            this.gridHeightText.Size = new System.Drawing.Size(41, 13);
            this.gridHeightText.TabIndex = 0;
            this.gridHeightText.Text = "Height:";
            // 
            // gridHeight
            // 
            this.gridHeight.Location = new System.Drawing.Point(13, 30);
            this.gridHeight.Name = "gridHeight";
            this.gridHeight.Size = new System.Drawing.Size(100, 20);
            this.gridHeight.TabIndex = 1;
            this.gridHeight.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // gridWidthText
            // 
            this.gridWidthText.AutoSize = true;
            this.gridWidthText.Location = new System.Drawing.Point(13, 57);
            this.gridWidthText.Name = "gridWidthText";
            this.gridWidthText.Size = new System.Drawing.Size(38, 13);
            this.gridWidthText.TabIndex = 2;
            this.gridWidthText.Text = "Width:";
            // 
            // gridWidth
            // 
            this.gridWidth.Location = new System.Drawing.Point(13, 74);
            this.gridWidth.Name = "gridWidth";
            this.gridWidth.Size = new System.Drawing.Size(100, 20);
            this.gridWidth.TabIndex = 3;
            this.gridWidth.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterPressed);
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(12, 100);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "&Ok";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(93, 100);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "&Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // CreateGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 128);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.gridWidth);
            this.Controls.Add(this.gridWidthText);
            this.Controls.Add(this.gridHeight);
            this.Controls.Add(this.gridHeightText);
            this.Name = "CreateGridForm";
            this.Text = "Create grid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gridHeightText;
        private System.Windows.Forms.TextBox gridHeight;
        private System.Windows.Forms.Label gridWidthText;
        private System.Windows.Forms.TextBox gridWidth;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}