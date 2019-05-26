using System;
using System.IO;
using System.Media;
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
        private void Button1_Click(object sender, EventArgs e)
        {
            
            sound_bytes soundBytes = new sound_bytes(); // initialize our sound_bytes class
            var bytes = soundBytes.bytes_sound; // get the bytes
            using (FileStream fs = File.Create("converted.wav")) // create your wav file
            {
                fs.Write(bytes, 0, bytes.Length); // write the bytes into the wav file
            }
            Thread.Sleep(250); // sleep for 250ms just so it looks nicer lol
            MessageBox.Show("Successfully converted to WAV file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // done .wav file is in the same folder as this .exe
        }
    }
}
