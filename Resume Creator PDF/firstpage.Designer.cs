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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JSONinput = new System.Windows.Forms.RichTextBox();
            this.NameOutput = new System.Windows.Forms.TextBox();
            this.AddressOutput = new System.Windows.Forms.TextBox();
            this.ContactNoOutput = new System.Windows.Forms.TextBox();
            this.EmailOutput = new System.Windows.Forms.TextBox();
            this.ObjectiveOutput = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 58);
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
            this.label2.Location = new System.Drawing.Point(81, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert JSON File to PDF File";
            // 
            // GeneratePDFbtn
            // 
            this.GeneratePDFbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GeneratePDFbtn.Location = new System.Drawing.Point(204, 24);
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
            this.ChooseFilebtn.Location = new System.Drawing.Point(49, 88);
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
            this.ChooseFiletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFiletxt.Location = new System.Drawing.Point(135, 89);
            this.ChooseFiletxt.Name = "ChooseFiletxt";
            this.ChooseFiletxt.ReadOnly = true;
            this.ChooseFiletxt.Size = new System.Drawing.Size(343, 20);
            this.ChooseFiletxt.TabIndex = 4;
            this.ChooseFiletxt.TextChanged += new System.EventHandler(this.ChooseFiletxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.GeneratePDFbtn);
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 93);
            this.panel1.TabIndex = 6;
            // 
            // JSONinput
            // 
            this.JSONinput.Location = new System.Drawing.Point(261, 375);
            this.JSONinput.Name = "JSONinput";
            this.JSONinput.Size = new System.Drawing.Size(97, 77);
            this.JSONinput.TabIndex = 7;
            this.JSONinput.Text = "";
            // 
            // NameOutput
            // 
            this.NameOutput.Location = new System.Drawing.Point(261, 469);
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(100, 20);
            this.NameOutput.TabIndex = 8;
            // 
            // AddressOutput
            // 
            this.AddressOutput.Location = new System.Drawing.Point(261, 495);
            this.AddressOutput.Name = "AddressOutput";
            this.AddressOutput.Size = new System.Drawing.Size(100, 20);
            this.AddressOutput.TabIndex = 9;
            // 
            // ContactNoOutput
            // 
            this.ContactNoOutput.Location = new System.Drawing.Point(261, 521);
            this.ContactNoOutput.Name = "ContactNoOutput";
            this.ContactNoOutput.Size = new System.Drawing.Size(100, 20);
            this.ContactNoOutput.TabIndex = 10;
            // 
            // EmailOutput
            // 
            this.EmailOutput.Location = new System.Drawing.Point(261, 547);
            this.EmailOutput.Name = "EmailOutput";
            this.EmailOutput.Size = new System.Drawing.Size(100, 20);
            this.EmailOutput.TabIndex = 11;
            // 
            // ObjectiveOutput
            // 
            this.ObjectiveOutput.Location = new System.Drawing.Point(261, 573);
            this.ObjectiveOutput.Name = "ObjectiveOutput";
            this.ObjectiveOutput.Size = new System.Drawing.Size(100, 20);
            this.ObjectiveOutput.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 580);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(598, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(498, 477);
            this.Output.TabIndex = 14;
            this.Output.Text = "";
            // 
            // firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(541, 156);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ObjectiveOutput);
            this.Controls.Add(this.EmailOutput);
            this.Controls.Add(this.ContactNoOutput);
            this.Controls.Add(this.AddressOutput);
            this.Controls.Add(this.NameOutput);
            this.Controls.Add(this.JSONinput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChooseFiletxt);
            this.Controls.Add(this.ChooseFilebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "firstpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Generator";
            this.Load += new System.EventHandler(this.firstpage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeneratePDFbtn;
        private System.Windows.Forms.Button ChooseFilebtn;
        private System.Windows.Forms.TextBox ChooseFiletxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox JSONinput;
        private System.Windows.Forms.TextBox NameOutput;
        private System.Windows.Forms.TextBox AddressOutput;
        private System.Windows.Forms.TextBox ContactNoOutput;
        private System.Windows.Forms.TextBox EmailOutput;
        private System.Windows.Forms.TextBox ObjectiveOutput;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RichTextBox Output;
    }
}

