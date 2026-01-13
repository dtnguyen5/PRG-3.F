namespace Spropitne;

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
        nudPrice = new System.Windows.Forms.NumericUpDown();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        nudTip = new System.Windows.Forms.NumericUpDown();
        nudPeople = new System.Windows.Forms.NumericUpDown();
        btncalc = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        lblTotal = new System.Windows.Forms.Label();
        lblPerPerson = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        txtHistory = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTip).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudPeople).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.ForeColor = System.Drawing.SystemColors.Control;
        label1.Location = new System.Drawing.Point(269, 72);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 30);
        label1.TabIndex = 0;
        label1.Text = "Částka";
        // 
        // nudPrice
        // 
        nudPrice.Location = new System.Drawing.Point(414, 72);
        nudPrice.Name = "nudPrice";
        nudPrice.Size = new System.Drawing.Size(123, 23);
        nudPrice.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label2.ForeColor = System.Drawing.SystemColors.Control;
        label2.Location = new System.Drawing.Point(269, 134);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(139, 30);
        label2.TabIndex = 2;
        label2.Text = "Spropitné (%)";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label3.ForeColor = System.Drawing.SystemColors.Control;
        label3.Location = new System.Drawing.Point(269, 196);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 30);
        label3.TabIndex = 3;
        label3.Text = "Počet lidí";
        // 
        // nudTip
        // 
        nudTip.Location = new System.Drawing.Point(414, 134);
        nudTip.Name = "nudTip";
        nudTip.Size = new System.Drawing.Size(123, 23);
        nudTip.TabIndex = 4;
        // 
        // nudPeople
        // 
        nudPeople.Location = new System.Drawing.Point(414, 205);
        nudPeople.Name = "nudPeople";
        nudPeople.Size = new System.Drawing.Size(123, 23);
        nudPeople.TabIndex = 5;
        // 
        // btncalc
        // 
        btncalc.Location = new System.Drawing.Point(269, 260);
        btncalc.Name = "btncalc";
        btncalc.Size = new System.Drawing.Size(268, 37);
        btncalc.TabIndex = 6;
        btncalc.Text = "Spočítat";
        btncalc.UseVisualStyleBackColor = true;
        btncalc.Click += btncalc_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label4.ForeColor = System.Drawing.SystemColors.Control;
        label4.Location = new System.Drawing.Point(269, 320);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(128, 30);
        label4.TabIndex = 7;
        label4.Text = "Jeden zaplatí";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label6.ForeColor = System.Drawing.SystemColors.Control;
        label6.Location = new System.Drawing.Point(269, 368);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(128, 30);
        label6.TabIndex = 9;
        label6.Text = "Celkem";
        // 
        // lblTotal
        // 
        lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        lblTotal.ForeColor = System.Drawing.SystemColors.Control;
        lblTotal.Location = new System.Drawing.Point(485, 320);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new System.Drawing.Size(52, 30);
        lblTotal.TabIndex = 10;
        lblTotal.Text = "0 Kč";
        // 
        // lblPerPerson
        // 
        lblPerPerson.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        lblPerPerson.ForeColor = System.Drawing.SystemColors.Control;
        lblPerPerson.Location = new System.Drawing.Point(485, 368);
        lblPerPerson.Name = "lblPerPerson";
        lblPerPerson.Size = new System.Drawing.Size(52, 30);
        lblPerPerson.TabIndex = 11;
        lblPerPerson.Text = "0 Kč";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label8.ForeColor = System.Drawing.SystemColors.Control;
        label8.Location = new System.Drawing.Point(269, 442);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(128, 30);
        label8.TabIndex = 12;
        label8.Text = "Historie";
        // 
        // txtHistory
        // 
        txtHistory.Location = new System.Drawing.Point(269, 498);
        txtHistory.Multiline = true;
        txtHistory.Name = "txtHistory";
        txtHistory.ReadOnly = true;
        txtHistory.Size = new System.Drawing.Size(268, 137);
        txtHistory.TabIndex = 13;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Indigo;
        ClientSize = new System.Drawing.Size(855, 704);
        Controls.Add(txtHistory);
        Controls.Add(label8);
        Controls.Add(lblPerPerson);
        Controls.Add(lblTotal);
        Controls.Add(label6);
        Controls.Add(label4);
        Controls.Add(btncalc);
        Controls.Add(nudPeople);
        Controls.Add(nudTip);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(nudPrice);
        Controls.Add(label1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTip).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudPeople).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblPerPerson;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtHistory;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.NumericUpDown nudTip;
    private System.Windows.Forms.NumericUpDown nudPeople;
    private System.Windows.Forms.Button btncalc;

    private System.Windows.Forms.NumericUpDown nudPrice;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    #endregion
}