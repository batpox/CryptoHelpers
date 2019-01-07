using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoHelpers
{
    /// <summary>
    /// References:
    /// https://blogs.msdn.microsoft.com/kaushal/2010/11/04/various-ssltls-certificate-file-typesextensions/
    /// 
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Full path to the selected exe file
        /// </summary>
        private string ExePath { get; set; }

        /// <summary>
        /// The X.509 certificate extracted from the signed file.
        /// </summary>
        private X509Certificate Certificate { get; set; }

        private X509FileFlavor FileFlavor { get; set; }

        /// <summary>
        /// The types of certificate files supported here.
        /// </summary>
        private List<X509FileFlavor> X509FlavorList = new List<X509FileFlavor>()
        {
            new X509FileFlavor("Cert", X509ContentType.Cert, "cer", "Single X.509 Certificate (Base64)", false)
            ,new X509FileFlavor("P7B", X509ContentType.Pkcs7, "p7b", "PKCS #7 formatted", true)
            ,new X509FileFlavor("P12", X509ContentType.Pkcs12, "p12", "PKCS #12. Personal Info Exchange. Same as PFX", false)
            ,new X509FileFlavor("PFX", X509ContentType.Pfx, "pfx", "Personal Info Exchange. Same as PKCS #12", false)
            ,new X509FileFlavor("Serialized Cert", X509ContentType.SerializedCert, "sst", "Like Cert, but includes Properties", false)
            ,new X509FileFlavor("Serialized Store", X509ContentType.SerializedStore, "sst", "Serialized Store", false)
            ,new X509FileFlavor("Authenticode", X509ContentType.Authenticode, "aut", "Authenticode code-signing. Based on PKCS #7", true)

        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listFileFormats.Items.Clear();

            int wid = listFileFormats.Width;
            listFileFormats.Columns.Clear();
            listFileFormats.Columns.Add("Name", (int) (wid*0.2) , HorizontalAlignment.Left);
            listFileFormats.Columns.Add("Contents", (int)(wid * 0.2), HorizontalAlignment.Left);
            listFileFormats.Columns.Add("Extension", (int)(wid * 0.2), HorizontalAlignment.Left);
            listFileFormats.Columns.Add("Needs Pwd?", (int)(wid * 0.1), HorizontalAlignment.Left);
            listFileFormats.Columns.Add("Comments", (int)(wid * 0.3), HorizontalAlignment.Left);

            int index = 0;
            foreach ( X509FileFlavor flavor in X509FlavorList)
            {
                ListViewItem lvi = new ListViewItem(flavor.Name, index++);
                lvi.SubItems.Add(flavor.ContentType.ToString());
                lvi.SubItems.Add(flavor.ExtensionName);
                lvi.SubItems.Add(flavor.Comments);
                lvi.SubItems.Add(flavor.RequiresPassword.ToString());

                listFileFormats.Items.Add(lvi);
            }

            FileFlavor = null;
        }


        /// <summary>
        /// Prompt the user for the signed exe file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadExe_Click(object sender, EventArgs e)
        {

            ExePath =  GetFilepath("Executable Files (*.exe)|*.exe");

            textSignedExeFile.Text = ExePath;
            textCertificate.Text = "";

            buttonCreateCertificateFile.Enabled = false;

            if ( !string.IsNullOrEmpty(ExePath))
            {

                Certificate =  X509Certificate2.CreateFromSignedFile(ExePath);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Issuer: {Certificate.Issuer}");
                sb.AppendLine($"HashCode: {Certificate.GetHashCode()}");
                sb.AppendLine($"CertHashString: {Certificate.GetCertHashString()}");
                sb.AppendLine($"PublicKey: {Certificate.GetPublicKeyString()}");
                sb.AppendLine($"KeyAlgorithm: {Certificate.GetKeyAlgorithm()}");
                sb.AppendLine($"KeyAlgorithmParams: {Certificate.GetKeyAlgorithmParametersString()}");
                sb.AppendLine($"EffectiveDate: {Certificate.GetEffectiveDateString()}");
                sb.AppendLine($"ExpirationDate: {Certificate.GetExpirationDateString()}");

                sb.AppendLine($"SerialNumber: {Certificate.GetSerialNumberString()}");
                sb.AppendLine($"Subject: {Certificate.Subject}");
                sb.AppendLine($"Type: {Certificate.GetType()}");

                textCertificate.Text = sb.ToString();
                
            }
            else
            {
            }

        }


        private string GetFilepath(string filter)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = filter; // E.g. "Executable Files (*.exe)|*.exe";

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return dialog.FileName;
                }
                else
                    return String.Empty;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Filter={filter} Err={ex}");
            }
        }

        private string GetFolderpath()
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
                else
                    return String.Empty;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Cannot select folder. Err={ex}");
            }
        }

        private void buttonCreateCerFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ExePath))
                    return;

                string folderpath = GetFolderpath();

                X509FileFlavor ff = X509FlavorList.SingleOrDefault(rr => rr.Name == "Cert");
                if (ff != null)
                {
                    if (!WriteCertificateToFile(ExePath, folderpath, Certificate, ff, out string explanation))
                        alert(explanation);
                }
            }
            catch (Exception ex)
            {
                logit($"Err={ex}");
            }

        }

        private void logit(string msg)
        {

            MessageBox.Show(msg);
        }
        private void alert(string msg)
        {
            MessageBox.Show(msg);
            logit(msg);
        }

        private void buttonCreateCertificateFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ExePath))
                    return;

                X509FileFlavor ff = X509FlavorList.SingleOrDefault(rr => rr.Name == FileFlavor.Name);
                if ( ff != null )
                {
                    if (ff.RequiresPassword)
                    {
                        alert("Requires Password. Not Implemented.");
                    }
                    else
                    {
                        string folderpath = GetFolderpath();

                        if (!WriteCertificateToFile(ExePath, folderpath, Certificate, ff, out string explanation))
                            alert(explanation);
                    }
                }
            }
            catch (Exception ex)
            {
                logit($"Err={ex}");
            }
        }

        private static bool WriteCertificateToFile( string exeFullpath, string outputFolderpath, X509Certificate certificate, X509FileFlavor x509Flavor, out string explanation)
        {
            explanation = "";

            string filepath = $"{Path.GetFileNameWithoutExtension(exeFullpath)}.{x509Flavor.ExtensionName}";
            string fullpath = Path.Combine(outputFolderpath, filepath);

            try
            {
                if (File.Exists(fullpath))
                    File.Delete(fullpath);

                File.WriteAllBytes(fullpath, certificate.Export(x509Flavor.ContentType));

                return true;
            }
            catch (Exception ex)
            {
                explanation = $"Cannot write={fullpath} Err={ex}";
                return false;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void listFileFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (sender as ListView);

            if (lv.SelectedItems.Count == 0)
                return;

            ListViewItem lvi = (sender as ListView).SelectedItems[0];
            FileFlavor = X509FlavorList.SingleOrDefault(rr => rr.Name == lvi.Text);

            buttonCreateCertificateFile.Enabled = (FileFlavor != null);

        }
    }
}
