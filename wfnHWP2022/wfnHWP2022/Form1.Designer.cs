namespace wfnHWP2022
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
            this.axHwpCtrl1 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axHwpCtrl1
            // 
            this.axHwpCtrl1.Enabled = true;
            this.axHwpCtrl1.Location = new System.Drawing.Point(6, 12);
            this.axHwpCtrl1.Name = "axHwpCtrl1";
            this.axHwpCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl1.OcxState")));
            this.axHwpCtrl1.Size = new System.Drawing.Size(567, 283);
            this.axHwpCtrl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axHwpCtrl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl1;
        private System.Windows.Forms.Button button1;
    }
}

