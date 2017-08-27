namespace Pizzeria
{
    partial class VerPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPizza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fotoPizza = new System.Windows.Forms.PictureBox();
            this.nombrePizza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ingredientsText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puntuacion = new System.Windows.Forms.ComboBox();
            this.comentarioText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textoUsuarioComentario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastComment = new System.Windows.Forms.TextBox();
            this.precioPizza = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.fechaText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fotoPizza);
            this.panel1.Controls.Add(this.nombrePizza);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 145);
            this.panel1.TabIndex = 0;
            // 
            // fotoPizza
            // 
            this.fotoPizza.Image = ((System.Drawing.Image)(resources.GetObject("fotoPizza.Image")));
            this.fotoPizza.Location = new System.Drawing.Point(4, 36);
            this.fotoPizza.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPizza.Name = "fotoPizza";
            this.fotoPizza.Size = new System.Drawing.Size(147, 106);
            this.fotoPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPizza.TabIndex = 1;
            this.fotoPizza.TabStop = false;
            // 
            // nombrePizza
            // 
            this.nombrePizza.Enabled = false;
            this.nombrePizza.Location = new System.Drawing.Point(18, 11);
            this.nombrePizza.Margin = new System.Windows.Forms.Padding(4);
            this.nombrePizza.Name = "nombrePizza";
            this.nombrePizza.Size = new System.Drawing.Size(120, 22);
            this.nombrePizza.TabIndex = 0;
            this.nombrePizza.Text = "Pizza 1";
            this.nombrePizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredientes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // ingredientsText
            // 
            this.ingredientsText.Location = new System.Drawing.Point(200, 50);
            this.ingredientsText.Margin = new System.Windows.Forms.Padding(4);
            this.ingredientsText.Name = "ingredientsText";
            this.ingredientsText.Size = new System.Drawing.Size(192, 105);
            this.ingredientsText.TabIndex = 4;
            this.ingredientsText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deja tu comentario";
            // 
            // puntuacion
            // 
            this.puntuacion.FormattingEnabled = true;
            this.puntuacion.Items.AddRange(new object[] {
            "1 estrella",
            "2 estrellas",
            "3 estrellas",
            "4 estrellas",
            "5 estrellas"});
            this.puntuacion.Location = new System.Drawing.Point(16, 214);
            this.puntuacion.Margin = new System.Windows.Forms.Padding(4);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(160, 24);
            this.puntuacion.TabIndex = 7;
            this.puntuacion.Text = "Puntuación";
            // 
            // comentarioText
            // 
            this.comentarioText.Location = new System.Drawing.Point(16, 245);
            this.comentarioText.Margin = new System.Windows.Forms.Padding(4);
            this.comentarioText.Multiline = true;
            this.comentarioText.Name = "comentarioText";
            this.comentarioText.Size = new System.Drawing.Size(503, 68);
            this.comentarioText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ultimo Comentario";
            // 
            // textoUsuarioComentario
            // 
            this.textoUsuarioComentario.AutoSize = true;
            this.textoUsuarioComentario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoUsuarioComentario.Location = new System.Drawing.Point(20, 348);
            this.textoUsuarioComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textoUsuarioComentario.Name = "textoUsuarioComentario";
            this.textoUsuarioComentario.Size = new System.Drawing.Size(0, 17);
            this.textoUsuarioComentario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Puntuación: ";
            // 
            // lastComment
            // 
            this.lastComment.Location = new System.Drawing.Point(16, 384);
            this.lastComment.Margin = new System.Windows.Forms.Padding(4);
            this.lastComment.Multiline = true;
            this.lastComment.Name = "lastComment";
            this.lastComment.ReadOnly = true;
            this.lastComment.Size = new System.Drawing.Size(503, 70);
            this.lastComment.TabIndex = 13;
            // 
            // precioPizza
            // 
            this.precioPizza.AutoSize = true;
            this.precioPizza.Location = new System.Drawing.Point(79, 170);
            this.precioPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precioPizza.Name = "precioPizza";
            this.precioPizza.Size = new System.Drawing.Size(24, 17);
            this.precioPizza.TabIndex = 14;
            this.precioPizza.Text = "10";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(111, 170);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 17);
            this.label.TabIndex = 15;
            this.label.Text = "€";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(405, 320);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(114, 23);
            this.submit.TabIndex = 16;
            this.submit.Text = "Enviar ";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // fechaText
            // 
            this.fechaText.AutoSize = true;
            this.fechaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaText.Location = new System.Drawing.Point(74, 364);
            this.fechaText.Name = "fechaText";
            this.fechaText.Size = new System.Drawing.Size(45, 17);
            this.fechaText.TabIndex = 17;
            this.fechaText.Text = "Pepe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "5";
            // 
            // VerPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaText);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label);
            this.Controls.Add(this.precioPizza);
            this.Controls.Add(this.lastComment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoUsuarioComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comentarioText);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientsText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuestraspizzas1";
            this.Load += new System.EventHandler(this.VerPizza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.TextBox nombrePizza;
        public System.Windows.Forms.PictureBox fotoPizza;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox ingredientsText;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox puntuacion;
        public System.Windows.Forms.TextBox comentarioText;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox lastComment;
        public System.Windows.Forms.Label precioPizza;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Button submit;
        public System.Windows.Forms.Label fechaText;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label textoUsuarioComentario;
    }
}