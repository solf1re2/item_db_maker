using System.Windows.Forms;

namespace item_database
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
            this.itemTree = new System.Windows.Forms.TreeView();
            this.Items = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemTree
            // 
            this.itemTree.Location = new System.Drawing.Point(31, 75);
            this.itemTree.Name = "itemTree";
            this.itemTree.Size = new System.Drawing.Size(121, 255);
            this.itemTree.TabIndex = 0;
            this.itemTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemTree_MouseDoubleClick);
            // 
            // Items
            // 
            this.Items.AutoSize = true;
            this.Items.Location = new System.Drawing.Point(31, 56);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(32, 13);
            this.Items.TabIndex = 1;
            this.Items.Text = "Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 394);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.itemTree);
            this.Name = "Form1";
            this.Text = "Item Database Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView itemTree;
        private Label Items;

    }
}

