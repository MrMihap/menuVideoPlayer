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
      this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
      this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
      this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addElem = new System.Windows.Forms.ToolStripMenuItem();
      this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.About = new System.Windows.Forms.ToolStripMenuItem();
      this.menuElemsPanel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.HeaderText = new System.Windows.Forms.TextBox();
      this.AddElemButton = new System.Windows.Forms.Button();
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
      // CreateButton
      // 
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(132, 22);
      this.CreateButton.Text = "Создать";
      this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
      // 
      // OpenButton
      // 
      this.OpenButton.Name = "OpenButton";
      this.OpenButton.Size = new System.Drawing.Size(132, 22);
      this.OpenButton.Text = "Открыть";
      this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
      // 
      // SaveButton
      // 
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(132, 22);
      this.SaveButton.Text = "Сохранить";
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(132, 22);
      this.ExitButton.Text = "Выход";
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // менюToolStripMenuItem
      // 
      this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addElem});
      this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
      this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.менюToolStripMenuItem.Text = "Меню";
      // 
      // addElem
      // 
      this.addElem.Name = "addElem";
      this.addElem.Size = new System.Drawing.Size(175, 22);
      this.addElem.Text = "Добавить элемент";
      this.addElem.Click += new System.EventHandler(this.addElem_Click);
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
      this.About.Size = new System.Drawing.Size(118, 22);
      this.About.Text = "справка";
      // 
      // menuElemsPanel
      // 
      this.menuElemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.menuElemsPanel.AutoScroll = true;
      this.menuElemsPanel.Location = new System.Drawing.Point(6, 19);
      this.menuElemsPanel.Name = "menuElemsPanel";
      this.menuElemsPanel.Size = new System.Drawing.Size(943, 237);
      this.menuElemsPanel.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.groupBox1.Controls.Add(this.menuElemsPanel);
      this.groupBox1.Location = new System.Drawing.Point(13, 95);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(955, 256);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Элементы меню";
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
      this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
      // 
      // HeaderText
      // 
      this.HeaderText.Location = new System.Drawing.Point(6, 19);
      this.HeaderText.Name = "HeaderText";
      this.HeaderText.Size = new System.Drawing.Size(350, 20);
      this.HeaderText.TabIndex = 0;
      this.HeaderText.TextChanged += new System.EventHandler(this.HeaderText_TextChanged);
      // 
      // AddElemButton
      // 
      this.AddElemButton.Location = new System.Drawing.Point(383, 31);
      this.AddElemButton.Name = "AddElemButton";
      this.AddElemButton.Size = new System.Drawing.Size(336, 58);
      this.AddElemButton.TabIndex = 4;
      this.AddElemButton.Text = "Добавить новый элемент меню";
      this.AddElemButton.UseVisualStyleBackColor = true;
      this.AddElemButton.Click += new System.EventHandler(this.addElem_Click);
      // 
      // FMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(980, 363);
      this.Controls.Add(this.AddElemButton);
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
    private System.Windows.Forms.ToolStripMenuItem addElem;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox HeaderText;
    private System.Windows.Forms.Button AddElemButton;
  }
}

