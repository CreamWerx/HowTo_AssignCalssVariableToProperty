using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo_AssignCalssVariableToProperty
{
    /// <summary>
    /// By assigning a local class property to the property of an instantiated 
    ///  external class object property, the external property is essentially
    ///  set via the local property.
    /// To me it's akin to aliasing a variable.
    /// 
    /// In this example the external class property is the current position 
    ///  property oF the windows media player control in a windows forms application.
    /// .Net Framework 4.8 (DOT NET 6 does not support WMP).
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double WmpPos { get => wmp.Ctlcontrols.currentPosition; set => wmp.Ctlcontrols.currentPosition = value; }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp.URL = @"C:\path\to\video.mp4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkipForward(5);
        }

        private void SkipForward(int seconds)
        {
            WmpPos += seconds;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SkipBackward(5);
        }

        private void SkipBackward(int seconds)
        {
            WmpPos -= seconds;
        }
    }
}
