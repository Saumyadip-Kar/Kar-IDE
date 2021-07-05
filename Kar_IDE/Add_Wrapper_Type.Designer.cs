
namespace Kar_IDE
{
    partial class Add_Wrapper_Type
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
            this.Add_New_Line = new System.Windows.Forms.CheckBox();
            this.add_button = new System.Windows.Forms.Button();
            this.Value_Check = new System.Windows.Forms.CheckBox();
            this.Value_Box = new System.Windows.Forms.TextBox();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Type_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_New_Line
            // 
            this.Add_New_Line.AutoSize = true;
            this.Add_New_Line.Location = new System.Drawing.Point(113, 237);
            this.Add_New_Line.Name = "Add_New_Line";
            this.Add_New_Line.Size = new System.Drawing.Size(124, 24);
            this.Add_New_Line.TabIndex = 16;
            this.Add_New_Line.Text = "Add New Line";
            this.Add_New_Line.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(255, 291);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 42);
            this.add_button.TabIndex = 15;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Value_Check
            // 
            this.Value_Check.AutoSize = true;
            this.Value_Check.Location = new System.Drawing.Point(113, 187);
            this.Value_Check.Name = "Value_Check";
            this.Value_Check.Size = new System.Drawing.Size(121, 24);
            this.Value_Check.TabIndex = 14;
            this.Value_Check.Text = "Data to Wrap";
            this.Value_Check.UseVisualStyleBackColor = true;
            this.Value_Check.CheckedChanged += new System.EventHandler(this.Value_Check_CheckedChanged);
            // 
            // Value_Box
            // 
            this.Value_Box.Location = new System.Drawing.Point(296, 184);
            this.Value_Box.Name = "Value_Box";
            this.Value_Box.Size = new System.Drawing.Size(160, 27);
            this.Value_Box.TabIndex = 13;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(296, 113);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(160, 27);
            this.ID_Box.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Identifier Name";
            // 
            // Type_Box
            // 
            this.Type_Box.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Type_Box.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Type_Box.FormattingEnabled = true;
            this.Type_Box.Items.AddRange(new object[] {
            "Byte",
            "Short",
            "Character",
            "Integer",
            "Long",
            "Float",
            "Double",
            "Boolean"});
            this.Type_Box.Location = new System.Drawing.Point(296, 48);
            this.Type_Box.Name = "Type_Box";
            this.Type_Box.Size = new System.Drawing.Size(160, 28);
            this.Type_Box.TabIndex = 10;
            this.Type_Box.SelectedIndexChanged += new System.EventHandler(this.Type_Box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wrapper Class";
            // 
            // Add_Wrapper_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.Add_New_Line);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Value_Check);
            this.Controls.Add(this.Value_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type_Box);
            this.Controls.Add(this.label1);
            this.Name = "Add_Wrapper_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Wrapper_Type";
            this.Load += new System.EventHandler(this.Add_Wrapper_Type_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Add_New_Line;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.CheckBox Value_Check;
        private System.Windows.Forms.TextBox Value_Box;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Type_Box;
        private System.Windows.Forms.Label label1;
    }
}