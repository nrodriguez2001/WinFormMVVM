namespace WinFormMVVM
{
    partial class HomeView
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
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxMyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMyStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMyStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(321, 97);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // textBoxMyInput
            // 
            this.textBoxMyInput.Location = new System.Drawing.Point(171, 99);
            this.textBoxMyInput.Name = "textBoxMyInput";
            this.textBoxMyInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter some text:";
            // 
            // toolStripMyStatus
            // 
            this.toolStripMyStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.toolStripMyStatus.Location = new System.Drawing.Point(0, 390);
            this.toolStripMyStatus.Name = "toolStripMyStatus";
            this.toolStripMyStatus.Size = new System.Drawing.Size(654, 22);
            this.toolStripMyStatus.TabIndex = 3;
            this.toolStripMyStatus.Text = "Default";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Default";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 412);
            this.Controls.Add(this.toolStripMyStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMyInput);
            this.Controls.Add(this.btnOK);
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.toolStripMyStatus.ResumeLayout(false);
            this.toolStripMyStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBoxMyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip toolStripMyStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}