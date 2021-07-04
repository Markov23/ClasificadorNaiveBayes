
namespace ClasificadorNaiveBayesTitanic
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClase = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbEdad = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.labelVivir = new System.Windows.Forms.Label();
            this.labelMorir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbResultado
            // 
            this.pbResultado.Image = ((System.Drawing.Image)(resources.GetObject("pbResultado.Image")));
            this.pbResultado.Location = new System.Drawing.Point(315, 55);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(255, 255);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResultado.TabIndex = 1;
            this.pbResultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo:";
            // 
            // cbClase
            // 
            this.cbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClase.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClase.FormattingEnabled = true;
            this.cbClase.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera",
            "Tripulación"});
            this.cbClase.Location = new System.Drawing.Point(10, 70);
            this.cbClase.Name = "cbClase";
            this.cbClase.Size = new System.Drawing.Size(200, 32);
            this.cbClase.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(230, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(70, 50);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbEdad
            // 
            this.cbEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdad.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEdad.FormattingEnabled = true;
            this.cbEdad.Items.AddRange(new object[] {
            "Adulto",
            "Niño"});
            this.cbEdad.Location = new System.Drawing.Point(10, 150);
            this.cbEdad.Name = "cbEdad";
            this.cbEdad.Size = new System.Drawing.Size(200, 32);
            this.cbEdad.TabIndex = 8;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(10, 230);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(200, 32);
            this.cbSexo.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(230, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 50);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "resultado.png");
            this.iconos.Images.SetKeyName(1, "vive.png");
            this.iconos.Images.SetKeyName(2, "muere.png");
            // 
            // labelVivir
            // 
            this.labelVivir.AutoSize = true;
            this.labelVivir.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVivir.Location = new System.Drawing.Point(10, 275);
            this.labelVivir.Name = "labelVivir";
            this.labelVivir.Size = new System.Drawing.Size(244, 24);
            this.labelVivir.TabIndex = 11;
            this.labelVivir.Text = "Probabilidad de sobrevivir: 0%";
            // 
            // labelMorir
            // 
            this.labelMorir.AutoSize = true;
            this.labelMorir.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMorir.Location = new System.Drawing.Point(10, 305);
            this.labelMorir.Name = "labelMorir";
            this.labelMorir.Size = new System.Drawing.Size(210, 24);
            this.labelMorir.TabIndex = 12;
            this.labelMorir.Text = "Probabilidad de morir: 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.labelMorir);
            this.Controls.Add(this.labelVivir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbEdad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbClase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "¿Sobrevivirias al titanic?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbClase;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbEdad;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ImageList iconos;
        private System.Windows.Forms.Label labelVivir;
        private System.Windows.Forms.Label labelMorir;
    }
}

