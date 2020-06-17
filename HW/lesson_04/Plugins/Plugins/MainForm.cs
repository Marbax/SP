using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;

/// <summary>
/// Создать плагин, который позволяет сделать изображение черно-белым.
/// Реализовать сохранение изображения в файл.
/// Интерфейс всегда должен реагировать на действия пользователя.
/// </summary>
namespace Plugins
{
    public partial class MainForm : Form
    {
        private MainViewModel _mvm = new MainViewModel();

        public Bitmap Image
        {
            get { return (Bitmap)pbImage.Image; }
            set { pbImage.Image = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            _ = _mvm.UpdatePluginsAsync(TSMIFilters, OnPluginClick);
        }

        #region Events
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Some usefull info...", "About App", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private async void OnPluginClick(object sender, EventArgs args)
        {
            string pluginName = ((ToolStripMenuItem)sender).Text;
            if (!(await _mvm.PluginRunAsync(pluginName)))
                MessageBox.Show($"Plugin \"{pluginName}\" isn't available at this very moment.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) => _mvm.OpenImgIn(pbImage);

        private void TSMIUpdate_Click(object sender, EventArgs e) => _ = _mvm.UpdatePluginsAsync(TSMIFilters, OnPluginClick);

        private void TSMISaveTo_Click(object sender, EventArgs e) => _mvm.SaveImgToFile(pbImage.Image as Bitmap);
        #endregion

    }
}
