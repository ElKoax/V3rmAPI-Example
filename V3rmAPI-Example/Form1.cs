using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V3rmAPI;

namespace V3rmAPI_Example
{
    public partial class Form1 : Form
    {
        V3rmAPI.V3rmAPI API_Example = new V3rmAPI.V3rmAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Grabs the API
            API_Example.ExecuteScript(richTextBox1.Text);
            // Then it Executes any text that is inputted into the textbot.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This Ininilizes the Injection.
            API_Example.Inject();
        }
    }
}
