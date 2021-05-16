# lamp-src
Lamp is a text editor that is made for Windows and is made with VS2019 and C# (C Sharp). Lamp uses the built-in Open-File Dialog and Save-File Dialog. Lamp is a free open-source software licensed under the Mozilla MPL 2.0 License. 

Save The file C# Code.
```
private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(@saveFile.FileName, richTextBox1.Text); // get the saved file and write text into it.

            Files.SelectedTab.Text = saveFile.FileName; // change the selected tab name to the file name.
        }
```

All the comments explain it, but we get the Saved File and get the file name, (location) then the second paramater includes what we write to it. In this case we do the richTextBox. 


If you like the project, be sure to donate or favourite the GitHub.
