namespace WindowsFormsControlLibrary1
{
    partial class MytwetControl
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
            this.pnlTrain = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnriset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlTrain.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTrain
            // 
            this.pnlTrain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlTrain.Controls.Add(this.panel11);
            this.pnlTrain.Controls.Add(this.panel10);
            this.pnlTrain.Controls.Add(this.panel3);
            this.pnlTrain.Controls.Add(this.panel9);
            this.pnlTrain.Location = new System.Drawing.Point(3, -28);
            this.pnlTrain.Name = "pnlTrain";
            this.pnlTrain.Size = new System.Drawing.Size(688, 333);
            this.pnlTrain.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.btnriset);
            this.panel11.Location = new System.Drawing.Point(524, 83);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(147, 147);
            this.panel11.TabIndex = 2;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Riset";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.btnsave);
            this.panel10.Location = new System.Drawing.Point(356, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(147, 147);
            this.panel10.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Save";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnTrain);
            this.panel3.Location = new System.Drawing.Point(189, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 147);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Train";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.btnLoad);
            this.panel9.Location = new System.Drawing.Point(19, 83);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(147, 147);
            this.panel9.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Load";
            // 
            // btnriset
            // 
            this.btnriset.BackColor = System.Drawing.SystemColors.Control;
            this.btnriset.BackgroundImage = global::WindowsFormsControlLibrary1.Properties.Resources.riset;
            this.btnriset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnriset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnriset.FlatAppearance.BorderSize = 0;
            this.btnriset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnriset.Location = new System.Drawing.Point(14, 36);
            this.btnriset.Name = "btnriset";
            this.btnriset.Size = new System.Drawing.Size(121, 102);
            this.btnriset.TabIndex = 0;
            this.btnriset.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.BackgroundImage = global::WindowsFormsControlLibrary1.Properties.Resources.omg_removebg_preview;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(14, 36);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 102);
            this.btnsave.TabIndex = 0;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrain.BackgroundImage = global::WindowsFormsControlLibrary1.Properties.Resources.dance3;
            this.btnTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnTrain.FlatAppearance.BorderSize = 0;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Location = new System.Drawing.Point(14, 36);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(121, 102);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.BackgroundImage = global::WindowsFormsControlLibrary1.Properties.Resources.data_transfer;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(14, 36);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 102);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MytwetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTrain);
            this.Name = "MytwetControl";
            this.Size = new System.Drawing.Size(817, 423);
            this.pnlTrain.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrain;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnriset;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
    }
}
