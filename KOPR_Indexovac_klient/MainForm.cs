using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Text.RegularExpressions;

namespace KOPR_Indexovac_klient
{
    public partial class MainForm : Form
    {
        private KoprRestClient _restClient;
        private const string _URL="http://localhost:8182";
        private string _savedIdsFile = "savedIds.txt";
        private string _documentsDirectory = "Documents";

        public MainForm()
        {
            InitializeComponent();
            _restClient = new KoprRestClient(_URL); 
           
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var value = Input_TextBox.Text;
            if (value == null || value.Equals(""))
            {
                return;
            }
            var parameter = (string)FindByComboBox.SelectedItem;
            Console.WriteLine(parameter);
            
            switch(parameter)
            {
                case "UUID":
                    break;
                case "UUIDs":

                    break;
                case "words":
                    
                    Console.WriteLine(value);
                    var guids = _restClient.findByString(value);
                    foreach (var guid in guids)
                    {
                        Ids_TextBox.AppendText(guid.ToString() + Environment.NewLine);
                    }
                    
                    break;
                case "-":

                    break;               
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           // DocumentOpenFileDialog.ShowDialog();
            var size = -1;
            var result = DocumentOpenFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
        //    var savedIdFile = 
            {
                var file = DocumentOpenFileDialog.FileName; // returns absolute path

                try
                {
                    var content = File.ReadAllText(file);
                    size = content.Length;              // GetFileName returns file name from path 
                    var guid= _restClient.addDocument(new Document(Path.GetFileName(file), content));
                    Console.WriteLine(file + " " + Path.GetFileName(file));
                    Ids_TextBox.AppendText(guid.ToString());
                }
                catch (IOException)
                {
                }
            }
        }


        private void SaveIdsToFile_Button_Click(object sender, EventArgs e)
        {
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "\\"+_savedIdsFile);
             //File.AppendAllText(path, Ids_TextBox.Text);
            var streamWriter = new StreamWriter(_savedIdsFile,true);
            streamWriter.Write(Ids_TextBox.Text);
           
            streamWriter.Close();
        }

        private void LoadIdsFromFile_Button_Click(object sender, EventArgs e)
        {
            var streamReader = new StreamReader(_savedIdsFile);
            var guids = streamReader.ReadToEnd();
            Ids_TextBox.AppendText(guids);
            streamReader.Close();
           //Ids_TextBox.AppendText(File.ReadAllText(@_savedIdsFile));
        }

        private void DeleteFromFile_Button_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@_savedIdsFile, string.Empty);
        }

        private void GetDocuments_Button_Click(object sender, EventArgs e)
        {
            var stringGUIDsInMultipleLines = Ids_TextBox.Text;
            Console.WriteLine(stringGUIDsInMultipleLines);
            var stringGUIDsForRestClient = Regex.Replace(stringGUIDsInMultipleLines, @"\r|\t|\n\n|\n", "_");
            Console.WriteLine(stringGUIDsForRestClient+" | "+stringGUIDsForRestClient.Length);
            stringGUIDsForRestClient = Regex.Replace(stringGUIDsForRestClient, @"__", "_");
            Console.WriteLine(stringGUIDsForRestClient + " | " + stringGUIDsForRestClient.Length);
            stringGUIDsForRestClient= stringGUIDsForRestClient.Remove(stringGUIDsForRestClient.Length-1);
            Console.WriteLine(stringGUIDsForRestClient + " | " + stringGUIDsForRestClient.Length);
            var documents = _restClient.getDocumentsByUUIDs(stringGUIDsForRestClient);
            
            var documentDao = FactoryDocumentDao.GetDocumentDao(documents);
            documentDao.SaveDocuments(_documentsDirectory);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Ids_TextBox.Text = "";
        }

        private void FindByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Input_TextBox.Enabled = FindByComboBox.SelectedItem.Equals("words") ? true : false;
        }


    }
}
