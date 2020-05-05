namespace dotnetprojet
{
    partial class SpouseName
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
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpouseName));
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spouseJobTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.spouseNametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.spouseschedule = new System.Windows.Forms.TextBox();
            bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel6
            // 
            bunifuCustomLabel6.AutoSize = true;
            bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel6.ForeColor = System.Drawing.Color.Teal;
            bunifuCustomLabel6.Location = new System.Drawing.Point(23, 209);
            bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            bunifuCustomLabel6.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel6.TabIndex = 43;
            bunifuCustomLabel6.Text = "Schedule of the day:";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(814, 32);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 30;
            this.next.TabStop = false;
            this.next.Zoom = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.spouseschedule);
            this.panel1.Controls.Add(this.spouseJobTxt);
            this.panel1.Controls.Add(this.spouseNametxt);
            this.panel1.Controls.Add(bunifuCustomLabel6);
            this.panel1.Location = new System.Drawing.Point(249, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 14;
            // 
            // spouseJobTxt
            // 
            this.spouseJobTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spouseJobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.spouseJobTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.HintText = "Job";
            this.spouseJobTxt.isPassword = false;
            this.spouseJobTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.LineThickness = 3;
            this.spouseJobTxt.Location = new System.Drawing.Point(23, 144);
            this.spouseJobTxt.Margin = new System.Windows.Forms.Padding(4);
            this.spouseJobTxt.Name = "spouseJobTxt";
            this.spouseJobTxt.Size = new System.Drawing.Size(318, 44);
            this.spouseJobTxt.TabIndex = 46;
            this.spouseJobTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // spouseNametxt
            // 
            this.spouseNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spouseNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.spouseNametxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.HintText = "Partner Name";
            this.spouseNametxt.isPassword = false;
            this.spouseNametxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.LineThickness = 3;
            this.spouseNametxt.Location = new System.Drawing.Point(23, 63);
            this.spouseNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.spouseNametxt.Name = "spouseNametxt";
            this.spouseNametxt.Size = new System.Drawing.Size(318, 44);
            this.spouseNametxt.TabIndex = 45;
            this.spouseNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pred
            // 
            this.pred.BackColor = System.Drawing.Color.Transparent;
            this.pred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pred.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.pred.ImageActive = null;
            this.pred.Location = new System.Drawing.Point(55, 32);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 32;
            this.pred.TabStop = false;
            this.pred.Zoom = 10;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // spouseschedule
            // 
            this.spouseschedule.Location = new System.Drawing.Point(47, 249);
            this.spouseschedule.Multiline = true;
            this.spouseschedule.Name = "spouseschedule";
            this.spouseschedule.Size = new System.Drawing.Size(262, 116);
            this.spouseschedule.TabIndex = 47;
            // 
            // SpouseName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpouseName";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private Bunifu.Framework.UI.BunifuMaterialTextbox spouseJobTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox spouseNametxt;
        private System.Windows.Forms.TextBox spouseschedule;
    }
}