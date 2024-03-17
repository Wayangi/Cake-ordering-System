
namespace Cakes_by_Rash
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.uC_Remove1 = new Cakes_by_Rash.NewFolder1.UC_Remove();
            this.uC_Udate2 = new Cakes_by_Rash.NewFolder1.UC_Udate();
            this.uc_placeorder1 = new Cakes_by_Rash.NewFolder1.Uc_placeorder();
            this.uC_add1 = new Cakes_by_Rash.NewFolder1.UC_add();
            this.uC_welcome1 = new Cakes_by_Rash.NewFolder1.UC_welcome();
            this.mainMenu1 = new Cakes_by_Rash.NewFolder1.mainMenu();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.mainMenu1);
            this.panel2.Controls.Add(this.uC_Remove1);
            this.panel2.Controls.Add(this.uC_Udate2);
            this.panel2.Controls.Add(this.uc_placeorder1);
            this.panel2.Controls.Add(this.uC_add1);
            this.panel2.Controls.Add(this.uC_welcome1);
            this.panel2.Location = new System.Drawing.Point(232, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnremove);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnplaceorder);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Location = new System.Drawing.Point(31, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(59, 435);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnexit.Location = new System.Drawing.Point(0, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(28, 32);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnremove.Location = new System.Drawing.Point(19, 316);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(202, 41);
            this.btnremove.TabIndex = 5;
            this.btnremove.Text = "Remove Items";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(19, 254);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(202, 41);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update Items";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnplaceorder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplaceorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnplaceorder.Location = new System.Drawing.Point(19, 136);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(202, 41);
            this.btnplaceorder.TabIndex = 3;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.UseVisualStyleBackColor = false;
            this.btnplaceorder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(19, 193);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(202, 41);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Items";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Location = new System.Drawing.Point(19, 75);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(202, 41);
            this.menu.TabIndex = 0;
            this.menu.Text = "Main menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // uC_Remove1
            // 
            this.uC_Remove1.BackColor = System.Drawing.Color.White;
            this.uC_Remove1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Remove1.BackgroundImage")));
            this.uC_Remove1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Remove1.Location = new System.Drawing.Point(0, -4);
            this.uC_Remove1.Name = "uC_Remove1";
            this.uC_Remove1.Size = new System.Drawing.Size(781, 514);
            this.uC_Remove1.TabIndex = 5;
            // 
            // uC_Udate2
            // 
            this.uC_Udate2.BackColor = System.Drawing.Color.Snow;
            this.uC_Udate2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Udate2.BackgroundImage")));
            this.uC_Udate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uC_Udate2.Location = new System.Drawing.Point(-3, -4);
            this.uC_Udate2.Name = "uC_Udate2";
            this.uC_Udate2.Size = new System.Drawing.Size(781, 514);
            this.uC_Udate2.TabIndex = 4;
            // 
            // uc_placeorder1
            // 
            this.uc_placeorder1.BackColor = System.Drawing.Color.White;
            this.uc_placeorder1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_placeorder1.BackgroundImage")));
            this.uc_placeorder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_placeorder1.Location = new System.Drawing.Point(1, 0);
            this.uc_placeorder1.Name = "uc_placeorder1";
            this.uc_placeorder1.Size = new System.Drawing.Size(780, 514);
            this.uc_placeorder1.TabIndex = 2;
            // 
            // uC_add1
            // 
            this.uC_add1.Location = new System.Drawing.Point(2, 0);
            this.uC_add1.Name = "uC_add1";
            this.uC_add1.Size = new System.Drawing.Size(779, 512);
            this.uC_add1.TabIndex = 1;
            // 
            // uC_welcome1
            // 
            this.uC_welcome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_welcome1.BackgroundImage")));
            this.uC_welcome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_welcome1.Location = new System.Drawing.Point(1, -1);
            this.uC_welcome1.Name = "uC_welcome1";
            this.uC_welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_welcome1.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(781, 514);
            this.mainMenu1.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1040, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private NewFolder1.UC_welcome uC_welcome1;
        private NewFolder1.UC_add uC_add1;
        private NewFolder1.Uc_placeorder uc_placeorder1;
        private NewFolder1.UC_Udate uC_Udate2;
        private NewFolder1.UC_Remove uC_Remove1;
        private NewFolder1.mainMenu mainMenu1;
    }
}