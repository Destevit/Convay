using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convay.Core;
using Convay.WinExtension;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Convay.Core.Interfaces;


namespace Convay.WinFormsGame
{
    public partial class MainForm : Form
    {
        IGame game;
        IVisualizer visualizer;
        IByteVisualizer byteVisualizer;

        public MainForm()
        {
            InitializeComponent();
            Settings.engineType = typeof(ParallelEngine);
            Settings.gridType = typeof(ByteGrid);
            Settings.visualizerType = typeof(UnsafeVisualizer);
            visualizer = new UnsafeVisualizer();
            byteVisualizer = new ByteVisualizer();
            game = new Game(new ParallelEngine(), new ByteGrid(500, 250), new StringRules("23/3"), new TimeSpan());
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(Properties.Resources.colorful);
            Settings.livingColors = bf.Deserialize(ms) as Color[];
            Settings.deadColors = bf.Deserialize(ms) as Color[];
            Settings.extendedDrawing = true;
            ms.Close();
            game.GridChanged += Game_GridChanged;
        }

        private void Game_GridChanged(object sender, GridChangedEventArgs e)
        {
            interpolatedPictureBox1.Invoke((Action)delegate {
                bool isRunning = game.IsRunning;
                game.Stop();
                drawGrid(e.Grid);
                if(isRunning)
                    Task.Run((Action)game.Start);
            });
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGridForm dialog = new CreateGridForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.XSize > 0 && dialog.YSize > 0)
                {
                    game.Grid = (IGrid)Activator.CreateInstance(Settings.gridType, dialog.XSize, dialog.YSize);
                }
                else
                {
                    MessageBox.Show(this, "Invalid size!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void interpolationToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in (sender as ToolStripMenuItem).DropDown.Items)
            {
                item.Checked = false;
            }
            switch (interpolatedPictureBox1.Interpolation)
            {
                case System.Drawing.Drawing2D.InterpolationMode.Bicubic:
                    bicubicToolStripMenuItem.Checked = true;
                    break;
                case System.Drawing.Drawing2D.InterpolationMode.Bilinear:
                    bilinearToolStripMenuItem.Checked = true;
                    break;
                case System.Drawing.Drawing2D.InterpolationMode.High:
                    highToolStripMenuItem.Checked = true;
                    break;
                case System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic:
                    bicubicHQToolStripMenuItem.Checked = true;
                    break;
                case System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear:
                    bilinearHQToolStripMenuItem.Checked = true;
                    break;
                case System.Drawing.Drawing2D.InterpolationMode.Low:
                    lowToolStripMenuItem.Checked = true;
                    break;
                case System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor:
                    sharpToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void interpolationDownStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                switch (menuItem.Tag.ToString())
                {
                    case "tsmi/i/l":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.Low;
                        break;
                    case "tsmi/i/h":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.High;
                        break;
                    case "tsmi/i/bc":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                        break;
                    case "tsmi/i/hqbc":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        break;
                    case "tsmi/i/hqbr":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                        break;
                    case "tsmi/i/nn":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                        break;
                    case "tsmi/i/br":
                        interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                        break;
                    default:
                        break;
                }
            }
        }

        private void sizeModeDownStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                switch (menuItem.Tag.ToString())
                {
                    case "tsmi/sm/c":
                        interpolatedPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        break;
                    case "tsmi/sm/z":
                        interpolatedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case "tsmi/sm/s":
                        interpolatedPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    default:
                        break;
                }
            }
        }

