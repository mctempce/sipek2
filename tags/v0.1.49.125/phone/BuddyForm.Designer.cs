namespace Sipek
{
  partial class BuddyForm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.buttonOk = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxNumber = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.checkBox1);
      this.groupBox1.Controls.Add(this.buttonOk);
      this.groupBox1.Controls.Add(this.buttonCancel);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.textBoxNumber);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.textBoxName);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(247, 194);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(139, 159);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 8;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(16, 159);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 7;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(93, 85);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(44, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Melody";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(40, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Address";
      // 
      // textBoxNumber
      // 
      this.textBoxNumber.Location = new System.Drawing.Point(93, 59);
      this.textBoxNumber.Name = "textBoxNumber";
      this.textBoxNumber.Size = new System.Drawing.Size(121, 20);
      this.textBoxNumber.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Display Name";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(93, 33);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(121, 20);
      this.textBoxName.TabIndex = 0;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(93, 113);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(71, 17);
      this.checkBox1.TabIndex = 9;
      this.checkBox1.Text = "Presence";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // BuddyForm
      // 
      this.AcceptButton = this.buttonOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(247, 194);
      this.Controls.Add(this.groupBox1);
      this.Name = "BuddyForm";
      this.Text = "Buddy Room";
      this.Activated += new System.EventHandler(this.BuddyForm_Activated);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxNumber;
    private System.Windows.Forms.CheckBox checkBox1;
  }
}