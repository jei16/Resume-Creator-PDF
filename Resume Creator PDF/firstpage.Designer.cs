namespace Resume_Creator_PDF
{
    partial class firstpage
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
            this.label2 = new System.Windows.Forms.Label();
            this.GeneratePDFbtn = new System.Windows.Forms.Button();
            this.ChooseFilebtn = new System.Windows.Forms.Button();
            this.ChooseFiletxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converts JSON File to PDF File";
            // 
            // GeneratePDFbtn
            // 
            this.GeneratePDFbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GeneratePDFbtn.Location = new System.Drawing.Point(211, 210);
            this.GeneratePDFbtn.Name = "GeneratePDFbtn";
            this.GeneratePDFbtn.Size = new System.Drawing.Size(105, 40);
            this.GeneratePDFbtn.TabIndex = 2;
            this.GeneratePDFbtn.Text = "Generate to PDF";
            this.GeneratePDFbtn.UseVisualStyleBackColor = false;
            this.GeneratePDFbtn.Visible = false;
            this.GeneratePDFbtn.Click += new System.EventHandler(this.GeneratePDFbtn_Click);
            // 
            // ChooseFilebtn
            // 
            this.ChooseFilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFilebtn.Location = new System.Drawing.Point(42, 115);
            this.ChooseFilebtn.Name = "ChooseFilebtn";
            this.ChooseFilebtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseFilebtn.TabIndex = 3;
            this.ChooseFilebtn.Text = "Choose File";
            this.ChooseFilebtn.UseVisualStyleBackColor = true;
            this.ChooseFilebtn.Click += new System.EventHandler(this.ChooseFilebtn_Click);
            // 
            // ChooseFiletxt
            // 
            this.ChooseFiletxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChooseFiletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFiletxt.Location = new System.Drawing.Point(128, 115);
            this.ChooseFiletxt.Name = "ChooseFiletxt";
            this.ChooseFiletxt.ReadOnly = true;
            this.ChooseFiletxt.Size = new System.Drawing.Size(343, 22);
            this.ChooseFiletxt.TabIndex = 4;
            this.ChooseFiletxt.TextChanged += new System.EventHandler(this.ChooseFiletxt_TextChanged);
            // 
            // firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(541, 284);
            this.Controls.Add(this.ChooseFiletxt);
            this.Controls.Add(this.ChooseFilebtn);
            this.Controls.Add(this.GeneratePDFbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "firstpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Generator";
            this.Load += new System.EventHandler(this.firstpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeneratePDFbtn;
        private System.Windows.Forms.Button ChooseFilebtn;
        private System.Windows.Forms.TextBox ChooseFiletxt;
    }
}

