using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static DirectoriesSerializator.MainClass;

namespace DirectoriesSerializator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                textBoxSerialPath.Text = fbd.SelectedPath;
            }
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxDeserialPath.Text = fbd.SelectedPath;
            }
        }

        private void datFileButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxDatFilePath.Text = fbd.SelectedPath;
            }
        }

        private void deserializeStartButton_Click(object sender, EventArgs e)
        {
            if (textBoxDeserialPath.Text != string.Empty)
            {
                if (textBoxDatFilePath.Text != string.Empty)
                {
                    var deserFile = textBoxDatFilePath.Text + @"\Serialized.dat";

                    BinaryDeserialization(deserFile, textBoxDeserialPath.Text);

                    MessageBox.Show("Deserialization complete", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    textBoxDeserialPath.Text = string.Empty;
                    textBoxDatFilePath.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please choose .dat file path!", "Attention!", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please choose folder where you want move deserealised objects!", "Attention!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void serializeStartButton_Click(object sender, EventArgs e)
        {
            if (textBoxSerialPath.Text != string.Empty)
            {
                if (textBoxDatFilePath.Text != string.Empty)
                {
                    var deserFile = textBoxDatFilePath.Text + @"\Serialized.dat";

                    //looking for all files without empty directories
                    var infoPath = (from path in AllPathes(textBoxSerialPath.Text)
                                    where (File.GetAttributes(path) & FileAttributes.Directory) == 0
                                    select
                                        new ObjectToSeialize(path, File.ReadAllBytes(path))).ToList();


                    BinarySerialization(infoPath, deserFile);

                    MessageBox.Show("Serialization complete", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    textBoxSerialPath.Text = string.Empty;
                    textBoxDatFilePath.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please choose .dat file path!", "Attention!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please choose folder to serialize path!", "Attention!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
