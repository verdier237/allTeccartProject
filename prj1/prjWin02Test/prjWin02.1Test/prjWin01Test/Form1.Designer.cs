
namespace prjWin01Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Label();
            this.flpHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpHeader
            // 
            this.flpHeader.BackColor = System.Drawing.Color.Coral;
            this.flpHeader.Controls.Add(this.lblNumber);
            this.flpHeader.ForeColor = System.Drawing.Color.White;
            this.flpHeader.Location = new System.Drawing.Point(10, 12);
            this.flpHeader.Name = "flpHeader";
            this.flpHeader.Padding = new System.Windows.Forms.Padding(270, 0, 270, 0);
            this.flpHeader.Size = new System.Drawing.Size(780, 114);
            this.flpHeader.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(273, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(210, 93);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(10, 143);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(254, 84);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.Text = "remove";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(534, 143);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(254, 84);
            this.btnIncrease.TabIndex = 2;
            this.btnIncrease.Text = "add";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 84);
            this.button1.TabIndex = 5;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 84);
            this.button2.TabIndex = 4;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Coral;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 233);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(270, 0, 270, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 114);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calc
            // 
            this.calc.AutoSize = true;
            this.calc.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc.Location = new System.Drawing.Point(362, 153);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(50, 60);
            this.calc.TabIndex = 6;
            this.calc.Text = "5";
            this.calc.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.flpHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flpHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHeader;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label calc;
    }
}

