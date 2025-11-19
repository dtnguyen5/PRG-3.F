namespace WinFormsApp1;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(121, 69);
        label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(510, 124);
        label1.TabIndex = 0;
        label1.Visible = false;
        label1.Click += label1_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(1591, 441);
        button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(517, 198);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Visible = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(102, 87);
        button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(581, 277);
        button2.TabIndex = 2;
        button2.Text = "Cookies";
        button2.UseVisualStyleBackColor = true;
        button2.Visible = false;
        button2.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(22F, 51F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.MidnightBlue;
        ClientSize = new System.Drawing.Size(2564, 1410);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Location = new System.Drawing.Point(22, 22);
        Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label1;

    #endregion
}