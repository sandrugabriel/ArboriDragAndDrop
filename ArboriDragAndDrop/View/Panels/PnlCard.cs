using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlCard : Panel
    {

        Form1 form;
        string data;


        public PnlCard(Form1 form1,string data1) {

            this.form = form1;
            this.data = data1;
            
        
        }


    }
}
