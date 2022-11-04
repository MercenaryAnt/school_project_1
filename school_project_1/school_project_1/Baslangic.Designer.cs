namespace school_project_1
{
    partial class Baslangic
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
            this.btn_lisansGirisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_lisansKodu = new System.Windows.Forms.TextBox();
            this.tx_yazilimKodu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_lisansGirisi
            // 
            this.btn_lisansGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_lisansGirisi.Location = new System.Drawing.Point(249, 174);
            this.btn_lisansGirisi.Name = "btn_lisansGirisi";
            this.btn_lisansGirisi.Size = new System.Drawing.Size(138, 41);
            this.btn_lisansGirisi.TabIndex = 10;
            this.btn_lisansGirisi.Text = "Lisansla";
            this.btn_lisansGirisi.UseVisualStyleBackColor = true;
            this.btn_lisansGirisi.Click += new System.EventHandler(this.btn_lisansGirisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(116, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yukardaki yazılım kodunuz yazılım üreticinize vererek Lisans kodu edinebilirsiniz" +
    " !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lisans Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yazılım Kodu:";
            // 
            // tx_lisansKodu
            // 
            this.tx_lisansKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_lisansKodu.Location = new System.Drawing.Point(119, 133);
            this.tx_lisansKodu.Name = "tx_lisansKodu";
            this.tx_lisansKodu.Size = new System.Drawing.Size(428, 24);
            this.tx_lisansKodu.TabIndex = 6;
            // 
            // tx_yazilimKodu
            // 
            this.tx_yazilimKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_yazilimKodu.Location = new System.Drawing.Point(119, 38);
            this.tx_yazilimKodu.Name = "tx_yazilimKodu";
            this.tx_yazilimKodu.Size = new System.Drawing.Size(428, 24);
            this.tx_yazilimKodu.TabIndex = 5;
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 242);
            this.Controls.Add(this.btn_lisansGirisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_lisansKodu);
            this.Controls.Add(this.tx_yazilimKodu);
            this.Name = "Baslangic";
            this.Text = "Baslangic";
            this.Load += new System.EventHandler(this.Baslangic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lisansGirisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_lisansKodu;
        private System.Windows.Forms.TextBox tx_yazilimKodu;
    }
}