
namespace Kar_IDE
{
    partial class Add_Primitive_Variable
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
            this.label1 = new System.Windows.Forms.Label();
            this.Type_Box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.Value_Box = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.add_button = new System.Windows.Forms.Button();
            this.Add_New_Line = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataType";
            // 
            // Type_Box
            // 
            this.Type_Box.FormattingEnabled = true;
            this.Type_Box.Items.AddRange(new object[] {
            "byte",
            "short",
            "char",
            "int",
            "long",
            "float",
            "double",
            "boolean"});
            this.Type_Box.Location = new System.Drawing.Point(308, 46);
            this.Type_Box.Name = "Type_Box";
            this.Type_Box.Size = new System.Drawing.Size(160, 28);
            this.Type_Box.TabIndex = 1;
            this.Type_Box.SelectedIndexChanged += new System.EventHandler(this.Type_Box_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identifier Name";
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(308, 111);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(160, 27);
            this.ID_Box.TabIndex = 3;
            // 
            // Value_Box
            // 
            this.Value_Box.Enabled = false;
            this.Value_Box.Location = new System.Drawing.Point(308, 182);
            this.Value_Box.Name = "Value_Box";
            this.Value_Box.Size = new System.Drawing.Size(160, 27);
            this.Value_Box.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(125, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Initial Value";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(267, 289);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 42);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Add_New_Line
            // 
            this.Add_New_Line.AutoSize = true;
            this.Add_New_Line.Location = new System.Drawing.Point(125, 235);
            this.Add_New_Line.Name = "Add_New_Line";
            this.Add_New_Line.Size = new System.Drawing.Size(124, 24);
            this.Add_New_Line.TabIndex = 8;
            this.Add_New_Line.Text = "Add New Line";
            this.Add_New_Line.UseVisualStyleBackColor = true;
            // 
            // Add_Primitive_Variable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.Add_New_Line);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Value_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type_Box);
            this.Controls.Add(this.label1);
            this.Name = "Add_Primitive_Variable";
            this.Text = "Add_Primitive_Variable";
            this.Load += new System.EventHandler(this.Add_Primitive_Variable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Type_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox Value_Box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.CheckBox Add_New_Line;
    }
}