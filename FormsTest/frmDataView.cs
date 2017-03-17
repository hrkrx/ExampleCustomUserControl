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
   public partial class frmDataView : Form
   {
      public frmDataView()
      {
         InitializeComponent();
      }

      public frmDataView(int userLevel)
      {
         InitializeComponent();
         List<CustomUserControl> customControls = new List<CustomUserControl>();
         foreach (CustomUserControl item in this.Controls)
         {
            if (userLevel < item.UserLevelRequired)
            {
               customControls.Add(item);
            }
         }
         foreach (CustomUserControl item in customControls)
         {
            this.Controls.Remove(item);
         }
      }
   }
}
