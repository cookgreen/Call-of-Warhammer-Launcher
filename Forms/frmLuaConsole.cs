using NLua;
using NLua.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalWarModLauncher.Forms
{
    public partial class frmLuaConsole : Form
    {
        private Lua lua;

        public frmLuaConsole()
        {
            InitializeComponent();

            lua = new Lua();
            lua.LoadCLRPackage();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLuaCode.Text))
            {
                try
                {
                    lua.DoString(txtLuaCode.Text);
                }catch(LuaScriptException ex)
                {
                    txtLuaResult.Text = ex.InnerException.ToString();
                }
            }
        }
    }
}
