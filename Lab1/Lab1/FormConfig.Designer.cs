namespace Lab1
{
    partial class FormConfig
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
            this.pictureBoxfighter = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFighter = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelMaroon = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfighter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxfighter
            // 
            this.pictureBoxfighter.Location = new System.Drawing.Point(20, 21);
            this.pictureBoxfighter.Name = "pictureBoxfighter";
            this.pictureBoxfighter.Size = new System.Drawing.Size(251, 177);
            this.pictureBoxfighter.TabIndex = 0;
            this.pictureBoxfighter.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFighter);
            this.groupBox1.Controls.Add(this.labelPlane);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // labelFighter
            // 
            this.labelFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFighter.Location = new System.Drawing.Point(30, 107);
            this.labelFighter.Name = "labelFighter";
            this.labelFighter.Size = new System.Drawing.Size(136, 58);
            this.labelFighter.TabIndex = 3;
            this.labelFighter.Text = "Fighter";
            this.labelFighter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFighter_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(30, 31);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(136, 58);
            this.labelPlane.TabIndex = 2;
            this.labelPlane.Text = "Plane";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.labelDopColor);
            this.panel1.Controls.Add(this.labelBaseColor);
            this.panel1.Controls.Add(this.pictureBoxfighter);
            this.panel1.Location = new System.Drawing.Point(232, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 366);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(71, 230);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(139, 58);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Main color";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(71, 299);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(139, 58);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Dop color";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelFuchsia);
            this.groupBox2.Controls.Add(this.panelMaroon);
            this.groupBox2.Controls.Add(this.panelOrange);
            this.groupBox2.Controls.Add(this.panelLime);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(596, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 331);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(28, 39);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(60, 60);
            this.panelBlack.TabIndex = 0;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(94, 39);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(60, 60);
            this.panelGray.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(28, 105);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(60, 60);
            this.panelBlue.TabIndex = 2;
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(94, 105);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(60, 60);
            this.panelLime.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(94, 237);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(60, 60);
            this.panelYellow.TabIndex = 7;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(28, 237);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(60, 60);
            this.panelFuchsia.TabIndex = 6;
            // 
            // panelMaroon
            // 
            this.panelMaroon.BackColor = System.Drawing.Color.Maroon;
            this.panelMaroon.Location = new System.Drawing.Point(94, 171);
            this.panelMaroon.Name = "panelMaroon";
            this.panelMaroon.Size = new System.Drawing.Size(60, 60);
            this.panelMaroon.TabIndex = 5;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.OrangeRed;
            this.panelOrange.Location = new System.Drawing.Point(28, 171);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(60, 60);
            this.panelOrange.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(42, 234);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(42, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 39);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 447);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfighter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxfighter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFighter;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelMaroon;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}