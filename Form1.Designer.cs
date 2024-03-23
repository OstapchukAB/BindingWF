namespace BindingWF;

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
        listBox1 = new ListBox();
        dataGridView1 = new DataGridView();
        button1 = new Button();
        label1 = new Label();
        button2 = new Button();
        button3 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 30;
        listBox1.Location = new Point(14, 15);
        listBox1.Margin = new Padding(5, 6, 5, 6);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(467, 184);
        listBox1.TabIndex = 0;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(510, 15);
        dataGridView1.Margin = new Padding(5, 6, 5, 6);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(508, 184);
        dataGridView1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new Point(14, 281);
        button1.Margin = new Padding(5, 6, 5, 6);
        button1.Name = "button1";
        button1.Size = new Size(133, 53);
        button1.TabIndex = 2;
        button1.Text = "+";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 221);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(68, 30);
        label1.TabIndex = 3;
        label1.Text = "label1";
        // 
        // button2
        // 
        button2.Location = new Point(170, 281);
        button2.Margin = new Padding(5, 6, 5, 6);
        button2.Name = "button2";
        button2.Size = new Size(133, 53);
        button2.TabIndex = 4;
        button2.Text = "Очистить";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(14, 346);
        button3.Margin = new Padding(5, 6, 5, 6);
        button3.Name = "button3";
        button3.Size = new Size(133, 53);
        button3.TabIndex = 5;
        button3.Text = "Delete";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1139, 441);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Controls.Add(listBox1);
        Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Margin = new Padding(5, 6, 5, 6);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox listBox1;
    private DataGridView dataGridView1;
    private Button button1;
    private Label label1;
    private Button button2;
    private Button button3;
}
