using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using bind.Properties;
using System.Drawing.Imaging;
using System.Reflection;
using System.Net.Mail;

namespace bind
{
    public partial class Form1 : Form
    {
        //СВОРАЧИВАНИЕ ФОРМЫ 1 ИЗ 3 ФРАГМЕНТОВ
        public Form1()
        {
            InitializeComponent();
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(
                        new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(921, 533);
            this.Text = "Notify Icon Example";

            // Create the NotifyIcon.
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            notifyIcon1.Icon = new Icon("appicon.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "Form1 (NotifyIcon example)";
            notifyIcon1.Visible = true;

            // Handle the DoubleClick event to activate the form.
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);

            textBox1.Text = Settings.Default["save1"].ToString();
            textBox2.Text = Settings.Default["save2"].ToString();
            textBox3.Text = Settings.Default["save3"].ToString();
            textBox4.Text = Settings.Default["save4"].ToString();
            textBox5.Text = Settings.Default["save5"].ToString();
            textBox6.Text = Settings.Default["save6"].ToString();
            textBox7.Text = Settings.Default["save7"].ToString();
            textBox8.Text = Settings.Default["save8"].ToString();
            textBox9.Text = Settings.Default["save9"].ToString();
            textBox10.Text = Settings.Default["save10"].ToString();
            textBox11.Text = Settings.Default["save11"].ToString();

            checkBox8.Visible = false;
            checkBox9.Visible = false;
        }


        bool chek1, chek2, chek3, chek4, chek5, chek6, chek7, chek8, chek9, chek0 = false;


        // ОТКРЫТЬ ФАЙЛ В ТЕКСТ БОКСЕ
        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox7.Text = ofd.FileName;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox8.Text = ofd.FileName;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox9.Text = ofd.FileName;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox10.Text = ofd.FileName;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox5.Text = ofd.FileName;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox4.Text = ofd.FileName;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox6.Text = ofd.FileName;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox3.Text = ofd.FileName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox2.Text = ofd.FileName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox1.Text = ofd.FileName;
        }

        //СВЕРНУТЬ ФОРМУ
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        //ОТЧИСТИТЬ ТЕКСТ БОКС
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
        }


