namespace WindowsFormsSimple
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.clickPicture = new System.Windows.Forms.PictureBox();
            this.clickLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clickPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(897, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 625);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Экзит";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clickPicture
            // 
            this.clickPicture.Image = global::WindowsFormsSimple.Properties.Resources.Снимок_экрана_2024_05_30_164446;
            this.clickPicture.Location = new System.Drawing.Point(12, 12);
            this.clickPicture.Name = "clickPicture";
            this.clickPicture.Size = new System.Drawing.Size(324, 633);
            this.clickPicture.TabIndex = 1;
            this.clickPicture.TabStop = false;
            this.clickPicture.UseWaitCursor = true;
            this.clickPicture.WaitOnLoad = true;
            this.clickPicture.Click += new System.EventHandler(this.clickPicture_Click);
            this.clickPicture.DoubleClick += new System.EventHandler(this.clickPicture_DoubleClick);
            // 
            // clickLabel
            // 
            this.clickLabel.Font = new System.Drawing.Font("Mocking Bird", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.clickLabel.Location = new System.Drawing.Point(5, 7);
            this.clickLabel.Name = "clickLabel";
            this.clickLabel.Size = new System.Drawing.Size(879, 633);
            this.clickLabel.TabIndex = 2;
            this.clickLabel.Text = "Щёлкни 2 раза и появится царица";
            this.clickLabel.Click += new System.EventHandler(this.clickLabel_Click);
            this.clickLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clickLabel_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(448, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Щёлкни на неё и она уйдёт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 649);
            this.Controls.Add(this.clickLabel);
            this.Controls.Add(this.clickPicture);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "FormFromMiroshnichenkoIA";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.clickPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox clickPicture;
        private System.Windows.Forms.Label clickLabel;
        private System.Windows.Forms.Label label1;
    }
}

