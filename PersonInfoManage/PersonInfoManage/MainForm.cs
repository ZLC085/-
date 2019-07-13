using PersonInfoManage.DAL.Cost;
using PersonInfoManage.DAL.PersonInfo;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonFile personFile = new PersonFile();
            personFile.UpdatePersonFile(12,"newfile");
        }
    }
}
