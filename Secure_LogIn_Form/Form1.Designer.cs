namespace Secure_LogIn_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LogIn = new Button();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.BackColor = Color.RosyBrown;
            LogIn.FlatStyle = FlatStyle.Flat;
            LogIn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn.ForeColor = Color.Transparent;
            LogIn.Location = new Point(149, 464);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(278, 84);
            LogIn.TabIndex = 0;
            LogIn.Text = "LogIn";
            LogIn.UseVisualStyleBackColor = false;
            LogIn.Click += LogIn_Click;
            // 
            // usernametxt
            // 
            usernametxt.BorderStyle = BorderStyle.None;
            usernametxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.ForeColor = SystemColors.ControlDarkDark;
            usernametxt.Location = new Point(61, 137);
            usernametxt.Multiline = true;
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(451, 51);
            usernametxt.TabIndex = 1;
            usernametxt.Text = "Username";
            usernametxt.UseSystemPasswordChar = true;
            usernametxt.MouseClick += usernametxt_MouseClick;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // passwordtxt
            // 
            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.ForeColor = SystemColors.ControlDarkDark;
            passwordtxt.Location = new Point(67, 303);
            passwordtxt.Multiline = true;
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(451, 49);
            passwordtxt.TabIndex = 2;
            passwordtxt.Text = "Password";
            passwordtxt.Click += passwordtxt_Click;
            passwordtxt.MouseClick += passwordtxt_MouseClick;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(122, 96);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(121, 262);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id_card;
            pictureBox1.Location = new Point(61, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(61, 242);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(584, 677);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(LogIn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogIn;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
