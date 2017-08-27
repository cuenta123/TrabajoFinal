namespace Pizzeria
{
    partial class Addpizza
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
            this.nombreText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.previewImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.Button();
            this.IngredientsText = new System.Windows.Forms.ListBox();
            this.btnrigth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(15, 38);
            this.nombreText.Margin = new System.Windows.Forms.Padding(4);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(296, 22);
            this.nombreText.TabIndex = 0;
            this.nombreText.Tag = "";
            this.nombreText.Text = "Nombre: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "mozarrella",
            "peperoni",
            "jamon",
            "bacon",
            "pimiento",
            "berenjena"});
            this.comboBox1.Location = new System.Drawing.Point(15, 82);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // previewImage
            // 
            this.previewImage.Location = new System.Drawing.Point(13, 127);
            this.previewImage.Margin = new System.Windows.Forms.Padding(4);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(111, 28);
            this.previewImage.TabIndex = 2;
            this.previewImage.Text = "Subir imagen";
            this.previewImage.UseVisualStyleBackColor = true;
            this.previewImage.Click += new System.EventHandler(this.previewImages);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Preview";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(12, 359);
            this.guardar.Margin = new System.Windows.Forms.Padding(4);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(111, 28);
            this.guardar.TabIndex = 4;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // IngredientsText
            // 
            this.IngredientsText.FormattingEnabled = true;
            this.IngredientsText.ItemHeight = 16;
            this.IngredientsText.Location = new System.Drawing.Point(356, 38);
            this.IngredientsText.Margin = new System.Windows.Forms.Padding(4);
            this.IngredientsText.Name = "IngredientsText";
            this.IngredientsText.Size = new System.Drawing.Size(159, 116);
            this.IngredientsText.TabIndex = 5;
            // 
            // btnrigth
            // 
            this.btnrigth.Location = new System.Drawing.Point(257, 82);
            this.btnrigth.Margin = new System.Windows.Forms.Padding(4);
            this.btnrigth.Name = "btnrigth";
            this.btnrigth.Size = new System.Drawing.Size(55, 28);
            this.btnrigth.TabIndex = 6;
            this.btnrigth.Text = ">>";
            this.btnrigth.UseVisualStyleBackColor = true;
            this.btnrigth.Click += new System.EventHandler(this.btnrigth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Su precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Location = new System.Drawing.Point(416, 346);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(36, 17);
            this.priceText.TabIndex = 9;
            this.priceText.Text = "5,00";
            // 
            // Addpizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 482);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrigth);
            this.Controls.Add(this.IngredientsText);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.previewImage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nombreText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Addpizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addpizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nombreText;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button previewImage;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button guardar;
        public System.Windows.Forms.ListBox IngredientsText;
        public System.Windows.Forms.Button btnrigth;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label priceText;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}