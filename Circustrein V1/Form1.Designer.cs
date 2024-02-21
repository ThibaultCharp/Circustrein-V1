namespace Circustrein_V1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSH = new System.Windows.Forms.Button();
            this.buttonSC = new System.Windows.Forms.Button();
            this.buttonMH = new System.Windows.Forms.Button();
            this.buttonLH = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonLC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 379);
            this.listBox1.TabIndex = 0;
            // 
            // buttonSH
            // 
            this.buttonSH.Location = new System.Drawing.Point(372, 12);
            this.buttonSH.Name = "buttonSH";
            this.buttonSH.Size = new System.Drawing.Size(152, 46);
            this.buttonSH.TabIndex = 1;
            this.buttonSH.Text = "Small Herb";
            this.buttonSH.UseVisualStyleBackColor = true;
            this.buttonSH.Click += new System.EventHandler(this.buttonSH_Click);
            // 
            // buttonSC
            // 
            this.buttonSC.Location = new System.Drawing.Point(575, 12);
            this.buttonSC.Name = "buttonSC";
            this.buttonSC.Size = new System.Drawing.Size(152, 46);
            this.buttonSC.TabIndex = 2;
            this.buttonSC.Text = "Small Carn";
            this.buttonSC.UseVisualStyleBackColor = true;
            this.buttonSC.Click += new System.EventHandler(this.buttonSC_Click);
            // 
            // buttonMH
            // 
            this.buttonMH.Location = new System.Drawing.Point(372, 64);
            this.buttonMH.Name = "buttonMH";
            this.buttonMH.Size = new System.Drawing.Size(152, 46);
            this.buttonMH.TabIndex = 3;
            this.buttonMH.Text = "Medium Herb";
            this.buttonMH.UseVisualStyleBackColor = true;
            this.buttonMH.Click += new System.EventHandler(this.buttonMH_Click);
            // 
            // buttonLH
            // 
            this.buttonLH.Location = new System.Drawing.Point(372, 116);
            this.buttonLH.Name = "buttonLH";
            this.buttonLH.Size = new System.Drawing.Size(152, 46);
            this.buttonLH.TabIndex = 4;
            this.buttonLH.Text = "Lagre Herb";
            this.buttonLH.UseVisualStyleBackColor = true;
            this.buttonLH.Click += new System.EventHandler(this.buttonLH_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(575, 64);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(152, 46);
            this.buttonMC.TabIndex = 5;
            this.buttonMC.Text = "Medium Carn";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonLC
            // 
            this.buttonLC.Location = new System.Drawing.Point(575, 116);
            this.buttonLC.Name = "buttonLC";
            this.buttonLC.Size = new System.Drawing.Size(152, 46);
            this.buttonLC.TabIndex = 6;
            this.buttonLC.Text = "Large Carn";
            this.buttonLC.UseVisualStyleBackColor = true;
            this.buttonLC.Click += new System.EventHandler(this.buttonLC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLC);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonLH);
            this.Controls.Add(this.buttonMH);
            this.Controls.Add(this.buttonSC);
            this.Controls.Add(this.buttonSH);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSH;
        private System.Windows.Forms.Button buttonSC;
        private System.Windows.Forms.Button buttonMH;
        private System.Windows.Forms.Button buttonLH;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonLC;
    }
}

