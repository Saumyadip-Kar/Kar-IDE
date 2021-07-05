
namespace Kar_IDE
{
    partial class Add_String_Here
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Value_Box = new System.Windows.Forms.TextBox();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Contructor_Args = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Add_New_Line
            // 
            this.Add_New_Line.AutoSize = true;
            this.Add_New_Line.Location = new System.Drawing.Point(120, 227);
            this.Add_New_Line.Name = "Add_New_Line";
            this.Add_New_Line.Size = new System.Drawing.Size(124, 24);
            this.Add_New_Line.TabIndex = 16;
            this.Add_New_Line.Text = "Add New Line";
            this.Add_New_Line.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(262, 281);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 42);
            this.add_button.TabIndex = 15;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(120, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Assign Literal";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Value_Box
            // 
            this.Value_Box.Enabled = false;
            this.Value_Box.Location = new System.Drawing.Point(303, 138);
            this.Value_Box.Name = "Value_Box";
            this.Value_Box.Size = new System.Drawing.Size(160, 27);
            this.Value_Box.TabIndex = 13;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(303, 28);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(160, 27);
            this.ID_Box.TabIndex = 12;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Identifier Name";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(120, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(177, 24);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Constructor Argument";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Contructor_Args
            // 
            this.Contructor_Args.Enabled = false;
            this.Contructor_Args.Location = new System.Drawing.Point(303, 84);
            this.Contructor_Args.Name = "Contructor_Args";
            this.Contructor_Args.Size = new System.Drawing.Size(160, 27);
            this.Contructor_Args.TabIndex = 17;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(120, 187);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(166, 24);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Create New Instance";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Add_String_Here
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Contructor_Args);
            this.Controls.Add(this.Add_New_Line);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Value_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label2);
            this.Name = "Add_String_Here";
            this.Text = "Add_String";
            this.Load += new System.EventHandler(this.Add_String_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Add_New_Line;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Value_Box;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox Contructor_Args;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}