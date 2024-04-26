namespace CheckList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToDoTbx = new TextBox();
            ToDoBtn = new Button();
            ToDoListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // ToDoTbx
            // 
            ToDoTbx.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ToDoTbx.Location = new Point(97, 62);
            ToDoTbx.Margin = new Padding(5, 4, 5, 4);
            ToDoTbx.Name = "ToDoTbx";
            ToDoTbx.Size = new Size(736, 52);
            ToDoTbx.TabIndex = 0;
            ToDoTbx.TextChanged += textBox1_TextChanged;
            // 
            // ToDoBtn
            // 
            ToDoBtn.FlatStyle = FlatStyle.Popup;
            ToDoBtn.Font = new Font("Verdana", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            ToDoBtn.ForeColor = SystemColors.Highlight;
            ToDoBtn.Location = new Point(909, 62);
            ToDoBtn.Name = "ToDoBtn";
            ToDoBtn.Size = new Size(288, 52);
            ToDoBtn.TabIndex = 1;
            ToDoBtn.Text = "Add ToDo";
            ToDoBtn.UseVisualStyleBackColor = true;
            ToDoBtn.Click += button1_Click;
            // 
            // ToDoListBox
            // 
            ToDoListBox.FormattingEnabled = true;
            ToDoListBox.Location = new Point(97, 160);
            ToDoListBox.Name = "ToDoListBox";
            ToDoListBox.Size = new Size(1100, 592);
            ToDoListBox.TabIndex = 2;
            ToDoListBox.Click += ToDoListBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(23F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 851);
            Controls.Add(ToDoListBox);
            Controls.Add(ToDoBtn);
            Controls.Add(ToDoTbx);
            Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ToDoTbx;
        private Button ToDoBtn;
        private CheckedListBox ToDoListBox;
    }
}
