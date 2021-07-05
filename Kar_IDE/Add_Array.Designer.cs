
namespace Kar_IDE
{
    partial class Add_Array
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
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.Value_Box = new System.Windows.Forms.TextBox();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.elment_no_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_New_Line
            // 
            this.Add_New_Line.AutoSize = true;
            this.Add_New_Line.Location = new System.Drawing.Point(120, 285);
            this.Add_New_Line.Name = "Add_New_Line";
            this.Add_New_Line.Size = new System.Drawing.Size(124, 24);
            this.Add_New_Line.TabIndex = 24;
            this.Add_New_Line.Text = "Add New Line";
            this.Add_New_Line.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(262, 339);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 42);
            this.add_button.TabIndex = 23;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(120, 235);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(104, 24);
            this.checkbox2.TabIndex = 22;
            this.checkbox2.Text = "Initial Data";
            this.checkbox2.UseVisualStyleBackColor = true;
            this.checkbox2.CheckedChanged += new System.EventHandler(this.checkbox2_CheckedChanged);
            // 
            // Value_Box
            // 
            this.Value_Box.Enabled = false;
            this.Value_Box.Location = new System.Drawing.Point(303, 232);
            this.Value_Box.Name = "Value_Box";
            this.Value_Box.Size = new System.Drawing.Size(160, 27);
            this.Value_Box.TabIndex = 21;
            this.Value_Box.Tag = "";
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(303, 99);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(160, 27);
            this.ID_Box.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Identifier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type";
            // 
            // type_box
            // 
            this.type_box.AutoCompleteCustomSource.AddRange(new string[] {
            "byte",
            "short",
            "char",
            "int",
            "long",
            "float",
            "double",
            "boolean",
            "Byte",
            "Short",
            "Character",
            "Integer",
            "Long",
            "Float",
            "Double",
            "Boolean",
            "String",
            "Object"});
            this.type_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.type_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.type_box.Location = new System.Drawing.Point(303, 34);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(160, 27);
            this.type_box.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(120, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "No of Elements";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // elment_no_box
            // 
            this.elment_no_box.Enabled = false;
            this.elment_no_box.Location = new System.Drawing.Point(303, 166);
            this.elment_no_box.Name = "elment_no_box";
            this.elment_no_box.Size = new System.Drawing.Size(160, 27);
            this.elment_no_box.TabIndex = 26;
            this.elment_no_box.Tag = "";
            // 
            // Add_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 413);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.elment_no_box);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.Add_New_Line);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.Value_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Array";
            this.Text = "Add_Array";
            this.Load += new System.EventHandler(this.Add_Array_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Add_New_Line;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.TextBox Value_Box;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type_box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox elment_no_box;
    }
}