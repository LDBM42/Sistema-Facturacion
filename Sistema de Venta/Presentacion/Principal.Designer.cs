namespace Sistema_de_Venta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÚToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÚToolStripMenuItem,
            this.cONFIGURACIONESToolStripMenuItem,
            this.cERRARToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÚToolStripMenuItem
            // 
            this.mENÚToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.vENTASToolStripMenuItem,
            this.cATEGORIAToolStripMenuItem});
            this.mENÚToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENÚToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.Menu_Icon_PNG_Graphic_Cave;
            this.mENÚToolStripMenuItem.Name = "mENÚToolStripMenuItem";
            this.mENÚToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.mENÚToolStripMenuItem.Text = "MENÚ";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.new_add_user_16734;
            this.cLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.box;
            this.pRODUCTOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click);
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vENTASToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.cart_png_pic_png_image_512;
            this.vENTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            this.vENTASToolStripMenuItem.Click += new System.EventHandler(this.vENTASToolStripMenuItem_Click);
            // 
            // cATEGORIAToolStripMenuItem
            // 
            this.cATEGORIAToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.Documents_icon;
            this.cATEGORIAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            this.cATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.cATEGORIAToolStripMenuItem.Text = "CATEGORIAS";
            this.cATEGORIAToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIAToolStripMenuItem_Click);
            // 
            // cONFIGURACIONESToolStripMenuItem
            // 
            this.cONFIGURACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.cONFIGURACIONESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cONFIGURACIONESToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.Settings_icon;
            this.cONFIGURACIONESToolStripMenuItem.Name = "cONFIGURACIONESToolStripMenuItem";
            this.cONFIGURACIONESToolStripMenuItem.Size = new System.Drawing.Size(226, 29);
            this.cONFIGURACIONESToolStripMenuItem.Text = "CONFIGURACIONES";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // cERRARToolStripMenuItem
            // 
            this.cERRARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cERRARToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.Logout_37127;
            this.cERRARToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cERRARToolStripMenuItem.Name = "cERRARToolStripMenuItem";
            this.cERRARToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.cERRARToolStripMenuItem.Text = "CERRAR SESION";
            this.cERRARToolStripMenuItem.Click += new System.EventHandler(this.cERRARToolStripMenuItem_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aYUDAToolStripMenuItem.Image = global::Sistema_de_Venta.Properties.Resources.Help_icon;
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            this.aYUDAToolStripMenuItem.Click += new System.EventHandler(this.aYUDAToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 404);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE VENTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENÚToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;

    }
}

