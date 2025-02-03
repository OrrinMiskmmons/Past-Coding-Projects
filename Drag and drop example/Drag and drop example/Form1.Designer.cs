
namespace Drag_and_drop_example
{
    partial class SharkDragAndDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharkDragAndDrop));
            this.picShark = new System.Windows.Forms.PictureBox();
            this.lblBaskingShark = new System.Windows.Forms.Label();
            this.lblTigerShark = new System.Windows.Forms.Label();
            this.lblGreatWhiteShark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShark)).BeginInit();
            this.SuspendLayout();
            // 
            // picShark
            // 
            this.picShark.Image = ((System.Drawing.Image)(resources.GetObject("picShark.Image")));
            this.picShark.Location = new System.Drawing.Point(179, 102);
            this.picShark.Name = "picShark";
            this.picShark.Size = new System.Drawing.Size(173, 187);
            this.picShark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShark.TabIndex = 0;
            this.picShark.TabStop = false;
            this.picShark.DragDrop += new System.Windows.Forms.DragEventHandler(this.CheckCorrectShark);
            this.picShark.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataDropCheck);
            this.picShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeciesSelected);
            // 
            // lblBaskingShark
            // 
            this.lblBaskingShark.AutoSize = true;
            this.lblBaskingShark.Location = new System.Drawing.Point(213, 51);
            this.lblBaskingShark.Name = "lblBaskingShark";
            this.lblBaskingShark.Size = new System.Drawing.Size(28, 13);
            this.lblBaskingShark.TabIndex = 2;
            this.lblBaskingShark.Text = "Ford";
            this.lblBaskingShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeciesSelected);
            // 
            // lblTigerShark
            // 
            this.lblTigerShark.AutoSize = true;
            this.lblTigerShark.Location = new System.Drawing.Point(65, 51);
            this.lblTigerShark.Name = "lblTigerShark";
            this.lblTigerShark.Size = new System.Drawing.Size(34, 13);
            this.lblTigerShark.TabIndex = 3;
            this.lblTigerShark.Text = "Volvo";
            this.lblTigerShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeciesSelected);
            // 
            // lblGreatWhiteShark
            // 
            this.lblGreatWhiteShark.AutoSize = true;
            this.lblGreatWhiteShark.Location = new System.Drawing.Point(388, 51);
            this.lblGreatWhiteShark.Name = "lblGreatWhiteShark";
            this.lblGreatWhiteShark.Size = new System.Drawing.Size(46, 13);
            this.lblGreatWhiteShark.TabIndex = 4;
            this.lblGreatWhiteShark.Text = "Porsche";
            this.lblGreatWhiteShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeciesSelected);
            // 
            // SharkDragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 356);
            this.Controls.Add(this.lblGreatWhiteShark);
            this.Controls.Add(this.lblTigerShark);
            this.Controls.Add(this.lblBaskingShark);
            this.Controls.Add(this.picShark);
            this.Name = "SharkDragAndDrop";
            this.Text = "CarDragDrop";
            this.Load += new System.EventHandler(this.SharkDragAndDrop_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CheckCorrectShark);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataDropCheck);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeciesSelected);
            ((System.ComponentModel.ISupportInitialize)(this.picShark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShark;
        private System.Windows.Forms.Label lblBaskingShark;
        private System.Windows.Forms.Label lblTigerShark;
        private System.Windows.Forms.Label lblGreatWhiteShark;
    }
}

