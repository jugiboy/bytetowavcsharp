using System;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace converter
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        byte[] byteArray = { };

        private void Button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("converted.wav"))
            {
                if (byteArray != null)
                {
                    fs.Write(byteArray, 0x00, byteArray.Length);
                }
                fs.Close();
            }
            MessageBox.Show("Successfully converted to WAV file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileDrop = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string filePath in fileDrop)
            {
                if(!filePath.Contains(".wav"))
                {
                    MessageBox.Show("Only .wav files are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var readBytes = File.ReadAllBytes(filePath);
                byteArray = readBytes;
                if (rbCpp.Checked)
                {
                    txtBytes.Text = PrintByteArrayCPP(readBytes);
                }
                else if (rbCSharp.Checked)
                {
                    txtBytes.Text = PrintByteArrayCSharp(readBytes);
                }
                else if (!rbCpp.Checked && !rbCSharp.Checked)
                {
                    txtBytes.Text = PrintByteArrayNone(readBytes);
                }
            }
        }
        public string PrintByteArrayNone(byte[] bytes)
        {
            var sb = new StringBuilder("");
            foreach (var b in bytes)
            {
                sb.Append("0x" + b + ", ");
            }
            return sb.ToString();
        }
        public string PrintByteArrayCPP(byte[] bytes)
        {
            var sb = new StringBuilder("unsigned char soundBytes[] = { ");
            foreach (var b in bytes)
            {
                sb.Append("0x" + b + ", ");
            }
            sb.Append(" };");
            return sb.ToString();
        }
        public string PrintByteArrayCSharp(byte[] bytes)
        {
            var sb = new StringBuilder("byte[] soundBytes = { ");
            foreach (var b in bytes)
            {
                sb.Append("0x" + b + ", ");
            }
            sb.Append(" };");
            return sb.ToString();
        }
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
                e.Effect = DragDropEffects.Copy;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer pl = new SoundPlayer();
            pl.SoundLocation = Application.StartupPath + "\\converted.wav";
            try
            {
                pl.Play();
            }
            catch
            {
                MessageBox.Show("No converted audio file found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pl.Dispose();
        }
    }
}
