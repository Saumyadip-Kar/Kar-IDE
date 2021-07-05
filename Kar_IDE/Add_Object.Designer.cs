
namespace Kar_IDE
{
    partial class Add_Object
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Consructor_Args = new System.Windows.Forms.TextBox();
            this.Add_New_Line = new System.Windows.Forms.CheckBox();
            this.add_button = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.class_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(120, 146);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(177, 24);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Constructor Argument";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Consructor_Args
            // 
            this.Consructor_Args.Enabled = false;
            this.Consructor_Args.Location = new System.Drawing.Point(303, 143);
            this.Consructor_Args.Name = "Consructor_Args";
            this.Consructor_Args.Size = new System.Drawing.Size(160, 27);
            this.Consructor_Args.TabIndex = 27;
            // 
            // Add_New_Line
            // 
            this.Add_New_Line.AutoSize = true;
            this.Add_New_Line.Location = new System.Drawing.Point(120, 206);
            this.Add_New_Line.Name = "Add_New_Line";
            this.Add_New_Line.Size = new System.Drawing.Size(124, 24);
            this.Add_New_Line.TabIndex = 26;
            this.Add_New_Line.Text = "Add New Line";
            this.Add_New_Line.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(251, 253);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 42);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(303, 29);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(160, 27);
            this.ID_Box.TabIndex = 22;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identifier Name";
            // 
            // class_name
            // 
            this.class_name.Location = new System.Drawing.Point(303, 86);
            this.class_name.Name = "class_name";
            this.class_name.Size = new System.Drawing.Size(160, 27);
            this.class_name.TabIndex = 31;
            this.class_name.TextChanged += new System.EventHandler(this.class_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Class Name";
            // 
            // Add_Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 320);
            this.Controls.Add(this.class_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Consructor_Args);
            this.Controls.Add(this.Add_New_Line);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label2);
            this.Name = "Add_Object";
            this.Text = "Add_Object";
            this.Load += new System.EventHandler(this.Add_Object_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox Consructor_Args;
        private System.Windows.Forms.CheckBox Add_New_Line;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox class_name;
        private System.Windows.Forms.Label label1;
    }
}