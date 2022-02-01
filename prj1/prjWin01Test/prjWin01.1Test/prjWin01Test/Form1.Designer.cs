
namespace prjWin01Test
{
    partial class round
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndecrement = new System.Windows.Forms.Button();
            this.btnincrement = new System.Windows.Forms.Button();
            this.lblincrement = new System.Windows.Forms.Label();
            this.prgbfooter = new System.Windows.Forms.ProgressBar();
            this.timerIncrement = new System.Windows.Forms.Timer(this.components);
            this.timerDecrement = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.btndecrement);
            this.panel1.Controls.Add(this.btnincrement);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 419);
            this.panel1.TabIndex = 0;
            // 
            // btndecrement
            // 
            this.btndecrement.BackColor = System.Drawing.Color.White;
            this.btndecrement.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btndecrement.Location = new System.Drawing.Point(3, 310);
            this.btndecrement.Name = "btndecrement";
            this.btndecrement.Size = new System.Drawing.Size(202, 50);
            this.btndecrement.TabIndex = 1;
            this.btndecrement.Text = "decrement";
            this.btndecrement.UseVisualStyleBackColor = false;
            this.btndecrement.Click += new System.EventHandler(this.btndecrement_Click);
            // 
            // btnincrement
            // 
            this.btnincrement.BackColor = System.Drawing.Color.White;
            this.btnincrement.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnincrement.Location = new System.Drawing.Point(3, 366);
            this.btnincrement.Name = "btnincrement";
            this.btnincrement.Size = new System.Drawing.Size(202, 50);
            this.btnincrement.TabIndex = 0;
            this.btnincrement.Text = "increment";
            this.btnincrement.UseVisualStyleBackColor = false;
            this.btnincrement.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblincrement
            // 
            this.lblincrement.AutoSize = true;
            this.lblincrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincrement.ForeColor = System.Drawing.Color.Black;
            this.lblincrement.Location = new System.Drawing.Point(366, 119);
            this.lblincrement.Name = "lblincrement";
            this.lblincrement.Size = new System.Drawing.Size(125, 135);
            this.lblincrement.TabIndex = 1;
            this.lblincrement.Text = "0";
            this.lblincrement.Click += new System.EventHandler(this.lblincrement_Click);
            // 
            // prgbfooter
            // 
            this.prgbfooter.Location = new System.Drawing.Point(227, 408);
            this.prgbfooter.Name = "prgbfooter";
            this.prgbfooter.Size = new System.Drawing.Size(477, 23);
            this.prgbfooter.TabIndex = 2;
            this.prgbfooter.Click += new System.EventHandler(this.prgbfooter_Click);
            // 
            // timerIncrement
            // 
            this.timerIncrement.Tick += new System.EventHandler(this.timerIncrement_Tick);
            // 
            // timerDecrement
            // 
            this.timerDecrement.Tick += new System.EventHandler(this.timerDecrement_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgbfooter);
            this.Controls.Add(this.lblincrement);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "round";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnincrement;
        private System.Windows.Forms.Label lblincrement;
        private System.Windows.Forms.Button btndecrement;
        private System.Windows.Forms.ProgressBar prgbfooter;
        private System.Windows.Forms.Timer timerIncrement;
        private System.Windows.Forms.Timer timerDecrement;
        private System.Windows.Forms.Label label1;
    }
}

