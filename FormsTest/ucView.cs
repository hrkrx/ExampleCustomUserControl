using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
   public partial class ucView : CustomUserControl
   {
      public ucView()
      {
         InitializeComponent();
         UserLevelRequired = 0;
      }
   }
}
