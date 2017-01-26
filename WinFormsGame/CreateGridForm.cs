using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convay.WinFormsGame
{
    public partial class CreateGridForm : Form
    {
        public CreateGridForm()
        {
            InitializeComponent();
        }

        public int XSize
        {
            get
            {
                int xSize = -1;
                if (int.TryParse(gridWidth.Text, out xSize) && xSize > 0)
                {
                    return xSize;
                }
                else
                {
                    return -1;
                }
            }
        }
        
        public int YSize
        {
            get
            {
                int ySize = -1;
                if (int.TryParse(gridHeight.Text, out ySize) && ySize > 0)
                {
                    return ySize;
                }
                else
                {
                    return -1;
                }
            }
        }

        private void EnterPressed(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
