namespace ObjednavkaPizzy;

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
        label3 = new System.Windows.Forms.Label();
        numPocetMalych = new System.Windows.Forms.NumericUpDown();
        numPocetVelkych = new System.Windows.Forms.NumericUpDown();
        button1 = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        vyslednaCena = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)numPocetMalych).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPocetVelkych).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(483, 222);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(303, 63);
        label1.TabIndex = 0;
        label1.Text = "Objednávka Pizzy";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label2.Location = new System.Drawing.Point(314, 352);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(250, 63);
        label2.TabIndex = 1;
        label2.Text = "Počet malých pizz :";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label3.Location = new System.Drawing.Point(314, 459);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(250, 63);
        label3.TabIndex = 2;
        label3.Text = "Počet velkých pizz :";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // numPocetMalych
        // 
        numPocetMalych.Location = new System.Drawing.Point(701, 372);
        numPocetMalych.Name = "numPocetMalych";
        numPocetMalych.Size = new System.Drawing.Size(227, 31);
        numPocetMalych.TabIndex = 3;
        numPocetMalych.Value = new decimal(new int[] { 15, 0, 0, 0 });
        // 
        // numPocetVelkych
        // 
        numPocetVelkych.Location = new System.Drawing.Point(701, 479);
        numPocetVelkych.Name = "numPocetVelkych";
        numPocetVelkych.Size = new System.Drawing.Size(227, 31);
        numPocetVelkych.TabIndex = 4;
        numPocetVelkych.Value = new decimal(new int[] { 30, 0, 0, 0 });
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button1.Location = new System.Drawing.Point(701, 565);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(227, 67);
        button1.TabIndex = 5;
        button1.Text = "Spočítej cenu";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label4.Location = new System.Drawing.Point(314, 669);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(250, 63);
        label4.TabIndex = 6;
        label4.Text = "Celková cena :";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // vyslednaCena
        // 
        vyslednaCena.Location = new System.Drawing.Point(701, 688);
        vyslednaCena.Name = "vyslednaCena";
        vyslednaCena.Size = new System.Drawing.Size(227, 31);
        vyslednaCena.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1258, 1004);
        Controls.Add(vyslednaCena);
        Controls.Add(label4);
        Controls.Add(button1);
        Controls.Add(numPocetVelkych);
        Controls.Add(numPocetMalych);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)numPocetMalych).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPocetVelkych).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox vyslednaCena;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.NumericUpDown numPocetVelkych;

    private System.Windows.Forms.NumericUpDown numPocetMalych;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}