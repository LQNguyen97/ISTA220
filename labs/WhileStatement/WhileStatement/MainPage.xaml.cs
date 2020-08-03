using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhileStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void openFileClick(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fp = new FileOpenPicker();
            fp.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            fp.ViewMode = PickerViewMode.List;
            fp.FileTypeFilter.Add("*");

            StorageFile file = await fp.PickSingleFileAsync();
            //create a file variable name StorageFile.
            if (file != null)
            {
                fileName.Text = file.Path;
                //take the name of the file and update the text property of the file name.
                var fileStream = await file.OpenAsync(FileAccessMode.Read);
                //open the file and put an open file and put it in a variable name filestream
                var inputStream = fileStream.GetInputStreamAt(0);
                TextReader reader = new StreamReader(inputStream.AsStreamForRead());
                displayData(reader);
            }
        }

        private void displayData(TextReader reader)
        {
            source.Text = "";
            //initializes variable
            string line = reader.ReadLine();
            //test iteration variable
            while (line != null)
            //while a line exist
            {
                source.Text += line + '\n';
                //update iteration variable and add a new line character to it.
                line = reader.ReadLine();
            }
            reader.Dispose();
            //call the Dispose method of the reader object (in line 46)

        }
    }
}
