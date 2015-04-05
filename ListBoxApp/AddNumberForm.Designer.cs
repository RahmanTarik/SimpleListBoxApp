namespace ListBoxApp
{
    partial class AddNumberToListBox
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
            this.itemNumberLebel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemNumberLebel
            // 
            this.itemNumberLebel.AutoSize = true;
            this.itemNumberLebel.Location = new System.Drawing.Point(13, 13);
            this.itemNumberLebel.Name = "itemNumberLebel";
            this.itemNumberLebel.Size = new System.Drawing.Size(67, 13);
            this.itemNumberLebel.TabIndex = 0;
            this.itemNumberLebel.Text = "Item Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(95, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(201, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(16, 63);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(278, 173);
            this.numberListBox.TabIndex = 3;
            this.numberListBox.SelectedIndexChanged += new System.EventHandler(this.numberListBox_SelectedIndexChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(201, 270);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(92, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // AddNumberToListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 338);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.itemNumberLebel);
            this.Name = "AddNumberToListBox";
            this.Text = "Add Number Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNumberLebel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button showButton;
    }
}

