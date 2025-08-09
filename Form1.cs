// Hi! This is the backbone of She!n Essay.
using Microsoft.VisualBasic;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace She_nEssay
{
    public partial class Form1 : Form
    {

        private FontDialog fontDialog1 = new FontDialog();
        private ColorDialog colorDialog1 = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears RichTextBox
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file prompt
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "She!n Essay Files (*.she!ss)|*.she!ss|All Files (*.*)|*.*",
                Title = "Open She!n Essay File"
            };

            // Reads contents of textbox and openes (does not guarantee formatting)
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save file prompt
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "She!n Essay Files (*.she!ss)|*.she!ss|All Files (*.*)|*.*",
                Title = "Save She!n Essay File"
            };

            // Whatever is written in the textbox is saved as well
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Got to work...
            MessageBox.Show("Sorry! This feature is not implemented yet. Check back later", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LEAVE. NOW.
            System.Windows.Forms.Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void aboutShenEssayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // About She!n Essay
            MessageBox.Show("She!n Essay \n" + "Version 1.0.4 \n" + "Developed by Ligma Techlologies \n" + "Copyright © Ligma Techlologies 2025. All rights reserved \n" + "NOT AFFILIATED WITH SHEIN CLOTHING BRAND FOR GODS SAKE", "About She!n Essay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutShenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // About She!n <3
            MessageBox.Show("She!n is a productivity tool that is completely open-source and can be made to do and feel like how you want to by just coding. \n" + "Support the She!n project by starring our Github repo.\n" + "Copyright © Ligma Techlologies 2025. All rights reserved \n" + "NOT AFFILIATED WITH SHEIN CLOTHING BRAND FOR GODS SAKE", "About She!n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Bolds out selected text in richTextBox1

            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);

        }

        private void italicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Italisizes selected text in richTextBox1

            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);

        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Underlines selected text in richTextBox1

            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void fontTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stolen from MS documentation. Probably works.
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }

            // Change font of selected text to selected font
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
            {
                richTextBox1.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, SelectedText_Font.Style);
            }
        }

        private void colorPalleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Same fate...
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPalleteToolStripMenuItem.BackColor = colorDialog1.Color;
            }

            // Change color of selected text to selected color
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void bulletPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Adds bullet points to selected text
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
            if (richTextBox1.SelectionLength == 0)
                return;

            // Add space of like 10px to the bullet point from the margain
            richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectionHangingIndent = 5;

        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void marginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Welcome to BetterMargin Setup. \n" + "BetterMargin allows you to set the margin of the document to be what you feel like for a more personalized experience. \n" + " Please click OK to proceed with the Setup. If you wish to opt out, click Cancel","BetterMargin Wizard", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // If user presses OK, show margin setup dialog
            if (result == DialogResult.OK)
            {
                // Margin setup dialog
                string marginInput = Interaction.InputBox("Enter margin size (in pixels):", "BetterMargin Wizard");

                if (int.TryParse(marginInput, out int marginPx))
                {
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionIndent = marginPx;

                    MessageBox.Show($"Margin set to {marginPx}px. \n" + "The BetterMargin setup is finished","BetterMargin Wizard",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    // Be vague as possible. Big tech companies love this, so why can't we? Except for the fact we don't log your data to an FTP server in Krygyzstan or wherever.
                    MessageBox.Show("Oh No! an error has occured. It could be because you cancelled out of the setup or you entered in an invalid input. Please try again.", "BetterMargin Wizard",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
            // Cancel
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You have cancelled the BetterMargin Setup. If you cancelled out by mistake, please try again.", "BetterMargain Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
