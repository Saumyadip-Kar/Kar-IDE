
namespace Kar_IDE
{
    partial class Add_Method
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
            this.ret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pCheck = new System.Windows.Forms.CheckBox();
            this.param = new System.Windows.Forms.TextBox();
            this.Add_New_Line = new System.Windows.Forms.CheckBox();
            this.add_button = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ret
            // 
            this.ret.AutoCompleteCustomSource.AddRange(new string[] {
            "void",
            "byte",
            "short",
            "char",
            "int",
            "long",
            "float",
            "double",
            "boolean",
            "String"});
            this.ret.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ret.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ret.Location = new System.Drawing.Point(303, 100);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(160, 27);
            this.ret.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Return Type";
            // 
            // pCheck
            // 
            this.pCheck.AutoSize = true;
            this.pCheck.Location = new System.Drawing.Point(120, 160);
            this.pCheck.Name = "pCheck";
            this.pCheck.Size = new System.Drawing.Size(104, 24);
            this.pCheck.TabIndex = 37;
            this.pCheck.Text = "Parameters";
            this.pCheck.UseVisualStyleBackColor = true;
            this.pCheck.CheckedChanged += new System.EventHandler(this.pCheck_CheckedChanged);
            // 
            // param
            // 
            this.param.Enabled = false;
            this.param.Location = new System.Drawing.Point(303, 157);
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(160, 27);
            this.param.TabIndex = 36;
            // 
            // Add_New_Line
            // 
            this.Add_New_Line.AutoSize = true;
            this.Add_New_Line.Location = new System.Drawing.Point(120, 220);
            this.Add_New_Line.Name = "Add_New_Line";
            this.Add_New_Line.Size = new System.Drawing.Size(124, 24);
            this.Add_New_Line.TabIndex = 35;
            this.Add_New_Line.Text = "Add New Line";
            this.Add_New_Line.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(251, 267);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 42);
            this.add_button.TabIndex = 34;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(303, 43);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(160, 27);
            this.ID_Box.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Identifier Name";
            // 
            // Add_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.ret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pCheck);
            this.Controls.Add(this.param);
            this.Controls.Add(this.Add_New_Line);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label2);
            this.Name = "Add_Method";
            this.Text = "Add_Method";
            this.Load += new System.EventHandler(this.Add_Method_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pCheck;
        private System.Windows.Forms.TextBox param;
        private System.Windows.Forms.CheckBox Add_New_Line;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label2;
    }
}