namespace TruceCaller
{
    partial class frm_TrueCaller
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
            this.btn_Sign_IN = new System.Windows.Forms.Button();
            this.btn_Crawl = new System.Windows.Forms.Button();
            this.lbl_Check = new System.Windows.Forms.Label();
            this.oFD_Select = new System.Windows.Forms.OpenFileDialog();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Sign_OUT = new System.Windows.Forms.Button();
            this.txtBox_Number = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loboloba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sign_IN
            // 
            this.btn_Sign_IN.Location = new System.Drawing.Point(377, 100);
            this.btn_Sign_IN.Name = "btn_Sign_IN";
            this.btn_Sign_IN.Size = new System.Drawing.Size(145, 29);
            this.btn_Sign_IN.TabIndex = 0;
            this.btn_Sign_IN.Text = "Sign In";
            this.btn_Sign_IN.UseVisualStyleBackColor = true;
            this.btn_Sign_IN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Crawl
            // 
            this.btn_Crawl.Location = new System.Drawing.Point(1088, 82);
            this.btn_Crawl.Name = "btn_Crawl";
            this.btn_Crawl.Size = new System.Drawing.Size(168, 60);
            this.btn_Crawl.TabIndex = 5;
            this.btn_Crawl.Text = "Search";
            this.btn_Crawl.UseVisualStyleBackColor = true;
            this.btn_Crawl.Click += new System.EventHandler(this.btn_Crawl_Click);
            // 
            // lbl_Check
            // 
            this.lbl_Check.AutoSize = true;
            this.lbl_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Check.Location = new System.Drawing.Point(12, 106);
            this.lbl_Check.Name = "lbl_Check";
            this.lbl_Check.Size = new System.Drawing.Size(92, 31);
            this.lbl_Check.TabIndex = 2;
            this.lbl_Check.Text = "Check";
            this.lbl_Check.Click += new System.EventHandler(this.lbl_Check_Click);
            // 
            // oFD_Select
            // 
            this.oFD_Select.FileName = "input";
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(18, 212);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(222, 67);
            this.btn_Open.TabIndex = 3;
            this.btn_Open.Text = "Open File &Crawl";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Sign_OUT
            // 
            this.btn_Sign_OUT.Location = new System.Drawing.Point(377, 140);
            this.btn_Sign_OUT.Name = "btn_Sign_OUT";
            this.btn_Sign_OUT.Size = new System.Drawing.Size(145, 29);
            this.btn_Sign_OUT.TabIndex = 8;
            this.btn_Sign_OUT.Text = "Sign Out";
            this.btn_Sign_OUT.UseVisualStyleBackColor = true;
            this.btn_Sign_OUT.Click += new System.EventHandler(this.btn_UnA_Click);
            // 
            // txtBox_Number
            // 
            this.txtBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Number.Location = new System.Drawing.Point(930, 12);
            this.txtBox_Number.Name = "txtBox_Number";
            this.txtBox_Number.Size = new System.Drawing.Size(326, 40);
            this.txtBox_Number.TabIndex = 4;
            this.txtBox_Number.CursorChanged += new System.EventHandler(this.txtBox_Number_CursorChanged);
            this.txtBox_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Number_KeyPress);
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Pass.Location = new System.Drawing.Point(150, 56);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.Size = new System.Drawing.Size(372, 38);
            this.txtBox_Pass.TabIndex = 2;
            this.txtBox_Pass.UseSystemPasswordChar = true;
            // 
            // txtBox_User
            // 
            this.txtBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_User.Location = new System.Drawing.Point(150, 9);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(372, 38);
            this.txtBox_User.TabIndex = 1;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mail.Location = new System.Drawing.Point(12, 16);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(84, 31);
            this.lbl_Mail.TabIndex = 8;
            this.lbl_Mail.Text = "Gmail";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(10, 59);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(134, 31);
            this.lbl_Pass.TabIndex = 9;
            this.lbl_Pass.Text = "Password";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.Location = new System.Drawing.Point(15, 156);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(340, 13);
            this.lbl_Note.TabIndex = 10;
            this.lbl_Note.Text = "Please Note That The account should be truecaller signed up account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number";
            // 
            // Loboloba
            // 
            this.Loboloba.AutoSize = true;
            this.Loboloba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loboloba.Location = new System.Drawing.Point(634, 138);
            this.Loboloba.Name = "Loboloba";
            this.Loboloba.Size = new System.Drawing.Size(29, 24);
            this.Loboloba.TabIndex = 12;
            this.Loboloba.Text = "lbl";
            // 
            // frm_TrueCaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 467);
            this.Controls.Add(this.Loboloba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_Number);
            this.Controls.Add(this.btn_Sign_OUT);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.lbl_Check);
            this.Controls.Add(this.btn_Crawl);
            this.Controls.Add(this.btn_Sign_IN);
            this.Name = "frm_TrueCaller";
            this.Text = "TrueCaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sign_IN;
        private System.Windows.Forms.Button btn_Crawl;
        private System.Windows.Forms.Label lbl_Check;
        private System.Windows.Forms.OpenFileDialog oFD_Select;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Sign_OUT;
        private System.Windows.Forms.TextBox txtBox_Number;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Loboloba;
    }
}

