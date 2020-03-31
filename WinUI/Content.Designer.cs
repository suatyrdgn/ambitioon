namespace WinUI
{
    partial class Content
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            this.picCOVER = new System.Windows.Forms.PictureBox();
            this.btnWatchLater = new System.Windows.Forms.Button();
            this.btcClose = new System.Windows.Forms.Button();
            this.lblContentName = new System.Windows.Forms.Label();
            this.btnContentScore = new System.Windows.Forms.Button();
            this.lblContentDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCOVER)).BeginInit();
            this.SuspendLayout();
            // 
            // picCOVER
            // 
            this.picCOVER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCOVER.Enabled = false;
            this.picCOVER.Image = ((System.Drawing.Image)(resources.GetObject("picCOVER.Image")));
            this.picCOVER.Location = new System.Drawing.Point(11, 12);
            this.picCOVER.Name = "picCOVER";
            this.picCOVER.Size = new System.Drawing.Size(411, 281);
            this.picCOVER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCOVER.TabIndex = 0;
            this.picCOVER.TabStop = false;
            // 
            // btnWatchLater
            // 
            this.btnWatchLater.BackColor = System.Drawing.Color.Transparent;
            this.btnWatchLater.FlatAppearance.BorderSize = 0;
            this.btnWatchLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchLater.Location = new System.Drawing.Point(312, 20);
            this.btnWatchLater.Name = "btnWatchLater";
            this.btnWatchLater.Size = new System.Drawing.Size(99, 23);
            this.btnWatchLater.TabIndex = 2;
            this.btnWatchLater.Text = "Watch later +";
            this.btnWatchLater.UseVisualStyleBackColor = false;
            // 
            // btcClose
            // 
            this.btcClose.BackColor = System.Drawing.Color.Transparent;
            this.btcClose.FlatAppearance.BorderSize = 0;
            this.btcClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcClose.Location = new System.Drawing.Point(20, 20);
            this.btcClose.Name = "btcClose";
            this.btcClose.Size = new System.Drawing.Size(25, 23);
            this.btcClose.TabIndex = 2;
            this.btcClose.Text = "X";
            this.btcClose.UseVisualStyleBackColor = false;
            // 
            // lblContentName
            // 
            this.lblContentName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblContentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentName.Location = new System.Drawing.Point(11, 309);
            this.lblContentName.Name = "lblContentName";
            this.lblContentName.Size = new System.Drawing.Size(411, 23);
            this.lblContentName.TabIndex = 3;
            // 
            // btnContentScore
            // 
            this.btnContentScore.BackColor = System.Drawing.Color.Transparent;
            this.btnContentScore.Enabled = false;
            this.btnContentScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContentScore.Location = new System.Drawing.Point(11, 335);
            this.btnContentScore.Name = "btnContentScore";
            this.btnContentScore.Size = new System.Drawing.Size(30, 30);
            this.btnContentScore.TabIndex = 4;
            this.btnContentScore.UseVisualStyleBackColor = false;
            // 
            // lblContentDesc
            // 
            this.lblContentDesc.BackColor = System.Drawing.Color.LightGray;
            this.lblContentDesc.Location = new System.Drawing.Point(11, 372);
            this.lblContentDesc.Name = "lblContentDesc";
            this.lblContentDesc.Size = new System.Drawing.Size(400, 150);
            this.lblContentDesc.TabIndex = 5;
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.ControlBox = false;
            this.Controls.Add(this.lblContentDesc);
            this.Controls.Add(this.btnContentScore);
            this.Controls.Add(this.lblContentName);
            this.Controls.Add(this.btcClose);
            this.Controls.Add(this.btnWatchLater);
            this.Controls.Add(this.picCOVER);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Content";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "content";
            this.Load += new System.EventHandler(this.Content_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCOVER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCOVER;
        private System.Windows.Forms.Button btnWatchLater;
        private System.Windows.Forms.Button btcClose;
        private System.Windows.Forms.Label lblContentName;
        private System.Windows.Forms.Button btnContentScore;
        private System.Windows.Forms.Label lblContentDesc;
    }
}