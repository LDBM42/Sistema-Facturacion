namespace Sistema_de_Venta.Presentacion
{
    partial class FRM_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.text_Usuario = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbl_CountDown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Azul = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tmr_cuadroAzul = new System.Windows.Forms.Timer(this.components);
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pnl_Azul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Usuario
            // 
            this.text_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.text_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.text_Usuario.Location = new System.Drawing.Point(310, 97);
            this.text_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.text_Usuario.Name = "text_Usuario";
            this.text_Usuario.Size = new System.Drawing.Size(408, 28);
            this.text_Usuario.TabIndex = 1;
            this.text_Usuario.Text = "USUARIO";
            this.text_Usuario.Click += new System.EventHandler(this.text_Usuario_Click);
            this.text_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Usuario_KeyPress);
            this.text_Usuario.MouseEnter += new System.EventHandler(this.text_Usuario_MouseEnter);
            this.text_Usuario.MouseLeave += new System.EventHandler(this.text_Usuario_MouseLeave);
            // 
            // text_Password
            // 
            this.text_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.text_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_Password.ForeColor = System.Drawing.Color.DimGray;
            this.text_Password.Location = new System.Drawing.Point(310, 163);
            this.text_Password.Margin = new System.Windows.Forms.Padding(4);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(408, 28);
            this.text_Password.TabIndex = 2;
            this.text_Password.Text = "PASSWORD";
            this.text_Password.Click += new System.EventHandler(this.text_Password_Click);
            this.text_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Password_KeyPress);
            this.text_Password.MouseEnter += new System.EventHandler(this.text_Password_MouseEnter);
            this.text_Password.MouseLeave += new System.EventHandler(this.text_Password_MouseLeave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEntrar.Location = new System.Drawing.Point(310, 244);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(408, 40);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbl_CountDown
            // 
            this.lbl_CountDown.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountDown.Location = new System.Drawing.Point(13, 23);
            this.lbl_CountDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CountDown.Name = "lbl_CountDown";
            this.lbl_CountDown.Size = new System.Drawing.Size(68, 41);
            this.lbl_CountDown.TabIndex = 2;
            this.lbl_CountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CountDown.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_Azul
            // 
            this.pnl_Azul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(117)))));
            this.pnl_Azul.Controls.Add(this.lbl_CountDown);
            this.pnl_Azul.Controls.Add(this.pbx_logo);
            this.pnl_Azul.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Azul.Location = new System.Drawing.Point(0, 0);
            this.pnl_Azul.Name = "pnl_Azul";
            this.pnl_Azul.Size = new System.Drawing.Size(525, 330);
            this.pnl_Azul.TabIndex = 4;
            this.pnl_Azul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Login.Location = new System.Drawing.Point(453, 9);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(143, 46);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "LOGIN";
            // 
            // tmr_cuadroAzul
            // 
            this.tmr_cuadroAzul.Interval = 30;
            this.tmr_cuadroAzul.Tick += new System.EventHandler(this.tmr_cuadroAzul_Tick);
            // 
            // pbx_logo
            // 
            this.pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_logo.Image = global::Sistema_de_Venta.Properties.Resources.ISOTIPO_MEF_srl;
            this.pbx_logo.Location = new System.Drawing.Point(368, 93);
            this.pbx_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(168, 145);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 0;
            this.pbx_logo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Sistema_de_Venta.Properties.Resources.close_gray1;
            this.btnClose.Location = new System.Drawing.Point(748, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::Sistema_de_Venta.Properties.Resources.minimize_gray1;
            this.btnMinimize.Location = new System.Drawing.Point(722, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.pnl_Azul);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.text_Usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_Login_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Login_MouseDown);
            this.pnl_Azul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.TextBox text_Usuario;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.Label lbl_CountDown;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_Azul;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Timer tmr_cuadroAzul;
    }
}