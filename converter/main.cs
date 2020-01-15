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
        /* READ!!!
         * How to use?
         * Get the bytes of a sound file you want to convert to a wav
         * Open sound_bytes.cs and paste them in
         * Build and press convert
         * Done
        */
        byte[] getbytearray = { 0x00 };
        
        private void Button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("converted.wav")) // create your wav file
            {
                if (getbytearray != null)
                {
                    fs.Write(getbytearray, 0, getbytearray.Length); // write the bytes into the wav file
                }
                fs.Close();
            }
            MessageBox.Show("Successfully converted to WAV file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // done .wav file is in the same folder as this .exe
            
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] get_dropped = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string file in get_dropped)
            {
                if(!file.Contains(".wav"))
                {
                    MessageBox.Show("Only .wav files are allowed");
                    return;
                }
                var read_bytes = File.ReadAllBytes(file);
                getbytearray = read_bytes;
                if (rbCpp.Checked)
                {
                    txtBytes.Text = PrintByteArrayCPP(read_bytes);
                }
                else if (rbCSharp.Checked)
                {
                    txtBytes.Text = PrintByteArrayCSharp(read_bytes);
                }
                else if (!rbCpp.Checked && !rbCSharp.Checked)
                {
                    txtBytes.Text = PrintByteArrayNone(read_bytes);
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
            var sb = new StringBuilder("unsigned char[] = {");
            foreach (var b in bytes)
            {
                sb.Append("0x" + b + ", ");
            }
            sb.Append("}");
            return sb.ToString();
        }
        public string PrintByteArrayCSharp(byte[] bytes)
        {
            var sb = new StringBuilder("byte[] sound_bytes = {");
            foreach (var b in bytes)
            {
                sb.Append("0x" + b + ", ");
            }
            sb.Append("}");
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
                MessageBox.Show("No converted audio file found!");
            }
            pl.Dispose();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