        //ЗАПОМИНАНИЕ ТЕКСТ БОКСА ПРИ ЗАКРЫТИИ ПРИЛОЖЕНИЯ
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save1"] = textBox1.Text;
            Settings.Default.Save();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save6"] = textBox6.Text;
            Settings.Default.Save();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save2"] = textBox2.Text;
            Settings.Default.Save();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save3"] = textBox3.Text;
            Settings.Default.Save();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save4"] = textBox4.Text;
            Settings.Default.Save();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save5"] = textBox5.Text;
            Settings.Default.Save();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save7"] = textBox7.Text;
            Settings.Default.Save();
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save8"] = textBox8.Text;
            Settings.Default.Save();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save9"] = textBox9.Text;
            Settings.Default.Save();
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save10"] = textBox10.Text;
            Settings.Default.Save();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["save11"] = textBox11.Text;
            Settings.Default.Save();
        }


        //ГЛОБАЛ ХУК ДЛЯ КЛАВИШ САМ СКРИПТ
        class globalKeyboardHook
        {
            #region Constant, Structure and Delegate Definitions
            /// <summary>
            /// defines the callback type for the hook
            /// </summary>
            // public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

            public struct keyboardHookStruct
            {
                public int vkCode;
                public int scanCode;
                public int flags;
                public int time;
                public int dwExtraInfo;
            }

            const int WH_KEYBOARD_LL = 13;
            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int WM_SYSKEYDOWN = 0x104;
            const int WM_SYSKEYUP = 0x105;
            #endregion

            #region Instance Variables
            /// <summary>
            /// The collections of keys to watch for
            /// </summary>
            public List<Keys> HookedKeys = new List<Keys>();
            /// <summary>
            /// Handle to the hook, need this to unhook and call the next hook
            /// </summary>
            IntPtr hhook = IntPtr.Zero;
            #endregion

            #region Events
            /// <summary>
            /// Occurs when one of the hooked keys is pressed
            /// </summary>
            public event KeyEventHandler KeyDown;
            /// <summary>
            /// Occurs when one of the hooked keys is released
            /// </summary>
            public event KeyEventHandler KeyUp;
            #endregion

            #region Constructors and Destructors
            /// <summary>
            /// Initializes a new instance of the <see cref="globalKeyboardHook"/> class and installs the keyboard hook.
            /// </summary>
            public globalKeyboardHook()
            {
                hook();
            }

            /// <summary>
            /// Releases unmanaged resources and performs other cleanup operations before the
            /// <see cref="globalKeyboardHook"/> is reclaimed by garbage collection and uninstalls the keyboard hook.
            /// </summary>
            ~globalKeyboardHook()
            {
                unhook();
            }
            #endregion

            #region Public Methods
            /// <summary>
            /// Installs the global hook
            /// </summary>
            public void hook()
            {

                IntPtr hInstance = LoadLibrary("User32");
                //hhook = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
                delegateHookProc = hookProc;
                hhook = SetWindowsHookEx(WH_KEYBOARD_LL, delegateHookProc, hInstance, 0);
            }
            public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);
            keyboardHookProc delegateHookProc;
            /// <summary>
            /// Uninstalls the global hook
            /// </summary>
            public void unhook()
            {
                UnhookWindowsHookEx(hhook);
            }

            /// <summary>
            /// The callback for the keyboard hook
            /// </summary>
            /// <param name="code">The hook code, if it isn't >= 0, the function shouldn't do anyting</param>
            /// <param name="wParam">The event type</param>
            /// <param name="lParam">The keyhook event information</param>
            /// <returns></returns>
            public int hookProc(int code, int wParam, ref keyboardHookStruct lParam)
            {
                if (code >= 0)
                {
                    Keys key = (Keys)lParam.vkCode;
                    if (HookedKeys.Contains(key))
                    {
                        KeyEventArgs kea = new KeyEventArgs(key);
                        if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && (KeyDown != null))
                        {
                            KeyDown(this, kea);
                        }
                        else
                        if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && (KeyUp != null))
                        {
                            KeyUp(this, kea);
                        }
                        if (kea.Handled)
                            return 1;
                    }
                }
                return CallNextHookEx(hhook, code, wParam, ref lParam);
            }
            #endregion

            #region DLL imports
            /// <summary>
            /// Sets the windows hook, do the desired event, one of hInstance or threadId must be non-null
            /// </summary>
            /// <param name="idHook">The id of the event you want to hook</param>
            /// <param name="callback">The callback.</param>
            /// <param name="hInstance">The handle you want to attach the event to, can be null</param>
            /// <param name="threadId">The thread you want to attach the event to, can be null</param>
            /// <returns>a handle to the desired hook</returns>
            [DllImport("user32.dll")]
            static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

            /// <summary>
            /// Unhooks the windows hook.
            /// </summary>
            /// <param name="hInstance">The hook handle that was returned from SetWindowsHookEx</param>
            /// <returns>True if successful, false otherwise</returns>
            [DllImport("user32.dll")]
            static extern bool UnhookWindowsHookEx(IntPtr hInstance);

            /// <summary>
            /// Calls the next hook.
            /// </summary>
            /// <param name="idHook">The hook id</param>
            /// <param name="nCode">The hook code</param>
            /// <param name="wParam">The wparam.</param>
            /// <param name="lParam">The lparam.</param>
            /// <returns></returns>
            [DllImport("user32.dll")]
            static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

            /// <summary>
            /// Loads the library.
            /// </summary>
            /// <param name="lpFileName">Name of the library</param>
            /// <returns>A handle to the library</returns>
            [DllImport("kernel32.dll")]
            static extern IntPtr LoadLibrary(string lpFileName);
            #endregion
        }

        //ВЫБОР КЛАВИШ ДЛЯ ГЛОБАЛ ХУКА
        globalKeyboardHook gkh = new globalKeyboardHook();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.D1);
            gkh.HookedKeys.Add(Keys.D2);
            gkh.HookedKeys.Add(Keys.D3);
            gkh.HookedKeys.Add(Keys.D4);
            gkh.HookedKeys.Add(Keys.D5);
            gkh.HookedKeys.Add(Keys.D6);
            gkh.HookedKeys.Add(Keys.D7);
            gkh.HookedKeys.Add(Keys.D8);
            gkh.HookedKeys.Add(Keys.D9);
            gkh.HookedKeys.Add(Keys.D0);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        

        //ДЕЙСТВИЯ С КЛАВИШАМИ ДЛЯ ГЛОБАЛ ХУКА
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100000);
            string rdnumb = value.ToString();


            //CHECK BOX
            if (e.KeyCode == Keys.D1 && checkBox1.Checked == true) {
                if(textBox11.Text != ""){ 
                string pathscreen = textBox11.Text + @"\screen" + $"{rdnumb}" + @".jpg";
                Bitmap printscreen = new Bitmap(1920, 1080);
                Graphics graphics = Graphics.FromImage(printscreen as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
                printscreen.Save($"{pathscreen}", ImageFormat.Jpeg);
                }
                else{MessageBox.Show("Не выбрана папка для скриншота!");}

            }
            else if(e.KeyCode == Keys.D1 && checkBox1.Checked == false)
            {
                if(textBox1.Text == "") {MessageBox.Show("Не выбран файл");}
                else if(e.KeyCode == Keys.D1) {
                    try {Process.Start(textBox1.Text);}
                    catch {MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную.");}
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D2 && checkBox2.Checked == true)
            {
                Process snippingToolProcess = new Process();
                snippingToolProcess.EnableRaisingEvents = true;
                if (!Environment.Is64BitProcess)
                {
                    snippingToolProcess.StartInfo.FileName = "C:\\Windows\\sysnative\\SnippingTool.exe";
                    snippingToolProcess.Start();
                }
                else
                {
                    snippingToolProcess.StartInfo.FileName = "C:\\Windows\\system32\\SnippingTool.exe";
                    snippingToolProcess.Start();
                }
            }
            else if(e.KeyCode == Keys.D2 && checkBox2.Checked == false)
            {
                if(textBox2.Text == "") {MessageBox.Show("Не выбран файл");}
                else if(e.KeyCode == Keys.D2) {
                    try {Process.Start(textBox2.Text);}
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }  
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D3 && checkBox3.Checked == true)
            {
                System.Diagnostics.Process.Start("Taskmgr.exe");
            }
            else if (e.KeyCode == Keys.D3 && checkBox3.Checked == false)
            {
                if (textBox3.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D3)
                {
                    try { Process.Start(textBox3.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D4 && checkBox4.Checked == true)
            {
                System.Diagnostics.Process.Start("compmgmt.msc");
            }
            else if (e.KeyCode == Keys.D4 && checkBox4.Checked == false)
            {
                if (textBox4.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D4)
                {
                    try { Process.Start(textBox4.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D5 && checkBox5.Checked == true)
            {
                System.Diagnostics.Process.Start("explorer");
            }
            else if (e.KeyCode == Keys.D5 && checkBox5.Checked == false)
            {
                if (textBox5.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D5)
                {
                    try { Process.Start(textBox5.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D6 && checkBox6.Checked == true)
            {
                Process.Start("mspaint.exe");

            }
            else if (e.KeyCode == Keys.D6 && checkBox6.Checked == false)
            {
                if (textBox6.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D6)
                {
                    try { Process.Start(textBox6.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D7 && checkBox7.Checked == true)
            {
                System.Diagnostics.Process.Start("calc");
            }
            else if (e.KeyCode == Keys.D7 && checkBox7.Checked == false)
            {
                if (textBox7.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D7)
                {
                    try { Process.Start(textBox7.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D8 && checkBox8.Checked == true)
            {
                MessageBox.Show("hello world");
            }
            else if (e.KeyCode == Keys.D8 && checkBox8.Checked == false)
            {
                if (textBox8.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D8)
                {
                    try { Process.Start(textBox8.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D9 && checkBox9.Checked == true)
            {
                MessageBox.Show("hello world");
            }
            else if (e.KeyCode == Keys.D9 && checkBox9.Checked == false)
            {
                if (textBox9.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D9)
                {
                    try { Process.Start(textBox9.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }
            //CHECK BOX
            if (e.KeyCode == Keys.D0 && checkBox10.Checked == true)
            {
                Application.SetSuspendState(PowerState.Suspend, true, true);
            }
            else if (e.KeyCode == Keys.D0 && checkBox10.Checked == false)
            {
                if (textBox3.Text == "") { MessageBox.Show("Не выбран файл"); }
                else if (e.KeyCode == Keys.D0)
                {
                    try { Process.Start(textBox10.Text); }
                    catch { MessageBox.Show("Не выбран формат открытия файла! Необходимо запустить вручную."); }
                }
            }

        }
        }

    
    }

