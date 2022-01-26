namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();

            this.buttonRoliks = new System.Windows.Forms.Button();

            this.buttonAndrejs = new System.Windows.Forms.Button();

            this.buttonbertule = new System.Windows.Forms.Button();

            this.ps_btn = new System.Windows.Forms.Button();
            this.ps_lbl = new System.Windows.Forms.Label();


            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // buttonRoliks
            // 
            this.buttonRoliks.Location = new System.Drawing.Point(188, 162);
            this.buttonRoliks.Name = "buttonRoliks";
            this.buttonRoliks.Size = new System.Drawing.Size(116, 23);
            this.buttonRoliks.TabIndex = 1;
            this.buttonRoliks.Text = "Noslēpums";
            this.buttonRoliks.UseVisualStyleBackColor = true;
            this.buttonRoliks.Click += new System.EventHandler(this.button1_Click);
            // 
            // ps_btn
            // 
            this.ps_btn.Location = new System.Drawing.Point(355, 107);
            this.ps_btn.Name = "ps_btn";
            this.ps_btn.Size = new System.Drawing.Size(75, 23);
            this.ps_btn.TabIndex = 2;
            this.ps_btn.Text = "ps";
            this.ps_btn.UseVisualStyleBackColor = true;
            this.ps_btn.Click += new System.EventHandler(this.ps_btn_Click);
            // 
            // ps_lbl
            // 
            this.ps_lbl.AutoSize = true;
            this.ps_lbl.Location = new System.Drawing.Point(377, 61);
            this.ps_lbl.Name = "ps_lbl";
            this.ps_lbl.Size = new System.Drawing.Size(0, 13);
            this.ps_lbl.TabIndex = 3;
            // 
            // buttonbertule
            // 
            this.buttonbertule.Location = new System.Drawing.Point(28, 87);
            this.buttonbertule.Name = "buttonbertule";
            this.buttonbertule.Size = new System.Drawing.Size(74, 27);
            this.buttonbertule.TabIndex = 2;
            this.buttonbertule.Text = "Sveiks no";
            this.buttonbertule.UseVisualStyleBackColor = true;
            this.buttonbertule.Click += new System.EventHandler(this.buttonbertule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 290);

            this.Controls.Add(this.buttonbertule);


            this.Controls.Add(this.buttonRoliks);

            this.Controls.Add(this.ps_lbl);
            this.Controls.Add(this.ps_btn);

            this.Controls.Add(this.buttonAndrejs);

            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonRoliks;

        private System.Windows.Forms.Button buttonAndrejs;

        private System.Windows.Forms.Button buttonbertule;

        private System.Windows.Forms.Button ps_btn;
        private System.Windows.Forms.Label ps_lbl;


    }
}

