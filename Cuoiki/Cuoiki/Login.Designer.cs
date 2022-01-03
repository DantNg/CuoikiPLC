
namespace Cuoiki
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
            this.gradient1 = new Cuoiki.Gradient();
            this.lbWrong = new System.Windows.Forms.Label();
            this.lbSuccessfully = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btForget = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIntro = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAccountLoginIn = new System.Windows.Forms.Label();
            this.txtBack = new System.Windows.Forms.TextBox();
            this.elipseControl1 = new Cuoiki.ElipseControl();
            this.elipseControl2 = new Cuoiki.ElipseControl();
            this.elipseControl3 = new Cuoiki.ElipseControl();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(78)))), ((int)(((byte)(192)))));
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.lbWrong);
            this.gradient1.Controls.Add(this.lbSuccessfully);
            this.gradient1.Controls.Add(this.pictureBox1);
            this.gradient1.Controls.Add(this.btForget);
            this.gradient1.Controls.Add(this.btSignUp);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.txtPassword);
            this.gradient1.Controls.Add(this.txtUsername);
            this.gradient1.Controls.Add(this.dataGridView2);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.lbIntro);
            this.gradient1.Controls.Add(this.btLogin);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.lbAccountLoginIn);
            this.gradient1.Controls.Add(this.txtBack);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(990, 556);
            this.gradient1.TabIndex = 2;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(87)))), ((int)(((byte)(206)))));
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // lbWrong
            // 
            this.lbWrong.BackColor = System.Drawing.Color.White;
            this.lbWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrong.ForeColor = System.Drawing.Color.Red;
            this.lbWrong.Location = new System.Drawing.Point(626, 421);
            this.lbWrong.Name = "lbWrong";
            this.lbWrong.Size = new System.Drawing.Size(167, 22);
            this.lbWrong.TabIndex = 17;
            this.lbWrong.Text = "Incorrect password !!!";
            this.lbWrong.Visible = false;
            // 
            // lbSuccessfully
            // 
            this.lbSuccessfully.BackColor = System.Drawing.Color.White;
            this.lbSuccessfully.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccessfully.ForeColor = System.Drawing.Color.Lime;
            this.lbSuccessfully.Location = new System.Drawing.Point(618, 421);
            this.lbSuccessfully.Name = "lbSuccessfully";
            this.lbSuccessfully.Size = new System.Drawing.Size(167, 22);
            this.lbSuccessfully.TabIndex = 17;
            this.lbSuccessfully.Text = "Logged in successfully !!!";
            this.lbSuccessfully.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btForget
            // 
            this.btForget.BackColor = System.Drawing.Color.White;
            this.btForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btForget.FlatAppearance.BorderSize = 0;
            this.btForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btForget.Font = new System.Drawing.Font("Script MT Bold", 9.8F);
            this.btForget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            this.btForget.Location = new System.Drawing.Point(688, 447);
            this.btForget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btForget.Name = "btForget";
            this.btForget.Size = new System.Drawing.Size(201, 37);
            this.btForget.TabIndex = 15;
            this.btForget.Text = "Do you forget your password ?";
            this.btForget.UseVisualStyleBackColor = false;
            this.btForget.Click += new System.EventHandler(this.btForget_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.BackColor = System.Drawing.Color.White;
            this.btSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSignUp.FlatAppearance.BorderSize = 0;
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Script MT Bold", 9.8F);
            this.btSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            this.btSignUp.Location = new System.Drawing.Point(503, 446);
            this.btSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(181, 37);
            this.btSignUp.TabIndex = 14;
            this.btSignUp.Text = "Do you have not account ?";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(801, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Show/Hide";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtPassword.Location = new System.Drawing.Point(518, 305);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(356, 21);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged_1);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtUsername.Location = new System.Drawing.Point(518, 224);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(356, 21);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(518, 297);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(356, 37);
            this.dataGridView2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 37);
            this.dataGridView1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(510, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "AUTOMATIC MATERIAL MIXING SYSTEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.BackColor = System.Drawing.Color.White;
            this.lbIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lbIntro.ForeColor = System.Drawing.Color.Blue;
            this.lbIntro.Location = new System.Drawing.Point(510, 72);
            this.lbIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(0, 24);
            this.lbIntro.TabIndex = 6;
            this.lbIntro.Click += new System.EventHandler(this.lbIntro_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(518, 363);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(358, 46);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(516, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(516, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbAccountLoginIn
            // 
            this.lbAccountLoginIn.AutoSize = true;
            this.lbAccountLoginIn.BackColor = System.Drawing.Color.White;
            this.lbAccountLoginIn.Font = new System.Drawing.Font("Siemens Slab", 15.8F, System.Drawing.FontStyle.Bold);
            this.lbAccountLoginIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lbAccountLoginIn.Location = new System.Drawing.Point(513, 128);
            this.lbAccountLoginIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountLoginIn.Name = "lbAccountLoginIn";
            this.lbAccountLoginIn.Size = new System.Drawing.Size(163, 25);
            this.lbAccountLoginIn.TabIndex = 0;
            this.lbAccountLoginIn.Text = "Account Login";
            this.lbAccountLoginIn.Click += new System.EventHandler(this.lbAccountLoginIn_Click);
            // 
            // txtBack
            // 
            this.txtBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBack.Location = new System.Drawing.Point(56, 54);
            this.txtBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBack.Multiline = true;
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(870, 446);
            this.txtBack.TabIndex = 1;
            this.txtBack.TextChanged += new System.EventHandler(this.txtBack_TextChanged);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this.btLogin;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 20;
            this.elipseControl2.TargetControl = this.dataGridView1;
            // 
            // elipseControl3
            // 
            this.elipseControl3.CornerRadius = 20;
            this.elipseControl3.TargetControl = this.dataGridView2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.gradient1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBack;
        private Gradient gradient1;
        private System.Windows.Forms.Label lbAccountLoginIn;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Label label3;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ElipseControl elipseControl2;
        private ElipseControl elipseControl3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.Button btForget;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSuccessfully;
        private System.Windows.Forms.Label lbWrong;
    }
}

