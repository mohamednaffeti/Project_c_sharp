﻿namespace dotnetprojet
{
    partial class ChildrenForm
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
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildrenForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.childrenschedule = new System.Windows.Forms.TextBox();
            this.schoolDistanceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.degreeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.childrenNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            bunifuCustomLabel2.AutoSize = true;
            bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            bunifuCustomLabel2.Location = new System.Drawing.Point(55, 261);
            bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            bunifuCustomLabel2.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel2.TabIndex = 30;
            bunifuCustomLabel2.Text = "Schedule of the day:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.childrenschedule);
            this.panel1.Controls.Add(this.schoolDistanceTxt);
            this.panel1.Controls.Add(this.degreeTxt);
            this.panel1.Controls.Add(this.childrenNameTxt);
            this.panel1.Controls.Add(bunifuCustomLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(268, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // childrenschedule
            // 
            this.childrenschedule.Location = new System.Drawing.Point(43, 279);
            this.childrenschedule.Multiline = true;
            this.childrenschedule.Name = "childrenschedule";
            this.childrenschedule.Size = new System.Drawing.Size(262, 116);
            this.childrenschedule.TabIndex = 47;
            // 
            // schoolDistanceTxt
            // 
            this.schoolDistanceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.schoolDistanceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.schoolDistanceTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.HintText = "School distance/Job distance";
            this.schoolDistanceTxt.isPassword = false;
            this.schoolDistanceTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.LineThickness = 3;
            this.schoolDistanceTxt.Location = new System.Drawing.Point(16, 172);
            this.schoolDistanceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.schoolDistanceTxt.Name = "schoolDistanceTxt";
            this.schoolDistanceTxt.Size = new System.Drawing.Size(322, 44);
            this.schoolDistanceTxt.TabIndex = 46;
            this.schoolDistanceTxt.Text = "School distance";
            this.schoolDistanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // degreeTxt
            // 
            this.degreeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.degreeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.degreeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.degreeTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.HintText = "Degree/Job";
            this.degreeTxt.isPassword = false;
            this.degreeTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.LineThickness = 3;
            this.degreeTxt.Location = new System.Drawing.Point(16, 109);
            this.degreeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.degreeTxt.Name = "degreeTxt";
            this.degreeTxt.Size = new System.Drawing.Size(322, 44);
            this.degreeTxt.TabIndex = 45;
            this.degreeTxt.Text = "Degree";
            this.degreeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // childrenNameTxt
            // 
            this.childrenNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.childrenNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.childrenNameTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.HintText = "Child Name";
            this.childrenNameTxt.isPassword = false;
            this.childrenNameTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.LineThickness = 3;
            this.childrenNameTxt.Location = new System.Drawing.Point(16, 46);
            this.childrenNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.childrenNameTxt.Name = "childrenNameTxt";
            this.childrenNameTxt.Size = new System.Drawing.Size(322, 44);
            this.childrenNameTxt.TabIndex = 44;
            this.childrenNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // pred
            // 
            this.pred.BackColor = System.Drawing.Color.Transparent;
            this.pred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pred.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.pred.ImageActive = null;
            this.pred.Location = new System.Drawing.Point(29, 62);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 34;
            this.pred.TabStop = false;
            this.pred.Zoom = 10;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(828, 62);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 33;
            this.next.TabStop = false;
            this.next.Zoom = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // ChildrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildrenForm";
            this.Text = "ChildrenForm";
            this.Load += new System.EventHandler(this.ChildrenForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox schoolDistanceTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox degreeTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox childrenNameTxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private System.Windows.Forms.TextBox childrenschedule;
    }
}