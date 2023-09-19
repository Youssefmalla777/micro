namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnshowallimages = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.picperson = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picperson)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtnumber
            // 
            this.txtnumber.AllowDrop = true;
            this.txtnumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumber.Location = new System.Drawing.Point(511, 287);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(282, 24);
            this.txtnumber.TabIndex = 30;
            this.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtnumber, "enter your number");
            // 
            // txtaddress
            // 
            this.txtaddress.AllowDrop = true;
            this.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtaddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Location = new System.Drawing.Point(511, 227);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(282, 24);
            this.txtaddress.TabIndex = 22;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtaddress, "enter the address");
            // 
            // txtname
            // 
            this.txtname.AllowDrop = true;
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(511, 172);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(282, 24);
            this.txtname.TabIndex = 21;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtname, "enter the name");
            // 
            // txtid
            // 
            this.txtid.AllowDrop = true;
            this.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(511, 109);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(282, 24);
            this.txtid.TabIndex = 20;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtid, "enter the id");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnumber);
            this.panel1.Controls.Add(this.btnshowallimages);
            this.panel1.Controls.Add(this.btnselect);
            this.panel1.Controls.Add(this.picperson);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnshowall);
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 420);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "your number:";
            // 
            // btnshowallimages
            // 
            this.btnshowallimages.BackColor = System.Drawing.Color.Gainsboro;
            this.btnshowallimages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowallimages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowallimages.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowallimages.Location = new System.Drawing.Point(643, 372);
            this.btnshowallimages.Name = "btnshowallimages";
            this.btnshowallimages.Size = new System.Drawing.Size(553, 35);
            this.btnshowallimages.TabIndex = 29;
            this.btnshowallimages.Text = "show all data with images";
            this.btnshowallimages.UseVisualStyleBackColor = false;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Gainsboro;
            this.btnselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselect.Location = new System.Drawing.Point(1032, 322);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(164, 32);
            this.btnselect.TabIndex = 28;
            this.btnselect.Text = "select photo";
            this.btnselect.UseVisualStyleBackColor = false;
            // 
            // picperson
            // 
            this.picperson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picperson.Location = new System.Drawing.Point(1005, 34);
            this.picperson.Name = "picperson";
            this.picperson.Size = new System.Drawing.Size(217, 265);
            this.picperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picperson.TabIndex = 27;
            this.picperson.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(843, 322);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(117, 32);
            this.btnexit.TabIndex = 26;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.Color.Gainsboro;
            this.btnshowall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowall.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.Location = new System.Drawing.Point(605, 322);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(117, 32);
            this.btnshowall.TabIndex = 25;
            this.btnshowall.Text = "show all";
            this.btnshowall.UseVisualStyleBackColor = false;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Gainsboro;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfind.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(362, 322);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(117, 32);
            this.btnfind.TabIndex = 24;
            this.btnfind.Text = "find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(140, 322);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 32);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "the name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "the id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "the personality data";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(140, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 420);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "the person data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picperson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btnshowallimages;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.PictureBox picperson;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}

