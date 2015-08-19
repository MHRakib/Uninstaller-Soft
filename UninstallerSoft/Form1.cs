using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;
using System.IO;

namespace UninstallerSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }
        private void button_click(int a){
            if (a == 1) {
                this.all_prog_button.BackColor = Color.White;
                this.rare_button.BackColor = Color.Navy;
                this.recent_install_button.BackColor = Color.Navy;
                this.start_up_button.BackColor = Color.Navy;
                this.large_program_button.BackColor = Color.Navy;
                this.all_prog_button.ForeColor = Color.Black;
                this.all_prog_button.FlatAppearance.MouseOverBackColor=Color.White;
                this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.rare_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.start_up_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.large_program_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.large_program_button.ForeColor = Color.White;
                this.rare_button.ForeColor = Color.White;
                this.recent_install_button.ForeColor = Color.White;
                this.start_up_button.ForeColor = Color.White;
            }
            else if (a == 2) {
                this.all_prog_button.BackColor = Color.Navy;
                this.rare_button.BackColor = Color.White;
                this.recent_install_button.BackColor = Color.Navy;
                this.start_up_button.BackColor = Color.Navy;
                this.large_program_button.BackColor = Color.Navy;
                this.rare_button.FlatAppearance.MouseOverBackColor = Color.White;
                this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.all_prog_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.start_up_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.large_program_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.rare_button.ForeColor = Color.Black;
                this.large_program_button.ForeColor = Color.White;
                this.all_prog_button.ForeColor = Color.White;
                this.recent_install_button.ForeColor = Color.White;
                this.start_up_button.ForeColor = Color.White;
            
            }
            else if (a == 3) {
                this.all_prog_button.BackColor = Color.Navy;
                this.rare_button.BackColor = Color.Navy;
                this.recent_install_button.BackColor = Color.White;
                this.start_up_button.BackColor = Color.Navy;
                this.large_program_button.BackColor = Color.Navy;
                this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.White;
                this.all_prog_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.rare_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.start_up_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.large_program_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.recent_install_button.ForeColor = Color.Black;
                this.large_program_button.ForeColor = Color.White;
                this.rare_button.ForeColor = Color.White;
                this.all_prog_button.ForeColor = Color.White;
                this.start_up_button.ForeColor = Color.White;
            }
            else if (a == 4) {
                this.all_prog_button.BackColor = Color.Navy;
                this.rare_button.BackColor = Color.Navy;
                this.recent_install_button.BackColor = Color.Navy;
                this.start_up_button.BackColor = Color.White;
                this.start_up_button.ForeColor = Color.Black;
                this.start_up_button.FlatAppearance.MouseOverBackColor = Color.White;
                this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.rare_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.all_prog_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.large_program_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.large_program_button.BackColor = Color.Navy;
                this.large_program_button.ForeColor = Color.White;
                this.rare_button.ForeColor = Color.White;
                this.recent_install_button.ForeColor = Color.White;
                this.all_prog_button.ForeColor = Color.White;
            }
            else if (a == 5) {
                this.all_prog_button.BackColor = Color.Navy;
                this.rare_button.BackColor = Color.Navy;
                this.recent_install_button.BackColor = Color.Navy;
                this.start_up_button.BackColor = Color.Navy;
                this.large_program_button.BackColor = Color.White;
                this.large_program_button.ForeColor = Color.Black;
                this.large_program_button.FlatAppearance.MouseOverBackColor = Color.White;
                this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.rare_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.start_up_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.all_prog_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                this.all_prog_button.ForeColor = Color.White;
                this.rare_button.ForeColor = Color.White;
                this.recent_install_button.ForeColor = Color.White;
                this.start_up_button.ForeColor = Color.White;
            }
        
        }
        private void color_change(object sender, EventArgs e)
        {
            try
            {
                this.button_click(1);
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Publisher");
                dt.Columns.Add("Size");
                dt.Columns.Add("Installed On");
                RegistryKey key;
                DataRow dr;
                // search in: CurrentUser
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    string name= subkey.GetValue("DisplayName") as string;
                    if (name != null) {
                        dr = dt.NewRow();
                        dr["Name"] = name;
                        dr["Publisher"] = subkey.GetValue("Publisher");
                        dr["Size"] = subkey.GetValue("EstimatedSize");
                        dr["Installed on"] = subkey.GetValue("InstallLocation");
                        if (subkey.GetValue("InstallLocation") != null)
                        {
                            Icon icon = IconFromFilePath(subkey.GetValue("InstallLocation").ToString());
                            pictureBox2.Image = Bitmap.FromHicon(icon.Handle);
                            pictureBox2.Show();
                        }
                        dt.Rows.Add(dr);
                    }
                    
                }

                // search in: LocalMachine_32
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    string name = subkey.GetValue("DisplayName") as string;
                    if (name != null)
                    {
                        dr = dt.NewRow();
                        dr["Name"] = name;
                        dr["Publisher"] = subkey.GetValue("Publisher");
                        dr["Size"] = subkey.GetValue("EstimatedSize");
                        dr["Installed on"] = subkey.GetValue("InstallLocation");
                        dt.Rows.Add(dr);
                    }
                    
                }

                // search in: LocalMachine_64
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    string name = subkey.GetValue("DisplayName") as string;
                    if (name != null)
                    {
                        dr = dt.NewRow();
                        dr["Name"] = name;
                        dr["Publisher"] = subkey.GetValue("Publisher");
                        dr["Size"] = subkey.GetValue("EstimatedSize");
                        dr["Installed on"] = subkey.GetValue("InstallLocation");
                        if (subkey.GetValue("InstallLocation") != null)
                        {
                            Icon icon = Icon.ExtractAssociatedIcon((string)subkey.GetValue("InstallLocation"));
                            pictureBox2.Image = icon.ToBitmap();
                            
                        }
                        dt.Rows.Add(dr);
                    }
                 
                }

                this.show_dataGridView.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public Icon IconFromFilePath(string filePath)
        {
            Icon result = null;
            try
            {
                result = Icon.ExtractAssociatedIcon(filePath);
            }
            catch { }
            return result;
        }
        private bool ValueNameExists(string[] valueNames, string valueName)
        {
            foreach (string s in valueNames)
            {
                if (s.ToLower() == valueName.ToLower()) return true;
            }

            return false;
        }

        private void color_mouse_poit(object sender, EventArgs e)
        {
            
        }

        private void color_mouse_point(object sender, EventArgs e)
        {
           // this.all_prog_button.ForeColor = Color.Black;
        }

        private void mouse_leave(object sender, EventArgs e)
        {
           // this.all_prog_button.ForeColor = Color.White;
        }

        private void recent_install_button_Click(object sender, EventArgs e)
        {
            this.button_click(3);
        }

        private void rare_button_Click(object sender, EventArgs e)
        {
            this.button_click(2);
        }

        private void start_up_button_Click(object sender, EventArgs e)
        {
            this.button_click(4);
        }

        private void large_program_button_Click(object sender, EventArgs e)
        {
            this.button_click(5);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.all_prog_button.BackColor = Color.Navy;
            this.rare_button.BackColor = Color.Navy;
            this.recent_install_button.BackColor = Color.Navy;
            this.start_up_button.BackColor = Color.Navy;
            this.large_program_button.BackColor = Color.Navy;
            this.all_prog_button.ForeColor = Color.White;
            this.all_prog_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.rare_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.start_up_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.large_program_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.large_program_button.ForeColor = Color.White;
            this.rare_button.ForeColor = Color.White;
            this.recent_install_button.ForeColor = Color.White;
            this.start_up_button.ForeColor = Color.White;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.all_prog_button.BackColor = Color.Navy;
            this.rare_button.BackColor = Color.Navy;
            this.recent_install_button.BackColor = Color.Navy;
            this.start_up_button.BackColor = Color.Navy;
            this.large_program_button.BackColor = Color.Navy;
            this.all_prog_button.ForeColor = Color.White;
            this.all_prog_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.recent_install_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.rare_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.start_up_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.large_program_button.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            this.large_program_button.ForeColor = Color.White;
            this.rare_button.ForeColor = Color.White;
            this.recent_install_button.ForeColor = Color.White;
            this.start_up_button.ForeColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
