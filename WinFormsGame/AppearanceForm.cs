using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convay.WinFormsGame
{
    public partial class AppearanceForm : Form
    {
        public AppearanceForm(Color[] livingColors, Color[] deadColors)
        {
            InitializeComponent();
            setColorArray(groupBox1.Controls, livingColors);
            setColorArray(groupBox2.Controls, deadColors);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox senderTextBox = sender as TextBox;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                color = changeColorBox(senderTextBox, color);
            }
        }

        private void setDefault()
        {
            Color [] livingColors = new Color[8];
            Color [] deadColors = new Color[8];
            for (int i = 0; i < 8; i++)
            {
                livingColors[i] = Color.Black;
                deadColors[i] = Color.White;
            }
            setColorArray(groupBox1.Controls, livingColors);
            setColorArray(groupBox2.Controls, deadColors);
        }

        private static Color changeColorBox(Control textBox, Color color)
        {
            textBox.Text = ColorTranslator.ToHtml(color);
            textBox.BackColor = color;
            if (color.GetBrightness() < 0.5f)
            {
                textBox.ForeColor = Color.White;
            }
            else
            {
                textBox.ForeColor = Color.Black;
            }
            return color;
        }

        public Color[] LivingColors
        {
            get
            {
                return getColorArray(groupBox1.Controls);
            }
        }
        public Color[] DeadColors
        {
            get
            {
                return getColorArray(groupBox2.Controls);
            }
        }

        private Color[] getColorArray(Control.ControlCollection cc)
        {
            Color[] result = new Color[8];
            int index = 0;
            foreach (Control item in cc)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    index = Convert.ToInt32(tb.Tag);
                    result[index] = tb.BackColor;
                }
            }
            return result;
        }
        private void setColorArray(Control.ControlCollection cc, Color[] colorArray)
        {
            int index = 0;
            foreach (Control item in cc)
            {
                if (item is TextBox)
                {
                    index = Convert.ToInt32(item.Tag);
                    changeColorBox(item, colorArray[index]);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, LivingColors);
                    bf.Serialize(fs, DeadColors);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    setColorArray(groupBox1.Controls, (Color[])bf.Deserialize(fs));
                    setColorArray(groupBox2.Controls, (Color[])bf.Deserialize(fs));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
        }

        private void def_Click(object sender, EventArgs e)
        {
            setDefault();
        }
    }
}
