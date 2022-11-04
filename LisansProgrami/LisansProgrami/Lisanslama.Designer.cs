namespace LisansProgrami
{
    partial class Lisanslama
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_lisansKodu = new System.Windows.Forms.TextBox();
            this.tx_yazilimKodu = new System.Windows.Forms.TextBox();
            this.btn_lisansKoduUret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(127, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yukardaki yazılım kodunuz yazılım üreticinize vererek Lisans kodu edinebilirsiniz" +
    " !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lisans Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yazılım Kodu:";
            // 
            // tx_lisansKodu
            // 
            this.tx_lisansKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_lisansKodu.Location = new System.Drawing.Point(130, 164);
            this.tx_lisansKodu.Name = "tx_lisansKodu";
            this.tx_lisansKodu.Size = new System.Drawing.Size(428, 24);
            this.tx_lisansKodu.TabIndex = 5;
            // 
            // tx_yazilimKodu
            // 
            this.tx_yazilimKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_yazilimKodu.Location = new System.Drawing.Point(130, 38);
            this.tx_yazilimKodu.Name = "tx_yazilimKodu";
            this.tx_yazilimKodu.Size = new System.Drawing.Size(428, 24);
            this.tx_yazilimKodu.TabIndex = 4;
            // 
            // btn_lisansKoduUret
            // 
            this.btn_lisansKoduUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_lisansKoduUret.Location = new System.Drawing.Point(264, 100);
            this.btn_lisansKoduUret.Name = "btn_lisansKoduUret";
            this.btn_lisansKoduUret.Size = new System.Drawing.Size(154, 45);
            this.btn_lisansKoduUret.TabIndex = 9;
            this.btn_lisansKoduUret.Text = "Lisans Kodu Üret";
            this.btn_lisansKoduUret.UseVisualStyleBackColor = true;
            this.btn_lisansKoduUret.Click += new System.EventHandler(this.btn_lisansKoduUret_Click);
            // 
            // Lisanslama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 289);
            this.Controls.Add(this.btn_lisansKoduUret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_lisansKodu);
            this.Controls.Add(this.tx_yazilimKodu);
            this.Name = "Lisanslama";
            this.Text = "Lisans Kod Üretici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_lisansKodu;
        private System.Windows.Forms.TextBox tx_yazilimKodu;
        private System.Windows.Forms.Button btn_lisansKoduUret;
    }
}

