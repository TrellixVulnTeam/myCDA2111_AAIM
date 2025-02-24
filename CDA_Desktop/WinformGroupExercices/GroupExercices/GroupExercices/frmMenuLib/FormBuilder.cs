﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.frmMenuLib
{
    internal class FormBuilder<T> : IFormBuilder where T : Form, new()
    {
        private Form parentForm;
        private int index;

        public FormBuilder(Form parentForm)
        {
            index = 0;
            this.parentForm = parentForm;
        }
        public Form CreateInstance()
        {
            T f = new T();
            f.Text += " N°" + ++index;
            f.MdiParent = parentForm;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.WindowState = FormWindowState.Normal;
            return f;
        }

        public void TestMethodInterface()
        {
            MessageBox.Show("method interaction interface");
        }

    }
}
