namespace menuBuilder
{
  partial class FMainForm
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.About = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
      this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
      this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
      this.menuElemsPanel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.add = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.HeaderText = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(980, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateButton,
            this.OpenButton,
            this.SaveButton,
            this.ExitButton});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // оПрограммеToolStripMenuItem
      // 
      this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
      this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
      this.оПрограммеToolStripMenuItem.Text = "О программе";
      // 
      // About
      // 
      this.About.Name = "About";
      this.About.Size = new System.Drawing.Size(152, 22);
      this.About.Text = "справка";
      // 
      // SaveButton
      // 
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(152, 22);
      this.SaveButton.Text = "Сохранить";
      // 
      // ExitButton
      // 
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(152, 22);
      this.ExitButton.Text = "Выход";
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // OpenButton
      // 
      this.OpenButton.Name = "OpenButton";
      this.OpenButton.Size = new System.Drawing.Size(152, 22);
      this.OpenButton.Text = "Открыть";
      this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
      // 
      // CreateButton
      // 
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(152, 22);
      this.CreateButton.Text = "Создать";
      // 
      // menuElemsPanel
      // 
      this.menuElemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.menuElemsPanel.AutoScroll = true;
      this.menuElemsPanel.Location = new System.Drawing.Point(6, 19);
      this.menuElemsPanel.Name = "menuElemsPanel";
      this.menuElemsPanel.Size = new System.Drawing.Size(799, 237);
      this.menuElemsPanel.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.menuElemsPanel);
      this.groupBox1.Location = new System.Drawing.Point(13, 95);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(955, 256);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Элементы меню";
      // 
      // менюToolStripMenuItem
      // 
      this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add});
      this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
      this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.менюToolStripMenuItem.Text = "Меню";
      // 
      // add
      // 
      this.add.Name = "add";
      this.add.Size = new System.Drawing.Size(175, 22);
      this.add.Text = "Добавить элемент";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.HeaderText);
      this.groupBox2.Location = new System.Drawing.Point(13, 31);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(364, 58);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Главная надпись";
      // 
      // HeaderText
      // 
      this.HeaderText.Location = new System.Drawing.Point(6, 19);
      this.HeaderText.Name = "HeaderText";
      this.HeaderText.Size = new System.Drawing.Size(350, 20);
      this.HeaderText.TabIndex = 0;
      // 
      // FMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(980, 363);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FMainForm";
      this.Text = "Конфигуратор";
      this.Load += new System.EventHandler(this.FMainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem About;
    private System.Windows.Forms.ToolStripMenuItem OpenButton;
    private System.Windows.Forms.ToolStripMenuItem SaveButton;
    private System.Windows.Forms.ToolStripMenuItem ExitButton;
    private System.Windows.Forms.ToolStripMenuItem CreateButton;
    private System.Windows.Forms.Panel menuElemsPanel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem add;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox HeaderText;
  }
}

