namespace menuBuilder.View
{
  partial class FEditMenuElem
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.OpenFileButton = new System.Windows.Forms.Button();
      this.Save = new System.Windows.Forms.Button();
      this.Cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Заголовок";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Описание";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 42);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Файл";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(142, 13);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(412, 20);
      this.textBox1.TabIndex = 3;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(142, 39);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(412, 20);
      this.textBox2.TabIndex = 3;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(142, 65);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox3.Size = new System.Drawing.Size(412, 171);
      this.textBox3.TabIndex = 3;
      // 
      // OpenFileButton
      // 
      this.OpenFileButton.Location = new System.Drawing.Point(61, 36);
      this.OpenFileButton.Name = "OpenFileButton";
      this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
      this.OpenFileButton.TabIndex = 0;
      this.OpenFileButton.Text = "Открыть";
      this.OpenFileButton.UseVisualStyleBackColor = true;
      this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(16, 183);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(75, 23);
      this.Save.TabIndex = 4;
      this.Save.Text = "Сохранить";
      this.Save.UseVisualStyleBackColor = true;
      // 
      // Cancel
      // 
      this.Cancel.Location = new System.Drawing.Point(16, 212);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(75, 23);
      this.Cancel.TabIndex = 4;
      this.Cancel.Text = "Отмена";
      this.Cancel.UseVisualStyleBackColor = true;
      // 
      // FEditMenuElem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(558, 241);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.Save);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.OpenFileButton);
      this.Name = "FEditMenuElem";
      this.Text = "FEditMenuElem";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button OpenFileButton;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Button Cancel;
  }
}