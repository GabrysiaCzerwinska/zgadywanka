namespace GraGUI
{
    partial class Form2
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
            this.listView_historia = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_historia
            // 
            this.listView_historia.HideSelection = false;
            this.listView_historia.Location = new System.Drawing.Point(-4, 1);
            this.listView_historia.Name = "listView_historia";
            this.listView_historia.Size = new System.Drawing.Size(449, 646);
            this.listView_historia.TabIndex = 0;
            this.listView_historia.UseCompatibleStateImageBehavior = false;
            this.listView_historia.View = System.Windows.Forms.View.Details;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 647);
            this.Controls.Add(this.listView_historia);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_historia;
    }
}