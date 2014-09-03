namespace Mouseio
{
    partial class greek_beaches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(greek_beaches));
            this.textBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(391, 82);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(319, 234);
            this.textBox.TabIndex = 0;
            this.textBox.Text = resources.GetString("textBox.Text");
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Mouseio.Properties.Resources.Myrtos_Kefalonia;
            this.pictureBox.Location = new System.Drawing.Point(40, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 261);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(258, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 20);
            this.label.TabIndex = 14;
            this.label.Text = "Mύρτος - Κεφαλονιά";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExit.Location = new System.Drawing.Point(596, 361);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 54);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Έξοδος";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLogOut.Location = new System.Drawing.Point(465, 361);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(125, 54);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Πίσω";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonNext.Location = new System.Drawing.Point(219, 377);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(106, 31);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Επόμενη ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelNum.Location = new System.Drawing.Point(178, 384);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(26, 16);
            this.labelNum.TabIndex = 18;
            this.labelNum.Text = "1/6";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonPrevious.Location = new System.Drawing.Point(56, 377);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(106, 31);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.Text = "Προηγούμενη";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // greek_beaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 427);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox);
            this.Name = "greek_beaches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ελληνικές Παραλίες";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button buttonPrevious;
    }
}