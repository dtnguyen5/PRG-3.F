namespace Demo1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        button7 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(225, 175);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(306, 40);
        label1.TabIndex = 0;
        label1.Text = "I am a Label!";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.Click += label1_Click;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button2.Location = new System.Drawing.Point(380, 223);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(150, 37);
        button2.TabIndex = 2;
        button2.Text = "Font";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button1.Location = new System.Drawing.Point(225, 223);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(150, 37);
        button1.TabIndex = 3;
        button1.Text = "Text";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button3.Location = new System.Drawing.Point(225, 266);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(150, 37);
        button3.TabIndex = 5;
        button3.Text = "Color";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button4.Location = new System.Drawing.Point(380, 266);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(150, 37);
        button4.TabIndex = 4;
        button4.Text = "Border";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button5.Location = new System.Drawing.Point(225, 309);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(150, 37);
        button5.TabIndex = 7;
        button5.Text = "AutoSize";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button6.Location = new System.Drawing.Point(380, 309);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(150, 37);
        button6.TabIndex = 6;
        button6.Text = "Move";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button7.Location = new System.Drawing.Point(225, 352);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(306, 37);
        button7.TabIndex = 8;
        button7.Text = "Reset";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        BackColor = System.Drawing.Color.MidnightBlue;
        ClientSize = new System.Drawing.Size(784, 601);
        Controls.Add(button7);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button3);
        Controls.Add(button4);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(label1);
        Cursor = System.Windows.Forms.Cursors.No;
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button7;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}