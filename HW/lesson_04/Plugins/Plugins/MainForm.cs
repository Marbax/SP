using System;
using System.Drawing;
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
        private readonly MainViewModel _mvm = new MainViewModel();

        public Bitmap Image
        {
            get { return (Bitmap)pbImage.Image; }
            set { pbImage.Image = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            _ = _mvm.UpdatePluginsAsync(TSMIFilters, OnPluginClick);
            TSMIFilters.Enabled = TSMISaveTo.Enabled = TSMIUpdateFilters.Enabled = false;
        }

        #region Events
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Some usefull info...", "About App", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private async void OnPluginClick(object sender, EventArgs args)
        {
            string pluginName = ((ToolStripMenuItem)sender).Text;
            var opRes = await _mvm.PluginRunAsync(pluginName);
            if (opRes)
                pbImage.Invalidate();
            else
                MessageBox.Show($"Plugin \"{pluginName}\" isn't available at this very moment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mvm.OpenImgIn(pbImage);
            TSMIFilters.Enabled = TSMISaveTo.Enabled = TSMIUpdateFilters.Enabled = true;
        }

        private void TSMIUpdate_Click(object sender, EventArgs e) => _ = _mvm.UpdatePluginsAsync(TSMIFilters, OnPluginClick);

        private void TSMISaveTo_Click(object sender, EventArgs e) => _mvm.SaveImgToFile();

        private void TSMISource_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Marbax/SP/tree/master/HW/lesson_04/Plugins");
        }
        #endregion

    }
}
