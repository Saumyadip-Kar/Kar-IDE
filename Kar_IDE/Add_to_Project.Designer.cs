
namespace Kar_IDE
{
    partial class Add_to_Project
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
            this.Selected_Item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Select_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Selected_Item
            // 
            this.Selected_Item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Selected_Item.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Selected_Item.FormattingEnabled = true;
            this.Selected_Item.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Selected_Item.Items.AddRange(new object[] {
            "Primitive Type Variable",
            "Wrapper Type Object",
            "Array",
            "String",
            "Class",
            "Object",
            "Method"});
            this.Selected_Item.Location = new System.Drawing.Point(28, 46);
            this.Selected_Item.Name = "Selected_Item";
            this.Selected_Item.Size = new System.Drawing.Size(289, 28);
            this.Selected_Item.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Item to Add";
            // 
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(223, 108);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(94, 29);
            this.Select_Button.TabIndex = 2;
            this.Select_Button.Text = "Select";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // Add_to_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 164);
            this.Controls.Add(this.Select_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selected_Item);
            this.Name = "Add_to_Project";
            this.Text = "Add_to_Project";
            this.Load += new System.EventHandler(this.Add_to_Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Selected_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Select_Button;
    }
}