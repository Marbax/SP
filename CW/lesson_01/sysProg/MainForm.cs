using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace sysProg
{
    public partial class MainForm : Form
    {
        readonly List<Process> _procs = new List<Process>();
        public MainForm()
        {
            InitializeComponent();


        }

        private void StartApp_click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo(appToExe.Text.Trim(' '));
                proc.Start();
                // stop current proc before raised exit
                //proc.WaitForExit();
                _procs.Add(proc);
                rtbLog.Text += $"\nStarted Id = {proc.Id} Name = {proc.ProcessName} Start at = {proc.StartTime}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void StopAllApps_click(object sender, EventArgs e)
        {
            if (_procs.Count != 0)
            {
                for (int i = 0; i < _procs.Count; i++)
                {
                    try
                    {
                        rtbLog.Text += $"\nClosed {_procs[i].Id} Name = {_procs[i].ProcessName}";
                        _procs[i].CloseMainWindow();
                        _procs[i].Close();
                    }
                    catch (Exception ex)
                    {
                        rtbLog.Text += $"\nCant Close Id = {_procs[i].Id} Name = {_procs[i].ProcessName} Exit at = {_procs[i].ExitTime} Exit code = {_procs[i].ExitCode} {ex}";
                    }
                }
                _procs.Clear();
            }
        }

        private void appToExe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartApp_click(sender, e);
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
            foreach (var item in Process.GetProcesses())
            {
                rtbLog.Text += $"\nId = {item.Id} Name = {item.ProcessName}";
            }
        }

        private void LoadLib_Click(object sender, EventArgs e)
        {
            try
            {
                LoadLibMethod();

            }
            catch (Exception ex)
            {
                rtbLog.Text += $"\nException : {ex}";
            }
        }

        private void LoadLibMethod(string path = "DemoLib.dll")
        {
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName(path));
            Module module = assembly.GetModule(path);
            var classes = module.GetTypes();

            rtbLog.Clear();
            foreach (var item in classes)
            {
                rtbLog.Text += $"\nClass name {item.FullName}";
            }

            Type Person = module.GetType("DemoLib.Person") as Type;
            object person = Activator.CreateInstance(Person, new object[]
                {
                    "Vasya","Pupkin",21
                });

            rtbLog.Text += $"\n{Person.GetMethod("ToString").Invoke(person, null)}";

            Type Employee = module.GetType("DemoLib.Employee") as Type;
            object emp = Activator.CreateInstance(Employee, new object[]
                {
                    "Carpenter",50000M,"Vasya","Pupkin",21
                });

            rtbLog.Text += $"\n{Employee.GetMethod("ToString").Invoke(person, null)}";
        }
    }
}