        private void sizeModeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in (sender as ToolStripMenuItem).DropDown.Items)
            {
                item.Checked = false;
            }
            switch (interpolatedPictureBox1.SizeMode)
            {
                case PictureBoxSizeMode.CenterImage:
                    normalToolStripMenuItem.Checked = true;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    stretchToolStripMenuItem.Checked = true;
                    break;
                case PictureBoxSizeMode.Zoom:
                    zoomToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Randomize();
        }

        private void setRulesToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            gameRulesTextBox.Text = game.Rules.ToStringFormat();
        }

        private void setRulesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                game.Rules = new StringRules(gameRulesTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                gameRulesTextBox.Text = game.Rules.ToStringFormat();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IGridSerializer serializer = new GridSerializer();
                if (Path.GetExtension(openFileDialog1.FileName).ToLower() != ".glg")
                    serializer = new BitmapSerializer(new UnsafeVisualizer());
                IGrid grid = (IGrid)Activator.CreateInstance(Settings.gridType, 0, 0);
                FileStream stream = null;
                try
                {
                    stream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    serializer.LoadFromStream(stream, grid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    stream.Close();
                }
                game.Grid = grid;
            }
        }

        private void drawGrid(IGrid grid)
        {
            State.fps++;
            if (Settings.extendedDrawing)
            {
                if (grid is IByteGrid)
                {
                    interpolatedPictureBox1.Image = byteVisualizer.ToBitmap((IByteGrid)grid, Settings.livingColors, Settings.deadColors);
                }
                else
                {
                    interpolatedPictureBox1.Image = visualizer.ToBitmap(grid, Settings.livingColors[7], Settings.deadColors[7]);
                }
            }
            else
                interpolatedPictureBox1.Image = visualizer.ToBitmap(grid, Settings.livingColors[7], Settings.deadColors[7]);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IGridSerializer serializer = new GridSerializer(); ;
                if (Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".bmp")
                    serializer = new BitmapSerializer(new UnsafeVisualizer());
                FileStream stream = null;
                try
                {
                    stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    serializer.SaveToStream(game.Grid, stream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
        }

        private void intervalToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            intervalTextBoxToolStripMenuItem.Text = game.Interval.TotalMilliseconds.ToString();
        }

        private void intervalToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            int interval = 0;
            if (int.TryParse(intervalTextBoxToolStripMenuItem.Text, out interval))
            {
                game.Interval = new TimeSpan(0,0,0,0,interval);
            }
            else
            {
                MessageBox.Show(this, "Interval is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run((Action)game.Start);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Stop();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppearanceForm af = new AppearanceForm(Settings.livingColors, Settings.deadColors);
            if (af.ShowDialog() == DialogResult.OK)
            {
                Settings.livingColors = af.LivingColors;
                Settings.deadColors = af.DeadColors;
            }
        }

        private void colorsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            extendedToolStripMenuItem.Checked = Settings.extendedDrawing;
            simpleToolStripMenuItem.Checked = !Settings.extendedDrawing;
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.extendedDrawing = false;
        }

        private void extendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.extendedDrawing = true;
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.extendedDrawing = true;
            interpolatedPictureBox1.Interpolation = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            interpolatedPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            game.Engine = new ParallelEngine();
            game.Grid = new ByteGrid(200, 100);
            game.Randomize();
            WindowState = FormWindowState.Maximized;
            game.Interval = new TimeSpan();
            startToolStripMenuItem_Click(null, null);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                switch (sf.Drawing)
                {
                    case SettingsForm.DrawingType.safeDrawing:
                        Settings.visualizerType = typeof(SafeVisualizer);
                        break;
                    case SettingsForm.DrawingType.unsafeDrawing:
                        Settings.visualizerType = typeof(UnsafeVisualizer);
                        break;
                    default:
                        break;
                }
                switch (sf.Grid)
                {
                    case SettingsForm.GridType.GridCorePoint:
                        Settings.gridType = typeof(GenericGrid<Core.Point>);
                        break;
                    case SettingsForm.GridType.ByteGrid:
                        Settings.gridType = typeof(ByteGrid);
                        break;
                    default:
                        break;
                }
                switch (sf.Engine)
                {
                    case SettingsForm.EngineType.Engine:
                        Settings.engineType = typeof(Engine);
                        break;
                    case SettingsForm.EngineType.ParallelEngine:
                        Settings.engineType = typeof(ParallelEngine);
                        break;
                    default:
                        break;
                }
                visualizer = (IVisualizer)Activator.CreateInstance(Settings.visualizerType);
                game.Engine = (Engine)Activator.CreateInstance(Settings.engineType);
            }
        }

        private void fpsCounter_Tick(object sender, EventArgs e)
        {
            fps.Text = State.fps + "fps";
            State.fps = 0;
        }

        private void enToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            infoToolStripMenuItem.Text = "used engine: " + game.Engine.GetType()
                + " used grid: " + game.Grid.GetType() + " used visualizer: " + visualizer.GetType();
        }

        private void enToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            infoToolStripMenuItem.Text = "hover for info";
        }

        private void interpolatedPictureBox1_Click(object sender, EventArgs e)
        {
            IGrid grid = game.Grid.Clone();
            PictureBox pictureBox = sender as PictureBox;
            MouseEventArgs mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs == null || pictureBox == null)
                return;
            int gridX = (int)(((double)mouseEventArgs.X / pictureBox.Width) * grid.XSize);
            int gridY = (int)(((double)mouseEventArgs.Y / pictureBox.Height) * grid.YSize);
            if (mouseEventArgs.Button == MouseButtons.Left)
                grid[gridX, gridY] = true;
            else if (mouseEventArgs.Button == MouseButtons.Right)
                grid[gridX, gridY] = false;
            game.Grid = grid;
        }
    }
}
