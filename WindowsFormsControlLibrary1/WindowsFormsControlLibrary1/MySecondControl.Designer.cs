namespace WindowsFormsControlLibrary1
{
    partial class MySecondControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlModelTari = new System.Windows.Forms.Panel();
            this.panelcolection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncolection = new System.Windows.Forms.Button();
            this.pnlModelTari.SuspendLayout();
            this.panelcolection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModelTari
            // 
            this.pnlModelTari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlModelTari.Controls.Add(this.panelcolection);
            this.pnlModelTari.Location = new System.Drawing.Point(8, 8);
            this.pnlModelTari.Name = "pnlModelTari";
            this.pnlModelTari.Size = new System.Drawing.Size(811, 451);
            this.pnlModelTari.TabIndex = 5;
            // 
            // panelcolection
            // 
            this.panelcolection.Controls.Add(this.label1);
            this.panelcolection.Controls.Add(this.buttoncolection);
            this.panelcolection.Location = new System.Drawing.Point(246, 122);
            this.panelcolection.Name = "panelcolection";
            this.panelcolection.Size = new System.Drawing.Size(208, 169);
            this.panelcolection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rekam Tari";
            // 
            // buttoncolection
            // 
            this.buttoncolection.BackColor = System.Drawing.SystemColors.Control;
            this.buttoncolection.BackgroundImage = global::WindowsFormsControlLibrary1.Properties.Resources.kamera12;
            this.buttoncolection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncolection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttoncolection.FlatAppearance.BorderSize = 0;
            this.buttoncolection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncolection.Location = new System.Drawing.Point(44, 33);
            this.buttoncolection.Name = "buttoncolection";
            this.buttoncolection.Size = new System.Drawing.Size(121, 102);
            this.buttoncolection.TabIndex = 0;
            this.buttoncolection.UseVisualStyleBackColor = false;
            // 
            // MySecondControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlModelTari);
            this.Name = "MySecondControl";
            this.Size = new System.Drawing.Size(811, 451);
            this.pnlModelTari.ResumeLayout(false);
            this.panelcolection.ResumeLayout(false);
            this.panelcolection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModelTari;
        private System.Windows.Forms.Panel panelcolection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncolection;
    }
}
