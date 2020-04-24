# Convert from bytes to .wav files or get bytes from .wav files.

This program allows you to paste in bytes in a textbox and then convert them in to .wav files. Or you can drag and drop your .wav file into the textbox and get the bytes. This is useful if you want to embed sound files into your code. 


Example of doing this in C++:

unsigned char soundbytes[] = { ... }

PlaySoundA((LPCSTR)soundbytes, NULL, SND_MEMORY | SND_ASYNC);

