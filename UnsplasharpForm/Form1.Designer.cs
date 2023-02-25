namespace UnsplasharpForm
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
            this.pbWordImg = new System.Windows.Forms.PictureBox();
            this.txtWordToBeSearch = new System.Windows.Forms.TextBox();
            this.btnChangeImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWordImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWordImg
            // 
            this.pbWordImg.Location = new System.Drawing.Point(136, 177);
            this.pbWordImg.Name = "pbWordImg";
            this.pbWordImg.Size = new System.Drawing.Size(163, 109);
            this.pbWordImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWordImg.TabIndex = 0;
            this.pbWordImg.TabStop = false;
            // 
            // txtWordToBeSearch
            // 
            this.txtWordToBeSearch.Location = new System.Drawing.Point(156, 123);
            this.txtWordToBeSearch.Name = "txtWordToBeSearch";
            this.txtWordToBeSearch.Size = new System.Drawing.Size(125, 27);
            this.txtWordToBeSearch.TabIndex = 1;
            // 
            // btnChangeImg
            // 
            this.btnChangeImg.Location = new System.Drawing.Point(168, 314);
            this.btnChangeImg.Name = "btnChangeImg";
            this.btnChangeImg.Size = new System.Drawing.Size(94, 29);
            this.btnChangeImg.TabIndex = 2;
            this.btnChangeImg.Text = "Change";
            this.btnChangeImg.UseVisualStyleBackColor = true;
            this.btnChangeImg.Click += new System.EventHandler(this.btnChangeImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 418);
            this.Controls.Add(this.btnChangeImg);
            this.Controls.Add(this.txtWordToBeSearch);
            this.Controls.Add(this.pbWordImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbWordImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbWordImg;
        private TextBox txtWordToBeSearch;
        private Button btnChangeImg;
    }
}