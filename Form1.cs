using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Xml;

namespace vsg_test
{
    public partial class Form1 : Form
    {
        public string[] files;
        List<File> fileData = new List<File>();
        public Form1()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            listBox3.AllowDrop = true;

            listBox1.DisplayMember = "DisplayString";
            listBox3.DisplayMember = "DisplayString";

        }
        private void BeginButton_Click(object sender, EventArgs e)
        {
            string pc = AppDomain.CurrentDomain.BaseDirectory;
            string pc1 = pc.Substring(0, pc.LastIndexOf("\\"));
            string pc2 = pc1.Substring(0, pc1.LastIndexOf("\\"));
            string PyCode = pc2.Substring(0, pc2.LastIndexOf("\\")) + "\\automate_signals-main\\jared_gen.py";
            Console.WriteLine(PyCode);
            //"C:/Users/JaredEshleman/Downloads/automate_signals-main/automate_signals-main/jared_gen.py";
            Program p = new Program();
            string PyArguments = "";
            if (((FileInformation)listBox3.Items[0]).File == null)
            {
                listBox3.Items.RemoveAt(0);
            }

            int count = 0;
            foreach (FileInformation item in listBox3.Items)
            {
                if (item.File != null)
                {
                    count++;
                }    
            }
            PyArguments += count;

            //
            // loop to append the delay of files
            //
            int delayCount = 0;
            foreach (FileInformation fileInfo in listBox3.Items)
            {
                string fileName = fileInfo.File;
                decimal timeLength = fileInfo.PulseLength;
                if (fileName == null)
                {
                    PyArguments += " " + timeLength;
                    delayCount++;
                }
            }


            //
            // loop to append the pulse length of files
            //
            foreach (FileInformation fileInfo in listBox3.Items)
            {
                string fileName = fileInfo.File;
                decimal timeLength = fileInfo.PulseLength;
                if (fileName != null)
                {
                    PyArguments += " " + timeLength;
                }
            }



            //
            // loop to append the files
            //
            foreach (FileInformation fileInfo in listBox3.Items)
            {
                string fileName = fileInfo.File;
                decimal timeLength = fileInfo.PulseLength;
                if (fileName != null)
                {
                    PyArguments += " " + fileName;
                }
            }
            Console.WriteLine(PyArguments);
            p.run_python_async(PyCode, PyArguments);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse CSV Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string tempFileName = openFileDialog1.FileName;

                
                //fileData.Add(new File() { Name = openFileDialog1.FileName, DisplayString = tempFileName.Substring(tempFileName.LastIndexOf("\\")).Substring(1) });
                listBox1.Items.Add(new File() { Name = openFileDialog1.FileName, DisplayString = tempFileName.Substring(tempFileName.LastIndexOf("\\")).Substring(1) });

            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = listBox1.IndexFromPoint(point);
            if (index < 0) index = listBox1.Items.Count - 1;
            object data = e.Data.GetData(typeof(File));
            listBox1.Items.Remove(data);
            if (data != null)
            {
                listBox1.Items.Insert(index, data);
            }
        }
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem == null) return;
            listBox2.DoDragDrop(listBox2.SelectedItem, DragDropEffects.Move);
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox2.PointToClient(new Point(e.X, e.Y));
            int index = listBox2.IndexFromPoint(point);
            if (index < 0) index = listBox2.Items.Count - 1;
            object data = e.Data.GetData(typeof(decimal));
            listBox2.Items.Remove(data);
            if (data != null)
            {
                listBox2.Items.Insert(index, data);
            }
        }

        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox3.SelectedItem == null) return;
            listBox3.DoDragDrop(listBox3.SelectedItem, DragDropEffects.Move);
        }

        private void listBox3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox3.PointToClient(new Point(e.X, e.Y));
            int index = listBox3.IndexFromPoint(point);
            if (index < 0) index = listBox3.Items.Count - 1;
            object data = e.Data.GetData(typeof(FileInformation));
            listBox3.Items.Remove(data);
            if (data != null)
            { 
                listBox3.Items.Insert(index, data);
            }
        }

        private void SubmitTimeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string item = ((File)listBox1.Items[i]).Name;
                string fileName = item.Substring(item.LastIndexOf("\\")).Substring(1);
                decimal pulseLength = (decimal)listBox2.Items[i];
                listBox3.Items.Add(new FileInformation() { File = item, PulseLength = pulseLength, DisplayString = string.Format("{0} will be played for {1} seconds", fileName, pulseLength) });
            }
        }

        private void browsePythonButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse .EXE Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "exe files (*.exe)|*.exe",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.python = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(timeDisplayNumberBox.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal delayLength = numericUpDown1.Value;
            listBox3.Items.Add(new FileInformation() { File = null, DisplayString = string.Format("Delay of {0}", delayLength), PulseLength = delayLength });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedFile = listBox1.SelectedItem;
            listBox1.Items.Remove(selectedFile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedFile = listBox2.SelectedItem;
            listBox2.Items.Remove(selectedFile);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedFile = listBox3.SelectedItem;
            listBox3.Items.Remove(selectedFile);
        }

        private void SaveConfigurationButton_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create(Extensions.DirectoryExtensions.GetDirectory() + "\\SaveConfigs.xml"))
            {
                writer.WriteStartElement("book");
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        private void LoadConfigurationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
