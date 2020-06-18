using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Model.ImageContainer _img = new Model.ImageContainer();
        public Model.ImageContainer Image
        {
            get { return _img; }
            set { SetProperty(ref _img, value); }
        }

        private readonly object _locker = new object();

        #region Image Methods
        public void OpenImgIn(PictureBox container)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphical files (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
                try
                {
                    Bitmap bmp = new Bitmap(ofd.FileName);
                    Image.Image = bmp;
                    container.Image = Image.Image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception on image loading: " + ex.Message);
                }

        }

        public void SaveImgToFile()
        {
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.Filter = "JPeg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif";
                ofd.Title = "Save an Image File";
                ofd.FileName = "newImage";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (Image.Image != null)
                {
                    if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    {
                        try
                        {
                            FileStream fs = ofd.OpenFile() as FileStream;

                            ImageFormat frmt = ImageFormat.Png;
                            switch (ofd.FilterIndex)
                            {
                                case 1:
                                    frmt = ImageFormat.Jpeg;
                                    break;
                                case 2:
                                    frmt = ImageFormat.Png;
                                    break;
                                case 3:
                                    frmt = ImageFormat.Bmp;
                                    break;
                                case 4:
                                    frmt = ImageFormat.Gif;
                                    break;
                                default:
                                    break;
                            }

                            Image.Image.Save(fs, frmt);
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Exception on image saving.");
                        }
                    }
                }
                else
                    MessageBox.Show("There is no Image to save", "Error!");
            }

        }
        #endregion

        #region Plugins
        private readonly Hashtable _plugins = new Hashtable();

        private readonly string _plaginDir = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");

        public async Task<bool> PluginRunAsync(string pluginName) => await Task.Factory.StartNew(() => PluginRun(pluginName, Image));

        public bool PluginRun(string pluginName, Interface.IModel runOn)
        {
            try
            {
                Interface.IPlugin plugin = (Interface.IPlugin)_plugins[pluginName];
                lock (_locker)
                {
                    plugin.Transform(runOn);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Plugin {pluginName} isn't awailable at this very moment.\n {ex.Message}");
                return false;
            }
        }

        #region Plugins Loading
        public async Task UpdatePluginsAsync(ToolStripMenuItem toolStrip, Action<object, EventArgs> onPluginClick)
        {
            await Task.Factory.StartNew(() => FindPluginsAsync());
            CreatePluginsMenu(toolStrip, onPluginClick);
        }

        private void FindPluginsAsync()
        {
            _plugins.Clear();
            string[] libs = Directory.GetFiles(_plaginDir, "*.dll");

            Parallel.ForEach(libs, (lib) =>
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(lib);

                    List<Type> types = assembly.GetTypes().Where(t => t.GetInterfaces().Where(i => i.FullName == typeof(Interface.IPlugin).FullName).Any()).ToList();

                    types.ForEach(type =>
                    {
                        Interface.IPlugin plugin = (Interface.IPlugin)Activator.CreateInstance(type);
                        _plugins.Add(plugin.Name, plugin);
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plugin load exception\n" + ex.Message);
                }

            });
        }

        private void CreatePluginsMenu(ToolStripMenuItem toolStrip, Action<object, EventArgs> onPluginClick)
        {
            toolStrip.DropDownItems.Clear();
            EventHandler handler = new EventHandler(onPluginClick);

            foreach (string name in _plugins.Keys)
                toolStrip.DropDownItems.Add(name, null, handler);
        }
        #endregion

        #endregion

        #region INotify implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        protected void SetProperty<T>(ref T oldValue, T newValue, [CallerMemberName]string propertyName = null)
        {
            if (!oldValue?.Equals(newValue) ?? newValue != null)
            {
                oldValue = newValue;

                OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
