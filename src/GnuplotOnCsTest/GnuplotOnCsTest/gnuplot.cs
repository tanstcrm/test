using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace myUtils
{
    class myGnuplot
    {
        Process gnuplot = null;

        public graphTitle graphTitle = null;

        public myGnuplot() { }
        public myGnuplot(string filePath)
        {
            setProgramLocaton(filePath);
            gnuplot.Start();
            setPngOutput();
        }

        void setProgramLocaton(string filePath)
        {
            Process p = new Process();
            p.StartInfo.FileName = filePath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            gnuplot = p;
        }

        void setPngOutput()
        {
            setCom("set terminal png");
            setCom("set out \"temporary.png\"");
        }

        public void resetTerminal()
        {
            setCom("set out \"temporary.png\"");
        }

        public void setCom (string command)
        {
            gnuplot.StandardInput.WriteLine(command);
        }

        public void setTitle (graphTitle gt)
        {
            setCom("set title " +  "\"" + gt.gTitle + "\"");
            setCom("set xlabel " + "\"" + gt.xLabel + "\"");
            setCom("set ylabel " + "\"" + gt.yLabel + "\"");
        }
        
        private void initGraph()
        {
            if (graphTitle != null)
            {
                setTitle(graphTitle);
            }
        }

        private void initTerminal()
        {
            setCom("reset");
            setCom("set datafile separator \", \"");
            setCom("set terminal png");
            setCom("set out \"temporary.png\"");
        }
        private void finalizeTerminal()
        {
            setCom("set out \"temporary2.png\"");
            setCom("reset");
        }

        public void histgram(string str, int min, int max, int width, string com)
        {
            initTerminal();
            initGraph();
            setCom("set label 1 left at graph 0.01,0.9 \"" + com + "\"");
            setCom("bin(x,width)=width*floor(x/width)+width/2.0");
            setCom("plot [" + min.ToString()+":"+max.ToString() + "] \"" +str+ "\" using (bin($3," +width.ToString()+ ")):(1.0) smooth freq with boxes title \"Histgram\"" );
            finalizeTerminal();
        }
    }

    class graphTitle
    {
        public string gTitle { get; set; } = "";
        public string xLabel { get; set; } = "";
        public string yLabel { get; set; } = "";

        public graphTitle(string title, string xlabel, string ylabel)
        {
            gTitle = title;
            xLabel = xlabel;
            yLabel = ylabel;
        }

        public graphTitle()
        {
        }
    }
}
