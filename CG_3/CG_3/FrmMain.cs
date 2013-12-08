using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace CG_3
{
    public partial class FrmMain : Form
    {
        private Cone _cone;
        private Tools _gTools;
        private Light _light;

        private bool Init()
        {
            Deploy deploy = new Deploy();
            Thread depThread = new Thread(new ThreadStart(deploy.RecreateAllExecutableResources));
            depThread.Start();
            depThread.Join();

            _cone = new Cone();
            _gTools = new Tools();
            try
            {
                sogMain.InitializeContexts();
                _gTools.GlutInitilization(sogMain);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            if (!Init())
                this.Close();
        }

        private void sogMain_MouseMove(object sender, MouseEventArgs e)
        {
            _gTools.Render(sogMain, new Point{X = e.X, Y = e.Y}, _cone);
        }

        private void btnConeSettingsApply_Click(object sender, EventArgs e)
        {
            _cone.Height = (double) nupConeHeight.Value;
            _cone.Radius = (double) nupConeRadius.Value;
            _cone.Slices = (int) nupConeSlices.Value;
        }

        private void btnLightSelectColor_Click(object sender, EventArgs e)
        {
            if (cdLightMain.ShowDialog() == DialogResult.OK)
            {
                pbColorPreviewMain.BackColor = cdLightMain.Color;
            }
        }

        private void btnLightSettingsApply_Click(object sender, EventArgs e)
        {
            _light = new Light
            {
                Color = cdLightMain.Color, 
                X = (int) nupLightX.Value, 
                Y = (int) nupLightY.Value,
                Z = (int) nupLightZ.Value
            };
            _gTools.SetLight(_light);

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    }
}
