using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
   public partial class frmLogin : Form
   {
      public frmLogin()
      {
         InitializeComponent();
      }

      private void btSimple_Click(object sender, EventArgs e)
      {
         frmDataView fdv = new frmDataView(0);
         fdv.ShowDialog();
      }

      private void btAdmin_Click(object sender, EventArgs e)
      {
         frmDataView fdv = new frmDataView(100);
         fdv.ShowDialog();
      }
   }
}
