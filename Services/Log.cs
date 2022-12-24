using System.IO;
using System.Windows.Forms;

namespace Services
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            string[] line = File.ReadAllLines("log.txt");
            listBox.DataSource = line;
        }

      
    }
}
