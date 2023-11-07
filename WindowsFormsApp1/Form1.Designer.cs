namespace WindowsFormsApp1
{
    partial class Form1
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
            this.titlelable = new System.Windows.Forms.Label();
            this.optionslable = new System.Windows.Forms.Label();
            this.conversionlable = new System.Windows.Forms.Label();
            this.optioninput = new System.Windows.Forms.TextBox();
            this.valuelable = new System.Windows.Forms.Label();
            this.valueinput = new System.Windows.Forms.TextBox();
            this.convertbutton = new System.Windows.Forms.Button();
            this.conversionoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelable
            // 
            this.titlelable.BackColor = System.Drawing.Color.RoyalBlue;
            this.titlelable.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.Location = new System.Drawing.Point(12, 9);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(423, 56);
            this.titlelable.TabIndex = 0;
            this.titlelable.Text = "Conversion Calculator";
            this.titlelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionslable
            // 
            this.optionslable.BackColor = System.Drawing.Color.Silver;
            this.optionslable.Location = new System.Drawing.Point(94, 65);
            this.optionslable.Name = "optionslable";
            this.optionslable.Size = new System.Drawing.Size(248, 135);
            this.optionslable.TabIndex = 1;
            // 
            // conversionlable
            // 
            this.conversionlable.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionlable.Location = new System.Drawing.Point(2, 247);
            this.conversionlable.Name = "conversionlable";
            this.conversionlable.Size = new System.Drawing.Size(317, 23);
            this.conversionlable.TabIndex = 2;
            this.conversionlable.Text = "Enter conversion choise(1-4):";
            // 
            // optioninput
            // 
            this.optioninput.Location = new System.Drawing.Point(335, 247);
            this.optioninput.Name = "optioninput";
            this.optioninput.Size = new System.Drawing.Size(119, 22);
            this.optioninput.TabIndex = 3;
            // 
            // valuelable
            // 
            this.valuelable.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuelable.Location = new System.Drawing.Point(2, 284);
            this.valuelable.Name = "valuelable";
            this.valuelable.Size = new System.Drawing.Size(317, 23);
            this.valuelable.TabIndex = 4;
            this.valuelable.Text = "Enter Value to be converted:";
            // 
            // valueinput
            // 
            this.valueinput.Location = new System.Drawing.Point(335, 285);
            this.valueinput.Name = "valueinput";
            this.valueinput.Size = new System.Drawing.Size(119, 22);
            this.valueinput.TabIndex = 5;
            // 
            // convertbutton
            // 
            this.convertbutton.Location = new System.Drawing.Point(134, 335);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(164, 23);
            this.convertbutton.TabIndex = 6;
            this.convertbutton.Text = "convert ";
            this.convertbutton.UseVisualStyleBackColor = true;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            // 
            // conversionoutput
            // 
            this.conversionoutput.BackColor = System.Drawing.Color.Transparent;
            this.conversionoutput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionoutput.Location = new System.Drawing.Point(54, 400);
            this.conversionoutput.Name = "conversionoutput";
            this.conversionoutput.Size = new System.Drawing.Size(311, 23);
            this.conversionoutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.conversionoutput);
            this.Controls.Add(this.convertbutton);
            this.Controls.Add(this.valueinput);
            this.Controls.Add(this.valuelable);
            this.Controls.Add(this.optioninput);
            this.Controls.Add(this.conversionlable);
            this.Controls.Add(this.optionslable);
            this.Controls.Add(this.titlelable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.Label optionslable;
        private System.Windows.Forms.Label conversionlable;
        private System.Windows.Forms.TextBox optioninput;
        private System.Windows.Forms.Label valuelable;
        private System.Windows.Forms.TextBox valueinput;
        private System.Windows.Forms.Button convertbutton;
        private System.Windows.Forms.Label conversionoutput;
    }
}

