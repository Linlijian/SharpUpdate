using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpUpdate;

namespace App
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        public Form1()
        {
            InitializeComponent();
            txt_version.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }

        public Assembly ApplicationAssembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public Icon ApplicationIcon
        {
            get
            {
                return this.Icon;
            }
        }

        public string ApplicationID
        {
            get
            {
                return "App";
            }
        }

        public string ApplicationName
        {
            get
            {
                return "App";
            }
        }

        public Form Context
        {
            get
            {
                return this;
            }
        }

        public Uri UpdateXmlLocation
        {
            get
            {
                return new Uri("");
            }
        }
    }
}
