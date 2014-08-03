using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aStar
{
	class aStar
	{
		
		[STAThread]
		static void Main(string[] args)
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MapForm myForm = new MapForm();
            Application.Run(myForm);
		}
	}
}
