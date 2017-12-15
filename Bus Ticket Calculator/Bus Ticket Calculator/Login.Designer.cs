namespace Bus_Ticket_Calculator
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.PW_text = new System.Windows.Forms.TextBox();
            this.Login_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(40, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 109;
            this.label5.Text = "PASSWORD:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(40, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "USERNAME:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ID_text
            // 
            this.ID_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ID_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ID_text.Location = new System.Drawing.Point(172, 193);
            this.ID_text.MaxLength = 5;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(208, 31);
            this.ID_text.TabIndex = 107;
            this.ID_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_text_KeyDown);
            // 
            // PW_text
            // 
            this.PW_text.AccessibleDescription = "";
            this.PW_text.AccessibleName = "";
            this.PW_text.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.PW_text.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PW_text.Location = new System.Drawing.Point(172, 234);
            this.PW_text.MaxLength = 6;
            this.PW_text.Name = "PW_text";
            this.PW_text.PasswordChar = '*';
            this.PW_text.Size = new System.Drawing.Size(208, 30);
            this.PW_text.TabIndex = 106;
            this.PW_text.Tag = "";
            this.PW_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PW_text.TextChanged += new System.EventHandler(this.PW_text_TextChanged);
            this.PW_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PW_text_KeyDown);
            // 
            // Login_bt
            // 
            this.Login_bt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Login_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Login_bt.Image = ((System.Drawing.Image)(resources.GetObject("Login_bt.Image")));
            this.Login_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login_bt.Location = new System.Drawing.Point(251, 308);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(82, 49);
            this.Login_bt.TabIndex = 104;
            this.Login_bt.Text = "Login";
            this.Login_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_bt.UseVisualStyleBackColor = false;
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "กรุณาLoginเข้าสู่ระบบ ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "คำนวนตั๋วโดยสารรถประจำทาง";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 101;
            this.label1.Text = "ยินดีต้อนรับเข้าสู่โปรแกรม";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BottonExit
            // 
            this.BottonExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BottonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BottonExit.Image = ((System.Drawing.Image)(resources.GetObject("BottonExit.Image")));
            this.BottonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BottonExit.Location = new System.Drawing.Point(99, 308);
            this.BottonExit.Name = "BottonExit";
            this.BottonExit.Size = new System.Drawing.Size(79, 49);
            this.BottonExit.TabIndex = 111;
            this.BottonExit.Text = "Exit";
            this.BottonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BottonExit.UseVisualStyleBackColor = false;
            this.BottonExit.Click += new System.EventHandler(this.BottonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 405);
            this.Controls.Add(this.BottonExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.PW_text);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Login-Bus Ticket Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.TextBox PW_text;
        private System.Windows.Forms.Button Login_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BottonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

