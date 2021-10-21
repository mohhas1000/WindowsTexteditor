using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Texteditor
{
    public partial class Form1 : Form
    {
        //Dessa är attribut är tillgänglig för objekt som skapas från klassen Form1.
        private float currentSize;
        private string path = "", Content = "", data = "";
        private StreamWriter sw = null;
        private StreamReader sr = null;
        private SaveFileDialog saveFile = null;
        private OpenFileDialog openFile;
        private bool key = false, cancelClose = false, saveSettings = false;
        private int Antalord = 0, Antalkolumner = 1, AntalRader = 1, Antalbokmedmellanslag = 0, Antalbokutanmellanslag = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "dok1.txt";
        }

        private void TextBox_Function(object sender, EventArgs e)  //Vad som sker när någonting ändras i textboxen.
        {
            Content = TextBox.Text;
            this.Text = "*dok1.txt";
            if (key) //Om en fil har öppnats då sätts boolean variabeln key till true, vilket get oss "*filnamn.txt" i fönstertiteln.
            {
                this.Text = "*" + Path.GetFileName(path); //Path.getFileName returnerar endast filnamnet och inte hela andressen.
            }

            //Beräknar antal ord som finns i textboxen
            char[] box = new char[] { ' ', '\r', '\n', '\t' }; //Tecken som används för att skilja alla ord som finns i textboxen
            Antalord = Content.Split(box, StringSplitOptions.RemoveEmptyEntries).Length; //Delar texten i textboxen på ord och räknar antalet
            AntalOrd_Label.Text = "Antal ord: " + Antalord.ToString();

            //Anger vilken kolumn användaren befinner sig i och ändrar på
            int line = TextBox.GetLineFromCharIndex(TextBox.SelectionStart);
            Antalkolumner = TextBox.SelectionStart - TextBox.GetFirstCharIndexFromLine(line) + 1;

            //Beräknar antal bokstäver med mellanslag. \x20 är hexadecimalt som finns i ascii-tabellen. Representerar "space"-teknet.
            Regex rgx = new Regex("[^a-öA-Ö\x20]");
            Antalbokmedmellanslag = rgx.Replace(Content, "").Length; //T.ex. om Content innehåller en siffra då ersätts den med "", //Vilket räknas inte med

            //Beräknar antal bokstäver utan mellanslag.
            Regex rgx2 = new Regex("[^a-öA-Ö]");
            Antalbokutanmellanslag = rgx2.Replace(Content, "").Length;

            ABMM.Text = "Bokstäver med mellanslag: " + Antalbokmedmellanslag;

            ABUM.Text = "Bokstäver utan mellanslag: " + Antalbokutanmellanslag;

            //Detta är till för att antal rader ska aldrig bli 0.
            if (TextBox.Text.Length == 0)
            {
                AntalRader = 1;
            }
            else
            {
                AntalRader = TextBox.Lines.Count();
            }
            AntalRader_Label.Text = "Ln, " + AntalRader + " Col, " + Antalkolumner;

        }

        private void NewTextBox_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "New".
        {

            if (this.Text.Contains("*")) //Kontrollerar om användaren har ändrat i textboxen. 
            {
                var result = Controll_Function(); //En egengjord funktion som frågar användaren om filen ska sparas först eller inte.
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (this.Text != "*dok1.txt") //Uttrycket är sant om en fil har redan öppnats.
                    {
                        key = true;
                        SaveContent_Function(sender, e); //Anropar på en funktion som sparar under akutellt filnamn.
                    }
                    else
                    {
                        CodeForSaving(); //En funktion som sparar under ett nytt filnamn.
                    }
                    Reset_Function(); //En funktion som nollställer textboxen, Content och fönstertiteln.
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    Reset_Function();
                }
            } //Hoppar här nedan om inte textboxen har ändrats.
            else
            {
                Reset_Function();
            }

        }

        private void NewWindow_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "New Window".
        {
            //Det är inte en riktig lösning eftersom jag skapar samma instans av klassen med samma variabelnamn.
            //Dessutom stängs min form2 automatisk när form1 stängs ner.
            //Kontakta mig gärna om du har en idé på hur jag kan lösa detta!
            Form form2 = new Form1();
            form2.Show();
        }

        private void OpenFile_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Open".
        {
            if (this.Text.Contains("*")) // Kontrollerar om användaren har ändrat i textboxen. 
            {
                var result = Controll_Function();
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (this.Text != "*dok1.txt")
                    {
                        key = true;
                        SaveContent_Function(sender, e);
                    }
                    else
                    {
                        CodeForSaving(); 
                    }
                    CodeForOpen(); //En funktion som öppnar befintlig fil.
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    CodeForOpen(); 
                }
            }
            else
            {
                CodeForOpen();
            }
        }

        private void SaveContent_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Save".
        {
            if (key) //Sant om en fil har redan öppnats.
            {
                sw = new StreamWriter(path); //Skapar ett streamWriter objekt för att kunna skriva till den aktuella filen.
                sw.Write(Content);
                sw.Close();
                this.Text = Path.GetFileName(path);
                MessageBox.Show("Filen har sparat!");
            }
            else
            {
                CodeForSaving(); 
            }

        }

        private void SaveAsContent_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Save as".
        {
            CodeForSaving();  //En funktion som sparar under ett nytt filnamn
        }

        private void PageSetup_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Page Setup".
        {

            if (saveSettings) //För att inte nollställa inställningarna på Page Setup
            {
                pageSetupDialog1.PageSettings = pageSetupDialog1.PageSettings;
            }
            else
            {
                //Initierar dialogrutans egenskap printersettings
                //Definierar skrivarinställningar
                pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings(); 
                pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings(); //Ställer in skrivarinställningar
            }
            DialogResult result = pageSetupDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                saveSettings = true;
            }

        }

        private void Print_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Print".
        {
            //Ställer in egneskapen dokument till printDocument för som printpage händelsen har hanterats.
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //Hanterar händelsen för att ange innehållet på den utskrivna sidan
        {
            e.Graphics.DrawString(TextBox.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 125);
        }

        private void Close_Function(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Exit".
        {
            if (this.Text.Contains("*"))
            {
                var result = Controll_Function();
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (this.Text != "*dok1.txt")
                    {
                        key = true;
                        SaveContent_Function(sender, e);
                    }
                    else
                    {
                        CodeForSaving();
                    }
                    this.Dispose(); //Metod som frigöra obehandlade resurser som t.ex. filer och stänger formuläret.
                 
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Dispose();
             
                }
            }
            else
            {
                this.Dispose();

            }
        }

        private void Undo_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Úndo".
        {
            if (TextBox.CanUndo == true)
            {
                TextBox.Undo();
                TextBox.ClearUndo(); // Rensa ångra bufferten d.v.s. förhindra att den senaste åtgärden görs om.
            }
        }

        private void Cut_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Cut".
        {
            if (TextBox.SelectedText != "")
            {
                TextBox.Cut();
            }
        }

        private void Copy_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Copy".
        {
            if (TextBox.SelectionLength > 0)
            {
                TextBox.Copy();
            }

        }

        private void Paste_MenuItem_Click(object sender, EventArgs e)//Vad som sker när användaren klickar på undermenyn "Paste".
        {
            TextBox.Paste();
        }

        private void Delete_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Delete".
        {
            if (TextBox.SelectionLength > 0)
            {
                int a = TextBox.SelectionLength;
                TextBox.Text = TextBox.Text.Remove(TextBox.SelectionStart, a);

            }

        }

        private void SelectAll_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Select All".
        {
            TextBox.SelectAll();
        }

        private void TimeDate_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Time/Date".
        {
            string date = DateTime.Now.ToString("HH:mm:ss yyyy-MM-dd"); 
            TextBox.Text = TextBox.Text.Insert(TextBox.SelectionStart, date);
        }

        private void Font_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Font Size".
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TextBox.Font = fd.Font;
            }
        }

        private void Color_MenuItem_Click(object sender, EventArgs e) //Vad som sker när användaren klickar på undermenyn "Font Color ".
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                TextBox.ForeColor = cd.Color;
            }
        }

        private void zoomIn_MenuItem_Click(object sender, EventArgs e) //Zooma in
        {
            currentSize = TextBox.Font.Size;
            currentSize += 1.0F;
            TextBox.Font = new Font(TextBox.Font.Name, currentSize,
                TextBox.Font.Style, TextBox.Font.Unit);

        }

        private void ZoomOut_MenuItem_Click(object sender, EventArgs e) //Zooma ut 
        {
            currentSize = TextBox.Font.Size;
            currentSize -= 1.0F;
            if ((currentSize -= 1.0F) > 0)
            {
                TextBox.Font = new Font(TextBox.Font.Name, currentSize,
                TextBox.Font.Style, TextBox.Font.Unit);
            }

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e ) //Visa/Dölj informationsraden
        {
            if (StatusBar_MenuItem.Checked == true) 
            {
                StatusBar_MenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                StatusBar_MenuItem.Checked = true;
                statusStrip1.Visible = true;
            }

        }

        private void ViewHelp_MenuItem_Click(object sender, EventArgs e) //Hjälpfunktion
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=f%c3%a5+hj%c3%a4lp+med+anteckningar+i+windows+10&filters=guid:%224466414-sv-dia%22%20lang:%22sv%22&form=T00032&ocid=HelpPane-BingIA");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //Om oss
        {
            MessageBox.Show("Mohamed Hasan" + "\n" +
                "@2020 Karlstad Universitet", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormClosed_Function(object sender, FormClosingEventArgs e) //Vad som sker när användaren klickar på "X" längst upp till höger på formuläret.
        {
            if (this.Text.Contains("*"))
            {
                var result = Controll_Function();

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (this.Text != "*dok1.txt")
                    {
                        key = true;
                        SaveContent_Function(sender, e);
                    }
                    else
                    {
                        CodeForSaving();
                    }
                    this.Dispose();
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Dispose();
                }
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    cancelClose = true; //För att inte stänga formuläret när man klickar på "avbryt"
                }
            }
            e.Cancel = cancelClose;
            cancelClose = false;
        }

        private DialogResult Controll_Function() //En funktion som ställer en fråga till användaren om filen ska sparas eller inte.
        {
            DialogResult Result = MessageBox.Show(
                           "Vill du spara ändringarna till " + this.Text.Trim('*') + "?",
                           "Messsage",
                           MessageBoxButtons.YesNoCancel,
                           MessageBoxIcon.Information);
            return Result; //Returner vad användaren har klickat på.

        }

        private void CodeForSaving() //Koden för att bläddra i filsystemet och spara under ett filnamn.
        {
            saveFile = new SaveFileDialog(); 
            saveFile.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFile.Title = "Save as";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.FileName;
                sw = new StreamWriter(path);
                sw.Write(Content);
                sw.Close();
                this.Text = Path.GetFileName(path);
                MessageBox.Show("Filen har sparat!");
                key = true;

            }
            else
            {
                MessageBox.Show("Filen har ej sparat!");
            }
        }

        private void CodeForOpen() //Koden för att bläddra i filsystemet och öppna en fil.
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "txt files(*.txt)|*.txt| All files(*.*)|*.*";
            openFile.Title = "Open";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFile.FileName))
                {
                    sr = new StreamReader(openFile.FileName);
                    Content = sr.ReadToEnd();
                    sr.Close();
                    path = openFile.FileName;
                    TextBox.Text = Content;
                    this.Text = Path.GetFileName(openFile.FileName);
                    key = true;
                }
            }
            else
            {
                MessageBox.Show("Filen kunde ej öppnas!");
            }

        }

        private void DragEnter_Function(object sender, DragEventArgs e) //Vad som sker när ett objekt dras in i kontrollens gränser.
        {
            //säkerställer att data som dras är av en acceptabel typ.
            // Hantera FileDrop-data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))  //Uttrycket är sant om datan är tillgänglig eller kan konverteras till ett format som anges av en sträng.
            {
                e.Effect = DragDropEffects.Copy; //Data från dragkällan kopieras till drop-target. För att kunna använda den sedan i DragDrop funktionen.

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void DragDrop_function(object sender, DragEventArgs e)//Vad som sker när en Drag-and-Drop operation har utförts.
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    sr = new StreamReader(files[0]);
                    data = sr.ReadToEnd();
                    sr.Close();
                    TextBox.Text += data;
                    data = "";
                }

                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    sr = new StreamReader(files[0]);
                    data = sr.ReadToEnd();
                    sr.Close();
                    TextBox.Text = TextBox.Text.Insert(TextBox.SelectionStart, data);
                    data = "";
                }

                if (ModifierKeys == Keys.None)
                {
                    if (this.Text.Contains("*"))
                    {
                        var result = Controll_Function();
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (this.Text != "*dok1.txt")
                            {
                                key = true;
                                SaveContent_Function(sender, e);
                            }
                            else
                            {
                                CodeForSaving();
                            }
                            DragAndOpenFile(files[0]);
                        }
                        if (result == System.Windows.Forms.DialogResult.No)
                        {
                            DragAndOpenFile(files[0]);
                        }
                    }
                    else
                    {
                        DragAndOpenFile(files[0]);
                    }
                }
            }

        }

        private void DragAndOpenFile(string f) //Funktionen används för att visa filinnehållet som droppas in i fönstret
        {
            sr = new StreamReader(f);
            data = sr.ReadToEnd();
            sr.Close();
            path = f;
            TextBox.Text = data;
            this.Text = Path.GetFileName(f);
            key = true;
        }

        private void Reset_Function() //Nollställer bl.a. Textboxen.
        {
            key = false;
            TextBox.Text = "";
            Content = "";
            this.Text = "dok1.txt";
        }

    }
}
