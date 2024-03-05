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
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.buttonSH = new System.Windows.Forms.Button();
            this.buttonSC = new System.Windows.Forms.Button();
            this.buttonMH = new System.Windows.Forms.Button();
            this.buttonLH = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonLC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxWagon = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAnimalsInWagon = new System.Windows.Forms.ListBox();
            this.lblWagonCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClearLists = new System.Windows.Forms.Button();
            this.buttonDistibute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 25;
            this.listBoxAnimals.Location = new System.Drawing.Point(18, 109);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(183, 329);
            this.listBoxAnimals.TabIndex = 0;
            // 
            // buttonSH
            // 
            this.buttonSH.Location = new System.Drawing.Point(656, 287);
            this.buttonSH.Name = "buttonSH";
            this.buttonSH.Size = new System.Drawing.Size(164, 46);
            this.buttonSH.TabIndex = 1;
            this.buttonSH.Text = "Small Herb";
            this.buttonSH.UseVisualStyleBackColor = true;
            this.buttonSH.Click += new System.EventHandler(this.buttonSH_Click);
            // 
            // buttonSC
            // 
            this.buttonSC.Location = new System.Drawing.Point(838, 287);
            this.buttonSC.Name = "buttonSC";
            this.buttonSC.Size = new System.Drawing.Size(164, 46);
            this.buttonSC.TabIndex = 2;
            this.buttonSC.Text = "Small Carn";
            this.buttonSC.UseVisualStyleBackColor = true;
            this.buttonSC.Click += new System.EventHandler(this.buttonSC_Click);
            // 
            // buttonMH
            // 
            this.buttonMH.Location = new System.Drawing.Point(656, 339);
            this.buttonMH.Name = "buttonMH";
            this.buttonMH.Size = new System.Drawing.Size(164, 46);
            this.buttonMH.TabIndex = 3;
            this.buttonMH.Text = "Medium Herb";
            this.buttonMH.UseVisualStyleBackColor = true;
            this.buttonMH.Click += new System.EventHandler(this.buttonMH_Click);
            // 
            // buttonLH
            // 
            this.buttonLH.Location = new System.Drawing.Point(656, 391);
            this.buttonLH.Name = "buttonLH";
            this.buttonLH.Size = new System.Drawing.Size(164, 46);
            this.buttonLH.TabIndex = 4;
            this.buttonLH.Text = "Large Herb";
            this.buttonLH.UseVisualStyleBackColor = true;
            this.buttonLH.Click += new System.EventHandler(this.buttonLH_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(838, 339);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(164, 46);
            this.buttonMC.TabIndex = 5;
            this.buttonMC.Text = "Medium Carn";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonLC
            // 
            this.buttonLC.Location = new System.Drawing.Point(838, 391);
            this.buttonLC.Name = "buttonLC";
            this.buttonLC.Size = new System.Drawing.Size(164, 46);
            this.buttonLC.TabIndex = 6;
            this.buttonLC.Text = "Large Carn";
            this.buttonLC.UseVisualStyleBackColor = true;
            this.buttonLC.Click += new System.EventHandler(this.buttonLC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animal list";
            // 
            // listBoxWagon
            // 
            this.listBoxWagon.FormattingEnabled = true;
            this.listBoxWagon.ItemHeight = 25;
            this.listBoxWagon.Location = new System.Drawing.Point(221, 109);
            this.listBoxWagon.Name = "listBoxWagon";
            this.listBoxWagon.Size = new System.Drawing.Size(197, 329);
            this.listBoxWagon.TabIndex = 9;
            this.listBoxWagon.SelectedIndexChanged += new System.EventHandler(this.listBoxWagon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wagon list";
            // 
            // listBoxAnimalsInWagon
            // 
            this.listBoxAnimalsInWagon.FormattingEnabled = true;
            this.listBoxAnimalsInWagon.ItemHeight = 25;
            this.listBoxAnimalsInWagon.Location = new System.Drawing.Point(437, 109);
            this.listBoxAnimalsInWagon.Name = "listBoxAnimalsInWagon";
            this.listBoxAnimalsInWagon.Size = new System.Drawing.Size(197, 329);
            this.listBoxAnimalsInWagon.TabIndex = 11;
            // 
            // lblWagonCount
            // 
            this.lblWagonCount.AutoSize = true;
            this.lblWagonCount.Location = new System.Drawing.Point(355, 70);
            this.lblWagonCount.Name = "lblWagonCount";
            this.lblWagonCount.Size = new System.Drawing.Size(30, 25);
            this.lblWagonCount.TabIndex = 12;
            this.lblWagonCount.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Animals in wagon";
            // 
            // buttonClearLists
            // 
            this.buttonClearLists.Location = new System.Drawing.Point(18, 60);
            this.buttonClearLists.Name = "buttonClearLists";
            this.buttonClearLists.Size = new System.Drawing.Size(128, 45);
            this.buttonClearLists.TabIndex = 14;
            this.buttonClearLists.Text = "Clear";
            this.buttonClearLists.UseVisualStyleBackColor = true;
            // 
            // buttonDistibute
            // 
            this.buttonDistibute.Location = new System.Drawing.Point(221, 60);
            this.buttonDistibute.Name = "buttonDistibute";
            this.buttonDistibute.Size = new System.Drawing.Size(128, 45);
            this.buttonDistibute.TabIndex = 15;
            this.buttonDistibute.Text = "Distibute";
            this.buttonDistibute.UseVisualStyleBackColor = true;
            this.buttonDistibute.Click += new System.EventHandler(this.buttonDistibute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.buttonDistibute);
            this.Controls.Add(this.buttonClearLists);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWagonCount);
            this.Controls.Add(this.listBoxAnimalsInWagon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxWagon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLC);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonLH);
            this.Controls.Add(this.buttonMH);
            this.Controls.Add(this.buttonSC);
            this.Controls.Add(this.buttonSH);
            this.Controls.Add(this.listBoxAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Button buttonSH;
        private System.Windows.Forms.Button buttonSC;
        private System.Windows.Forms.Button buttonMH;
        private System.Windows.Forms.Button buttonLH;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxWagon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAnimalsInWagon;
        private System.Windows.Forms.Label lblWagonCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearLists;
        private System.Windows.Forms.Button buttonDistibute;
    }
}

