
namespace Jogo_da_Velha
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
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(72, 100);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(50, 50);
            this.btn11.TabIndex = 0;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(128, 100);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(50, 50);
            this.btn12.TabIndex = 1;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(184, 100);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(50, 50);
            this.btn13.TabIndex = 2;
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(72, 156);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(50, 50);
            this.btn21.TabIndex = 3;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(128, 156);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(50, 50);
            this.btn22.TabIndex = 4;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn23
            // 
            this.btn23.Location = new System.Drawing.Point(184, 156);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(50, 50);
            this.btn23.TabIndex = 5;
            this.btn23.UseVisualStyleBackColor = true;
            // 
            // btn31
            // 
            this.btn31.Location = new System.Drawing.Point(72, 212);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(50, 50);
            this.btn31.TabIndex = 6;
            this.btn31.UseVisualStyleBackColor = true;
            // 
            // btn32
            // 
            this.btn32.Location = new System.Drawing.Point(128, 212);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(50, 50);
            this.btn32.TabIndex = 7;
            this.btn32.UseVisualStyleBackColor = true;
            // 
            // btn33
            // 
            this.btn33.Location = new System.Drawing.Point(184, 212);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(50, 50);
            this.btn33.TabIndex = 8;
            this.btn33.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "x, é sua vez.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Name = "Form1";
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label label1;
    }
}

