namespace UtilitySource
{
    partial class UC_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roundPanel1 = new UtilitySource.RoundPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roundPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roundPanel1.Appearance.Options.UseBackColor = true;
            this.roundPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 20;
            this.roundPanel1.Size = new System.Drawing.Size(177, 172);
            this.roundPanel1.TabIndex = 0;
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundPanel1);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(177, 172);
            ((System.ComponentModel.ISupportInitialize)(this.roundPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
    }
}
