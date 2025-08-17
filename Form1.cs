// Hi! This is the backbone of She!n Essay.
using Microsoft.VisualBasic;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SpeechLib;

namespace She_nEssay
{
    public partial class Form1 : Form
    {
        private FontDialog fontDialog1 = new FontDialog();
        private ColorDialog colorDialog1 = new ColorDialog();
        private TextBox updateTextBox = new TextBox();

        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new EventHandler(Form1_Resize);
            this.Resize += Form1_Resize;

            // Check for updates on load
            CheckForUpdateAsync("tag_name");
        }

        // Update Prompt thing...
        private async void CheckForUpdateAsync(string versionTagName)
        {
            string currentVersion = "1.0.6";
            string apiUrl = "https://api.github.com/repos/ligma-techlologies/SheinEssay/releases/latest";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("She!n Essay GitHub Request Tool");

                try
                {
                    var response = await client.GetStringAsync(apiUrl);
                    using (JsonDocument doc = JsonDocument.Parse(response))
                    {
                        if (doc.RootElement.TryGetProperty(versionTagName, out JsonElement versionElement) && versionElement.ValueKind == JsonValueKind.String)
                        {
                            string? latestVersion = versionElement.GetString();

                            if (latestVersion != null && Version.TryParse(currentVersion, out var current) && Version.TryParse(latestVersion, out var latest))
                            {
                                if (current < latest)
                                {
                                    MessageBox.Show($"Oh No! You are running ({currentVersion}) which is outdated!\nA new version ({latestVersion}) is available!\nPlease update at: https://github.com/ligma-techlologies/SheinEssay/releases", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    updateTextBox.Visible = false;
                                }
                            }
                            // No message shown if version parsing fails
                        }
                    }
                }
                catch
                {
                    // If there is no network, optionally show a message or keep hidden
                    updateTextBox.Visible = false;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears RichTextBox
            richTextBox1.Clear();
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
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
                richTextBox1.SelectionStart = 0;
                richTextBox1.ScrollToCaret();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save file prompt
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "She!n Essay Files (*.she!ss)|*.she!ss",
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
            SaveFileDialog saveasFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Save as File"
            };

            if (saveasFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveasFileDialog.FileName, richTextBox1.Text);
            }
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
            MessageBox.Show("She!n Essay \n" + "Version 1.0.6 \n" + "Developed by Ligma Techlologies \n" + "Copyright © Ligma Techlologies 2025. All rights reserved \n" + "NOT AFFILIATED WITH SHEIN CLOTHING BRAND FOR GODS SAKE", "About She!n Essay", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Make sure the bullet point is always has that margin directly
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
            KeyPress += (s, e) =>
            {
                // If the user presses Enter, add a new bullet point
                if (e.KeyChar == (char)Keys.Enter)
                {
                    richTextBox1.SelectionBullet = true;
                    e.Handled = true;
                }
            };

            // Add space of like 10px to the bullet point from the margain
            richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectionHangingIndent = 5;

            // Make sure the bullet points stay until deleted by user
            richTextBox1.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter && richTextBox1.SelectionBullet)
                {
                    richTextBox1.SelectionBullet = true;
                    e.Handled = true;
                }
            };

        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void marginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Welcome to BetterMargin Setup. \n" + "BetterMargin allows you to set the margin of the document to be what you feel like for a more personalized experience. \n" + " Please click OK to proceed with the Setup. If you wish to opt out, click Cancel", "BetterMargin Wizard", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // If user presses OK, show margin setup dialog
            if (result == DialogResult.OK)
            {
                // Margin setup dialog
                string marginInput = Interaction.InputBox("Enter margin size (in pixels):", "BetterMargin Wizard");

                if (int.TryParse(marginInput, out int marginPx))
                {
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionIndent = marginPx;

                    MessageBox.Show($"Margin set to {marginPx}px. \n" + "The BetterMargin setup is finished", "BetterMargin Wizard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Be vague as possible. Big tech companies love this, so why can't we? Except for the fact we don't log your data to an FTP server in Krygyzstan or wherever.
                    MessageBox.Show("Oh No! an error has occured. It could be because you cancelled out of the setup or you entered in an invalid input. Please try again.", "BetterMargin Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Cancel
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You have cancelled the BetterMargin Setup. If you cancelled out by mistake, please try again.", "BetterMargain Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // HAHA! FIXED!
        }

        private void a4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Dock = DockStyle.Left;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            richTextBox1.Width = 595;
            richTextBox1.Height = 842;
            CenterRichTextBox();
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
            MessageBox.Show("Page size set to A4", "Page Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void a3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Dock = DockStyle.Left;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            richTextBox1.Width = 842;
            richTextBox1.Height = 1191;
            CenterRichTextBox();
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
            MessageBox.Show("Page size set to A3", "Page Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
            MessageBox.Show("Page size set to default", "Page Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CenterRichTextBox()
        {
            int x = (this.ClientSize.Width - richTextBox1.Width) / 2;
            int y = (this.ClientSize.Height - richTextBox1.Height) / 2;
            richTextBox1.Location = new Point(x, y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
        }

        private void textTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void headingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 30, FontStyle.Underline, GraphicsUnit.Point);
            // Resets text to normal after heading
            richTextBox1.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 14, FontStyle.Regular, GraphicsUnit.Point);

                }
            };
        }

        private void subheadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 20, FontStyle.Underline, GraphicsUnit.Point);
            // Resets text to normal after subheading
            richTextBox1.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 14, FontStyle.Regular, GraphicsUnit.Point);

                }
            };
        }

        private void updatingShenEssayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To update She!n Essay: \n" + "Uninstall She!n Essay by running the uninstaller at: \n" + "C: ---> Program Files (x86) ---> Ligma Techlologies ---> She!n Essay ---> Uninstall She!n Essay \n" + "Go to: https://github.com/ligma-techlologies/SheinEssay/releases/latest \n" + "Download the latest version \n" + "Run the installer \n" + "Click on the desktop shortcut \n" + "You are done!", "Updating She!n Essay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }


        private void resumeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Opens the resume application .she!ss file template
            string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Resume.she!ss");
            if (File.Exists(templatePath))
            {
                richTextBox1.Text = File.ReadAllText(templatePath);
                richTextBox1.SelectionStart = 0;
                richTextBox1.ScrollToCaret();
                MessageBox.Show("Resume template loaded.", "Template", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Resume template not found.\nPlease make sure 'Resume.she!ss' exists in the 'Templates' folder.", "Template Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void jobApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Opens the Job application .she!ss file template
            string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "JobApplication.she!ss");
            if (File.Exists(templatePath))
            {
                richTextBox1.Text = File.ReadAllText(templatePath);
                richTextBox1.SelectionStart = 0;
                richTextBox1.ScrollToCaret();
                MessageBox.Show("Job application template loaded.", "Template", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Job application template not found.\nPlease make sure 'JobApplication.she!ss' exists in the 'Templates' folder.", "Template Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void assistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Leave it blank. For now...
        }

        private void thesaurusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Changes size to A4
            richTextBox1.Dock = DockStyle.Left;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            richTextBox1.Width = 595;
            richTextBox1.Height = 842;
            CenterRichTextBox();
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();

            // Makes a web browser control to open Thesaurus.html
            string thesaurusPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Thesaurus.html");
            if (File.Exists(thesaurusPath))
            {
                // Remove any previous web browser controls and close buttons
                Control browserToRemove = null;
                Control buttonToRemove = null;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is WebBrowser)
                        browserToRemove = ctrl;
                    if (ctrl is Button && ctrl.Tag?.ToString() == "CloseWebBrowser")
                        buttonToRemove = ctrl;
                }
                if (browserToRemove != null)
                {
                    this.Controls.Remove(browserToRemove);
                    browserToRemove.Dispose();
                }
                if (buttonToRemove != null)
                {
                    this.Controls.Remove(buttonToRemove);
                    buttonToRemove.Dispose();
                }

                WebBrowser webBrowser = new WebBrowser
                {
                    Dock = DockStyle.Fill,
                    Url = new Uri(thesaurusPath)
                };
                this.Controls.Add(webBrowser);
                webBrowser.BringToFront();

                // Adds an X which closes the browser
                Button closeButton = new Button
                {
                    Text = "X",
                    Tag = "CloseWebBrowser",
                    Size = new Size(30, 30),
                    Location = new Point(this.ClientSize.Width - 40, 10),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                // If X is clicked
                closeButton.Click += (s, args) =>
                {
                    this.Controls.Remove(webBrowser);
                    webBrowser.Dispose();
                    this.Controls.Remove(closeButton);
                    closeButton.Dispose();

                    richTextBox1.Dock = DockStyle.Fill;
                };
                this.Controls.Add(closeButton);
                closeButton.BringToFront();
            }
            else
            {
                MessageBox.Show("Thesaurus.html not found in the 'Files' folder.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Changes size to A4
            richTextBox1.Dock = DockStyle.Left;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            richTextBox1.Width = 595;
            richTextBox1.Height = 842;
            CenterRichTextBox();
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();

            // Makes a web browser control to open Help.html
            string helpPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Help.html");
            if (File.Exists(helpPath))
            {
                // Remove any previous web browser controls and close buttons
                Control browserToRemove = null;
                Control buttonToRemove = null;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is WebBrowser)
                        browserToRemove = ctrl;
                    if (ctrl is Button && ctrl.Tag?.ToString() == "CloseWebBrowser")
                        buttonToRemove = ctrl;
                }
                if (browserToRemove != null)
                {
                    this.Controls.Remove(browserToRemove);
                    browserToRemove.Dispose();
                }
                if (buttonToRemove != null)
                {
                    this.Controls.Remove(buttonToRemove);
                    buttonToRemove.Dispose();
                }

                WebBrowser webBrowser = new WebBrowser
                {
                    Dock = DockStyle.Fill,
                    Url = new Uri(helpPath)
                };
                this.Controls.Add(webBrowser);
                webBrowser.BringToFront();

                // Adds an X which closes the browser
                Button closeButton = new Button
                {
                    Text = "X",
                    Tag = "CloseWebBrowser",
                    Size = new Size(30, 30),
                    Location = new Point(this.ClientSize.Width - 40, 10),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                // If X is clicked
                closeButton.Click += (s, args) =>
                {
                    this.Controls.Remove(webBrowser);
                    webBrowser.Dispose();
                    this.Controls.Remove(closeButton);
                    closeButton.Dispose();

                    richTextBox1.Dock = DockStyle.Fill;
                };
                this.Controls.Add(closeButton);
                closeButton.BringToFront();
            }

            // The help menu stuff
            else
            {
                MessageBox.Show("Help.html not found in the 'Files' folder.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void assistanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Got to work...
            MessageBox.Show("STT (Speech To Text) will be added in a future update. Please hold", "Future Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Welcome to BetterSize Wizard. \n" + "BetterSize allows you to set the custom width and height of the Document Area. \n" + "Press Enter to continue", "BetterSize Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string widthInput = Interaction.InputBox("Enter width (in pixels):", "BetterSize Wizard");
            if (int.TryParse(widthInput, out int widthPx))
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionIndent = widthPx;
                richTextBox1.Width = widthPx;
                richTextBox1.Dock = DockStyle.Left;
                richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                MessageBox.Show($"Width set to {widthPx}px.", "BetterMargin Wizard", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Oh No! an error has occured. It could be because you cancelled out of the setup or you entered in an invalid input. Please try again.", "BetterSize Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string heightInput = Interaction.InputBox("Enter height (in pixels):", "BetterSize Wizard");
            if (int.TryParse(heightInput, out int heightPx))
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionIndent = heightPx;
                richTextBox1.Height = heightPx;

                MessageBox.Show($"Height set to {heightPx}px.", "BetterSize Wizard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Oh No! an error has occured. It could be because you cancelled out of the setup or you entered in an invalid input. Please try again.", "BetterSize Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CenterRichTextBox();
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
        }

        private void resetMarginsToDefaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 0;
            richTextBox1.ScrollToCaret();
            MessageBox.Show("Margins reset to default.", "Reset Margins", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Got to work...
            MessageBox.Show("Language selection will be added in a future update. Please hold", "Future Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

