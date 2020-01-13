namespace admincsbaru
{
    partial class triicustomcontrolcs
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
            this.panelcolection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncolection = new System.Windows.Forms.Button();
            this.panelcolection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcolection
            // 
            this.panelcolection.Controls.Add(this.label1);
            this.panelcolection.Controls.Add(this.buttoncolection);
            this.panelcolection.Location = new System.Drawing.Point(322, 132);
            this.panelcolection.Name = "panelcolection";
            this.panelcolection.Size = new System.Drawing.Size(208, 169);
            this.panelcolection.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playbox";
            // 
            // buttoncolection
            // 
            this.buttoncolection.BackColor = System.Drawing.SystemColors.Control;
            this.buttoncolection.BackgroundImage = global::admincsbaru.Properties.Resources.dancing;
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
            // triicustomcontrolcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelcolection);
            this.Name = "triicustomcontrolcs";
            this.Size = new System.Drawing.Size(853, 432);
            this.panelcolection.ResumeLayout(false);
            this.panelcolection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcolection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncolection;
    }
}
