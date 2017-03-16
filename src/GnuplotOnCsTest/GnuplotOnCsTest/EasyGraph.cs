using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using myUtils;

namespace GnuplotOnCsTest
{
    public partial class EasyGraph : Form
    {
        private FileSystemWatcher watcher = null;
        private myGnuplot gp = new myGnuplot(@"gnuplot\bin\gnuplot.exe");


        public EasyGraph()
        {
            InitializeComponent();
            startWatching();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp.setCom("set terminal png");
            gp.setCom("set out \"temporary.png\"");
            gp.setCom("plot sin(x)");
            gp.setCom("set out \"temporary2.png\"");
            gp.setCom("set terminal windows");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image img = CreateImage(@"temporary.png");
            if (img == null) { return; }
            mainPictBox.Image = img;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gp.setCom("set terminal png");
            gp.setCom("set out \"temporary.png\"");
            gp.setCom("set label 1 right at graph 0.99,0.9 \"tetetetetetetetete\"");
            gp.setCom("plot cos(x)");
            gp.setCom("reset");
            gp.setCom("set out \"temporary2.png\"");
            gp.setCom("set terminal windows");
        }

        private void putDdfile(object sender, DragEventArgs e)
        {
            string[] item = (string[])e.Data.GetData(DataFormats.FileDrop);
            analyseFileNameTbx.Text = item[0];
        }
        private void enterDdfile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void EasyGraph_DragDrop(object sender, DragEventArgs e)
        {
            putDdfile(sender, e);
        }
        private void analyseFileNameTbx_DragDrop(object sender, DragEventArgs e)
        {
            putDdfile(sender, e);
        }
        private void EasyGraph_DragEnter(object sender, DragEventArgs e)
        {
            enterDdfile(sender, e);
        }
        private void analyseFileNameTbx_DragEnter(object sender, DragEventArgs e)
        {
            enterDdfile(sender, e);
        }


        private void graphMakeBtn_Click(object sender, EventArgs e)
        {
            int histMin, histMax, histWidth;
            graphTitle gt = new graphTitle(graphTitleTbx.Text, graphXlabelTbx.Text, graphYlabelTbx.Text);
            gp.graphTitle = gt;
            if (int.TryParse(graphHistMinTbx.Text, out histMin) == false) { return; }
            if (int.TryParse(graphHistMaxTbx.Text, out histMax) == false) { return; }
            if (int.TryParse(graphHistWidthTbx.Text, out histWidth) == false) { return; }

            gp.histgram(analyseFileNameTbx.Text.Replace("\\","\\\\"), histMin, histMax, histWidth, graphCommentTbx.Text );
        }





        private void startWatching()
        {
            if (watcher != null) { return; }

            watcher = new FileSystemWatcher();
            //watcher.Path = System.IO.Directory.GetCurrentDirectory();
            //C:\Users\Takuro Fujimaki\OneDrive\SorceCodes\Visual Studio 2015\Projects\GnuplotOnCsTest\GnuplotOnCsTest\bin\Debug
            watcher.Path = System.IO.Directory.GetCurrentDirectory();
            watcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            //すべてのファイルを監視
            watcher.Filter = "*.png";
            watcher.SynchronizingObject = this;
            //イベントハンドラの追加
            watcher.Changed += new System.IO.FileSystemEventHandler(watcher_changed);
            watcher.Created += new System.IO.FileSystemEventHandler(watcher_changed);
            watcher.Deleted += new System.IO.FileSystemEventHandler(watcher_changed);
            watcher.Renamed += new System.IO.RenamedEventHandler(watcher_changed);

            //監視を開始する
            watcher.EnableRaisingEvents = true;
        }

        public static Image CreateImage(string filename)
        {
            try
            {
                FileStream fs = new FileStream(
                    filename,
                    FileMode.Open,
                    FileAccess.Read);
                Image img = Image.FromStream(fs);
                fs.Close();
                return img;
            }
            catch { return null; }
        }

        private void watcher_changed(System.Object source,
            FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Deleted) return;

            Image img = CreateImage(@"temporary.png");
            if (img == null) { return; }
            mainPictBox.Image = img;
        }

        private void EasyGraph_Load(object sender, EventArgs e)
        {

        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            string fileDir = Path.GetDirectoryName(analyseFileNameTbx.Text);
            string fileName = "Hist_" + graphCommentTbx.Text + ".png";
            string fullPath = fileDir + Path.DirectorySeparatorChar +  fileName;
            File.Copy(@"temporary.png", fullPath);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            myGnuplot gp = new myGnuplot(@"gnuplot\bin\gnuplot.exe");
        }
    }
}
