namespace HodnoceniTestu;

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
        label2 = new System.Windows.Forms.Label();
        numBody = new System.Windows.Forms.NumericUpDown();
        button1 = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        vysledek = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)numBody).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(456, 231);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(358, 85);
        label1.TabIndex = 0;
        label1.Text = "Hodnocení testu";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label2.Location = new System.Drawing.Point(357, 381);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(224, 40);
        label2.TabIndex = 1;
        label2.Text = "Počet bodů (0–100)";
        // 
        // numBody
        // 
        numBody.Location = new System.Drawing.Point(701, 385);
        numBody.Name = "numBody";
        numBody.Size = new System.Drawing.Size(215, 31);
        numBody.TabIndex = 2;
        numBody.Value = new decimal(new int[] { 82, 0, 0, 0 });
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button1.Location = new System.Drawing.Point(701, 467);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(215, 56);
        button1.TabIndex = 3;
        button1.Text = "Urči známku";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label3.Location = new System.Drawing.Point(357, 565);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(146, 37);
        label3.TabIndex = 4;
        label3.Text = "Výsledek :";
        // 
        // vysledek
        // 
        vysledek.Location = new System.Drawing.Point(701, 568);
        vysledek.Name = "vysledek";
        vysledek.Size = new System.Drawing.Size(251, 31);
        vysledek.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1237, 1005);
        Controls.Add(vysledek);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(numBody);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)numBody).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox vysledek;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.NumericUpDown numBody;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}