using Convay.WinExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convay.WinFormsGame
{
    public partial class SettingsForm : Form
    {
        public enum EngineType
        {
            Engine,
            ParallelEngine
        }
        public enum GridType
        {
            GridCorePoint,
            ByteGrid
        }
        public enum DrawingType
        {
            safeDrawing,
            unsafeDrawing
        }
        public SettingsForm()
        {
            InitializeComponent();
            engineStandard.Checked = Settings.engineType == typeof(Core.Engine);
            parallelEngine.Checked = Settings.engineType == typeof(Core.ParallelEngine);
            gridCorePointType.Checked = Settings.gridType == typeof(Core.GenericGrid<Core.Point>);
            byteGridType.Checked = Settings.gridType == typeof(Core.ByteGrid);
            unsafeType.Checked = Settings.visualizerType == typeof(UnsafeVisualizer);
            safeType.Checked = Settings.visualizerType == typeof(SafeVisualizer);
        }
        public EngineType Engine
        {
            get
            {
                EngineType et = 0;
                if (engineStandard.Checked)
                {
                    et = EngineType.Engine;
                }
                if (parallelEngine.Checked)
                {
                    et = EngineType.ParallelEngine;
                }
                return et;
            }
        }
        public GridType Grid
        {
            get
            {
                GridType grid = 0;
                if (gridCorePointType.Checked)
                {
                    grid = GridType.GridCorePoint;
                }
                if (byteGridType.Checked)
                {
                    grid = GridType.ByteGrid;
                }
                return grid;
            }
        }
        public DrawingType Drawing
        {
            get
            {
                DrawingType draw = 0;
                if (safeType.Checked)
                {
                    draw = DrawingType.safeDrawing;
                }
                if (unsafeType.Checked)
                {
                    draw = DrawingType.unsafeDrawing;
                }
                return draw;
            }
        }
    }
}
