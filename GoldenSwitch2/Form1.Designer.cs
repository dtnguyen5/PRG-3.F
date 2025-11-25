namespace GoldenSwitch2;

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
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(630, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(106, 37);
        label1.TabIndex = 0;
        label1.Text = "Score: 0\r\n";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label1.Click += label1_Click;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Transparent;
        button1.BackgroundImage = ((System.Drawing.Image)resources.GetObject("button1.BackgroundImage"));
        button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Location = new System.Drawing.Point(342, 285);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(100, 100);
        button1.TabIndex = 1;
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        button1.MouseEnter += CatchMeIfYouCan;
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.Color.Navy;
        ClientSize = new System.Drawing.Size(784, 761);
        Controls.Add(button1);
        Controls.Add(label1);
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}