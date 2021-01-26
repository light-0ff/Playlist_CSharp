namespace MyWinFormApp
{
    partial class ManagePlayListForm
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
            this.textBox_MananePlayList = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.statusStripManagePlayList = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripManagePlayList.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_MananePlayList
            // 
            this.textBox_MananePlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_MananePlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MananePlayList.Location = new System.Drawing.Point(0, 0);
            this.textBox_MananePlayList.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBox_MananePlayList.Name = "textBox_MananePlayList";
            this.textBox_MananePlayList.Size = new System.Drawing.Size(276, 44);
            this.textBox_MananePlayList.TabIndex = 0;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.Location = new System.Drawing.Point(143, 50);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(121, 41);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "Сохранить";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(12, 50);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(125, 41);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // statusStripManagePlayList
            // 
            this.statusStripManagePlayList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusErrorLabel});
            this.statusStripManagePlayList.Location = new System.Drawing.Point(0, 95);
            this.statusStripManagePlayList.Name = "statusStripManagePlayList";
            this.statusStripManagePlayList.Size = new System.Drawing.Size(276, 22);
            this.statusStripManagePlayList.TabIndex = 2;
            this.statusStripManagePlayList.Text = "statusStrip1";
            // 
            // toolStripStatusErrorLabel
            // 
            this.toolStripStatusErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusErrorLabel.Name = "toolStripStatusErrorLabel";
            this.toolStripStatusErrorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ManagePlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 117);
            this.Controls.Add(this.statusStripManagePlayList);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_MananePlayList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagePlayListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Play list";
            this.Load += new System.EventHandler(this.ManagePlayListForm_Load);
            this.statusStripManagePlayList.ResumeLayout(false);
            this.statusStripManagePlayList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MananePlayList;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.StatusStrip statusStripManagePlayList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusErrorLabel;
    }
}