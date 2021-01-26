namespace MyWinFormApp
{
    partial class OptionsForm
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
            this.tabControlOptionForm = new System.Windows.Forms.TabControl();
            this.tabPage_Design = new System.Windows.Forms.TabPage();
            this.groupBox_BG_Color = new System.Windows.Forms.GroupBox();
            this.trackBar_BLUE = new System.Windows.Forms.TrackBar();
            this.trackBar_GREEN = new System.Windows.Forms.TrackBar();
            this.trackBar_RED = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlOptionForm.SuspendLayout();
            this.tabPage_Design.SuspendLayout();
            this.groupBox_BG_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RED)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOptionForm
            // 
            this.tabControlOptionForm.Controls.Add(this.tabPage_Design);
            this.tabControlOptionForm.Controls.Add(this.tabPage2);
            this.tabControlOptionForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOptionForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptionForm.Name = "tabControlOptionForm";
            this.tabControlOptionForm.SelectedIndex = 0;
            this.tabControlOptionForm.Size = new System.Drawing.Size(800, 450);
            this.tabControlOptionForm.TabIndex = 0;
            // 
            // tabPage_Design
            // 
            this.tabPage_Design.Controls.Add(this.groupBox_BG_Color);
            this.tabPage_Design.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Design.Name = "tabPage_Design";
            this.tabPage_Design.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Design.Size = new System.Drawing.Size(792, 424);
            this.tabPage_Design.TabIndex = 0;
            this.tabPage_Design.Text = "tabPage1";
            this.tabPage_Design.UseVisualStyleBackColor = true;
            // 
            // groupBox_BG_Color
            // 
            this.groupBox_BG_Color.Controls.Add(this.trackBar_BLUE);
            this.groupBox_BG_Color.Controls.Add(this.trackBar_GREEN);
            this.groupBox_BG_Color.Controls.Add(this.trackBar_RED);
            this.groupBox_BG_Color.Location = new System.Drawing.Point(9, 7);
            this.groupBox_BG_Color.Name = "groupBox_BG_Color";
            this.groupBox_BG_Color.Size = new System.Drawing.Size(226, 153);
            this.groupBox_BG_Color.TabIndex = 0;
            this.groupBox_BG_Color.TabStop = false;
            this.groupBox_BG_Color.Text = "Background color";
            // 
            // trackBar_BLUE
            // 
            this.trackBar_BLUE.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_BLUE.Location = new System.Drawing.Point(3, 106);
            this.trackBar_BLUE.Maximum = 255;
            this.trackBar_BLUE.Name = "trackBar_BLUE";
            this.trackBar_BLUE.Size = new System.Drawing.Size(220, 45);
            this.trackBar_BLUE.TabIndex = 2;
            this.trackBar_BLUE.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar_GREEN
            // 
            this.trackBar_GREEN.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_GREEN.Location = new System.Drawing.Point(3, 61);
            this.trackBar_GREEN.Maximum = 255;
            this.trackBar_GREEN.Name = "trackBar_GREEN";
            this.trackBar_GREEN.Size = new System.Drawing.Size(220, 45);
            this.trackBar_GREEN.TabIndex = 1;
            this.trackBar_GREEN.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar_RED
            // 
            this.trackBar_RED.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_RED.Location = new System.Drawing.Point(3, 16);
            this.trackBar_RED.Margin = new System.Windows.Forms.Padding(8);
            this.trackBar_RED.Maximum = 255;
            this.trackBar_RED.Name = "trackBar_RED";
            this.trackBar_RED.Size = new System.Drawing.Size(220, 45);
            this.trackBar_RED.TabIndex = 0;
            this.trackBar_RED.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlOptionForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.tabControlOptionForm.ResumeLayout(false);
            this.tabPage_Design.ResumeLayout(false);
            this.groupBox_BG_Color.ResumeLayout(false);
            this.groupBox_BG_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOptionForm;
        private System.Windows.Forms.TabPage tabPage_Design;
        private System.Windows.Forms.GroupBox groupBox_BG_Color;
        private System.Windows.Forms.TrackBar trackBar_BLUE;
        private System.Windows.Forms.TrackBar trackBar_GREEN;
        private System.Windows.Forms.TrackBar trackBar_RED;
        private System.Windows.Forms.TabPage tabPage2;
    }
}