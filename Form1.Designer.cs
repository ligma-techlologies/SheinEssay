// Hi! This is what beautifies She!n Essay.
namespace She_nEssay
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem1 = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicsToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            fontTypeToolStripMenuItem = new ToolStripMenuItem();
            colorPalleteToolStripMenuItem = new ToolStripMenuItem();
            pointsToolStripMenuItem = new ToolStripMenuItem();
            bulletPointsToolStripMenuItem = new ToolStripMenuItem();
            documentToolStripMenuItem = new ToolStripMenuItem();
            marginToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutShenEssayToolStripMenuItem = new ToolStripMenuItem();
            aboutShenToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem1, documentToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 21);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(120, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(120, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(120, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(120, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(120, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem1
            // 
            formatToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { textToolStripMenuItem, pointsToolStripMenuItem });
            formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            formatToolStripMenuItem1.Size = new Size(59, 21);
            formatToolStripMenuItem1.Text = "Format";
            formatToolStripMenuItem1.Click += formatToolStripMenuItem_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, italicsToolStripMenuItem, underlineToolStripMenuItem, fontToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(110, 22);
            textToolStripMenuItem.Text = "Text";
            textToolStripMenuItem.Click += textToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(129, 22);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicsToolStripMenuItem
            // 
            italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            italicsToolStripMenuItem.Size = new Size(129, 22);
            italicsToolStripMenuItem.Text = "Italics";
            italicsToolStripMenuItem.Click += italicsToolStripMenuItem_Click;
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.Size = new Size(129, 22);
            underlineToolStripMenuItem.Text = "Underline";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontTypeToolStripMenuItem, colorPalleteToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(129, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // fontTypeToolStripMenuItem
            // 
            fontTypeToolStripMenuItem.Name = "fontTypeToolStripMenuItem";
            fontTypeToolStripMenuItem.Size = new Size(147, 22);
            fontTypeToolStripMenuItem.Text = "Font Type";
            fontTypeToolStripMenuItem.Click += fontTypeToolStripMenuItem_Click;
            // 
            // colorPalleteToolStripMenuItem
            // 
            colorPalleteToolStripMenuItem.Name = "colorPalleteToolStripMenuItem";
            colorPalleteToolStripMenuItem.Size = new Size(147, 22);
            colorPalleteToolStripMenuItem.Text = "Color Pallete";
            colorPalleteToolStripMenuItem.Click += colorPalleteToolStripMenuItem_Click;
            // 
            // pointsToolStripMenuItem
            // 
            pointsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bulletPointsToolStripMenuItem });
            pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            pointsToolStripMenuItem.Size = new Size(110, 22);
            pointsToolStripMenuItem.Text = "Points";
            pointsToolStripMenuItem.Click += pointsToolStripMenuItem_Click;
            // 
            // bulletPointsToolStripMenuItem
            // 
            bulletPointsToolStripMenuItem.Name = "bulletPointsToolStripMenuItem";
            bulletPointsToolStripMenuItem.Size = new Size(148, 22);
            bulletPointsToolStripMenuItem.Text = "Bullet Points";
            bulletPointsToolStripMenuItem.Click += bulletPointsToolStripMenuItem_Click;
            // 
            // documentToolStripMenuItem
            // 
            documentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marginToolStripMenuItem });
            documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            documentToolStripMenuItem.Size = new Size(73, 21);
            documentToolStripMenuItem.Text = "Document";
            documentToolStripMenuItem.Click += documentToolStripMenuItem_Click;
            // 
            // marginToolStripMenuItem
            // 
            marginToolStripMenuItem.Name = "marginToolStripMenuItem";
            marginToolStripMenuItem.Size = new Size(180, 22);
            marginToolStripMenuItem.Text = "Margin";
            marginToolStripMenuItem.Click += marginToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutShenEssayToolStripMenuItem, aboutShenToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 21);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // aboutShenEssayToolStripMenuItem
            // 
            aboutShenEssayToolStripMenuItem.Name = "aboutShenEssayToolStripMenuItem";
            aboutShenEssayToolStripMenuItem.Size = new Size(177, 22);
            aboutShenEssayToolStripMenuItem.Text = "About She!n Essay";
            aboutShenEssayToolStripMenuItem.Click += aboutShenEssayToolStripMenuItem_Click;
            // 
            // aboutShenToolStripMenuItem
            // 
            aboutShenToolStripMenuItem.Name = "aboutShenToolStripMenuItem";
            aboutShenToolStripMenuItem.Size = new Size(177, 22);
            aboutShenToolStripMenuItem.Text = "About She!n";
            aboutShenToolStripMenuItem.Click += aboutShenToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(32, 19);
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 14F);
            richTextBox1.Location = new Point(0, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox1.Size = new Size(800, 425);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "- She!n Essay";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutShenEssayToolStripMenuItem;
        private ToolStripMenuItem aboutShenToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicsToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem fontTypeToolStripMenuItem;
        private ToolStripMenuItem colorPalleteToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem1;
        private ToolStripMenuItem pointsToolStripMenuItem;
        private ToolStripMenuItem bulletPointsToolStripMenuItem;
        private ToolStripMenuItem documentToolStripMenuItem;
        private ToolStripMenuItem marginToolStripMenuItem;
    }
}
