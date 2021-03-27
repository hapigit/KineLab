
namespace KineLab
{
    partial class lensForm
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
            this.lensLock = new System.Windows.Forms.Button();
            this.addPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.motorPos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.ComboBox();
            this.motorP = new System.Windows.Forms.Button();
            this.motorN = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lensLock
            // 
            this.lensLock.Location = new System.Drawing.Point(76, 159);
            this.lensLock.Name = "lensLock";
            this.lensLock.Size = new System.Drawing.Size(75, 23);
            this.lensLock.TabIndex = 0;
            this.lensLock.Text = "CHANGE!";
            this.lensLock.UseVisualStyleBackColor = true;
            // 
            // addPoint
            // 
            this.addPoint.Location = new System.Drawing.Point(76, 76);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(75, 23);
            this.addPoint.TabIndex = 1;
            this.addPoint.Text = "Add Point";
            this.addPoint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motor Position:";
            // 
            // motorPos
            // 
            this.motorPos.AutoSize = true;
            this.motorPos.Location = new System.Drawing.Point(130, 25);
            this.motorPos.Name = "motorPos";
            this.motorPos.Size = new System.Drawing.Size(11, 12);
            this.motorPos.TabIndex = 3;
            this.motorPos.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Focus:";
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "ft",
            "m"});
            this.unit.Location = new System.Drawing.Point(147, 49);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(39, 20);
            this.unit.TabIndex = 5;
            this.unit.Text = "ft";
            // 
            // motorP
            // 
            this.motorP.Location = new System.Drawing.Point(50, 108);
            this.motorP.Name = "motorP";
            this.motorP.Size = new System.Drawing.Size(50, 30);
            this.motorP.TabIndex = 6;
            this.motorP.Text = "Motor+";
            this.motorP.UseVisualStyleBackColor = true;
            // 
            // motorN
            // 
            this.motorN.Location = new System.Drawing.Point(121, 108);
            this.motorN.Name = "motorN";
            this.motorN.Size = new System.Drawing.Size(50, 30);
            this.motorN.TabIndex = 6;
            this.motorN.Text = "Motor-";
            this.motorN.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(76, 189);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // lensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 232);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.motorN);
            this.Controls.Add(this.motorP);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.motorPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.lensLock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lensForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lens Calibration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lensLock;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label motorPos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.Button motorP;
        private System.Windows.Forms.Button motorN;
        private System.Windows.Forms.Button okButton;
    }
}