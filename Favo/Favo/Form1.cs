﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Favo
{
    public partial class Form1 : Form
    {
        #region Variables
        private Point mouseLocation;
        private Registers register;
        private RegisterMachine rM;
        private static string openPath;
        private DataTable dt;
       
        private int index = 0;
        private string[] displayText;
        private bool saved, compiled, ifMode; //ifMode indicates whether basic if is used instead of complex if
        private bool waitingForInput = false;
        private bool StepByStep = false;
        private string InputString = "";
        private string OutputString = "";
        private const int qAnzahl = 25;

        #endregion

        // custom colorTable class for MenuStrip (custom appearance)
        private class CustomColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected { get { return Color.FromArgb(44, 47, 51); } }
            public override Color MenuItemBorder { get { return Color.FromArgb(114, 137, 218); } }
        }

        // Constructor, initialize important components and variables 
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());


            register = new Registers();
            dt = new DataTable();
            saved = true;
            compiled = false;
            ifMode = false;
            displayText = new string[qAnzahl];
            displayText = FileHandler.QFiller(qAnzahl);
            rM = new RegisterMachine(new List<string>() { "" }, ifMode);

            // Columns
            dt.Columns.Add("Index");
            dt.Columns.Add("Value");

            // set columns
            dataGridView2.DataSource = dt;


            // disable sorting of columns
            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        #region EventHandler

        // Render Form with Custom Colors
        private void Form_Load(object sender, EventArgs e)
        {
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }

        // Event Handler for the "Neu" item from the MenuStrip, resets all variables and TextEditorBox.Text
        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openPath = null;
            saved = true;
            CheckSavedStatus("new");
            textEditorBox.Text = "";


        }

        // Event Handler for the "Öffnen" item from the MenuStrip
        private void ÖffnenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saved = true;
            CheckSavedStatus("open");
        }

        // Event Handler for the "Speichern" item from the MenuStrip
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Execute SaveAs method when openPath not initialized
            if (openPath != null)
                FileHandler.SaveFileContent(openPath, textEditorBox.Text);
            else
                SaveAsToolStripMenuItem_Click(sender, e);

            saved = true;
        }

        // Event Handler for the "Speichern als.." item from the MenuStrip
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get path from SaveFileDialog, save TextEditorBox content at path
            string s = Dialog.SaveFileDialog();
            openPath = s;

            if (s != null)
                FileHandler.SaveFileContent(s, textEditorBox.Text);

            saved = true;

        }

        //Event Handler for the "Run" item in the MenuStrip, compiles and runs the program
        private void RunToolStripMenuItemClick(object sender, EventArgs e)
        {
            waitingForInput = false;

            StepByStep = false;
            UpdateCodelines();
            errorBox.Text = "";

            try
            {
                rM = new RegisterMachine(textEditorBox.Text.Split('\n').ToList(), ifMode);
                compiled = true;

                RegisterMachine.ReturnType T = RegisterMachine.ReturnType.RUNNING;

                // Execute code until end or input/output command
                while (T != RegisterMachine.ReturnType.END)
                {
                    T = rM.ExecuteRegisterMachine(ref OutputString);
                    // Show output if asked for
                    if (T == RegisterMachine.ReturnType.OUTPUT)
                    {
                        errorBox.Text = OutputString;
                    }

                    // Set register machine to "wait"-state and request input
                    if (T == RegisterMachine.ReturnType.INPUT)
                    {
                        UpdateLabels();
                        UpdateDataGridView();
                        waitingForInput = true;
                        inputTextBox.ReadOnly = false;
                        inputTextBox.Enabled = true;
                        inputTextBox.Text = "Waiting for Input";
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                errorBox.Text = exception.Message;
            }

            UpdateLabels();
            UpdateDataGridView();

            rM.ResetState();
        }

        // Event Handler for StepByStep ToolStripMenuItem, executes one line of code per click
        private void StepByStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!waitingForInput)
            {
                StepByStep = true;
                try
                {
                    // Don't compile twice if code is already compiled
                    if (!compiled)
                    {
                        errorBox.Text = "";
                        rM = new RegisterMachine(textEditorBox.Text.Split('\n').ToList(), ifMode);
                        compiled = true;
                    }

                    Highlight();

                    // Check if there are more steps available or end of code is reached
                    RegisterMachine.ReturnType T = rM.ExecuteOneStep(ref OutputString);

                    switch(T)
                    {
                        case RegisterMachine.ReturnType.OUTPUT:
                            errorBox.Text = OutputString;
                            break;

                        case RegisterMachine.ReturnType.INPUT:
                            UpdateLabels();
                            UpdateDataGridView();
                            waitingForInput = true;
                            inputTextBox.ReadOnly = false;
                            inputTextBox.Enabled = true;
                            inputTextBox.Text = "Waiting for Input";
                            return;

                        case RegisterMachine.ReturnType.END:
                            UpdateLabels();
                            UpdateDataGridView();
                            errorBox.Text = "Program execution finished!";

                            rM.ResetState();
                            break;

                        default:
                            UpdateLabels();
                            UpdateDataGridView();
                            break;
                    }
                }
                catch (Exception exc)
                {
                    errorBox.Text = exc.Message;
                }
            }
        }

        //Event handler for the "imode"item in the MenuStrip, switches between if-modes
        void IfModeToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Invert ifMode bool
            ifMode = !ifMode;

            // Change icon of ifModeToolStripMenuItem according to ifMode bool value
            if (ifMode == true)
            {
                ifModeToolStripMenuItem.Image = global::Favo.Properties.Resources.SyncArrowRed_16x;
            }
            else if (ifMode == false)
            {
                ifModeToolStripMenuItem.Image = global::Favo.Properties.Resources.SyncArrow_16x;
            }
        }

        // Event Handler for help ToolStripMenuItem, opens new Window
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HelpMenu = new HelpMenu();
            HelpMenu.Show();
        }

        // Event Handler for the close button in the top right corner
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Main functionality in CheckSavedStatus method
            CheckSavedStatus("exit");
        }

        // Form1 has no FormBorderStyle, this makes up for the missing dragability. Resize could be added.
        #region MovableWindow

        //Panels can be used to move the Window
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }

        #endregion 

        // Event Handler for the "TextBox" item, if it's changed
        void TextEditorBoxTextChanged(object sender, EventArgs e)
        {
            UpdateCodelines();



            // scroll codelinesTextBox to the position of textEditorBox
            ScrollTo(GetScrollPos(textEditorBox.Handle, 1) + 1);

            saved = false;
            compiled = false;
        }

        // Update Scrollbar pos
        private void TextEditorBox_VScroll(object sender, EventArgs e)
        {
            ScrollTo(GetScrollPos(textEditorBox.Handle, 1));
        }

        // Changes focus to textEditorBox when Codelines somehow enters focus
        private void Codelines_Enter(object sender, EventArgs e)
        {
            textEditorBox.Focus();
        }

        //manages input/output prompt
        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (waitingForInput)
                {
                    waitingForInput = false;

                    InputString = inputTextBox.Text;
                    inputTextBox.ReadOnly = false;
                    inputTextBox.Enabled = true;
                    textEditorBox.Focus();
                    inputTextBox.Text = "No input required";
                    if (StepByStep)
                    {
                        try
                        {
                            Highlight();
                            RegisterMachine.ReturnType T = rM.ExecuteRegisterMachine(ref InputString);
                            if (T == RegisterMachine.ReturnType.OUTPUT)
                            {
                                errorBox.Text = InputString;
                            }
                            if (T == RegisterMachine.ReturnType.INPUT)
                            {
                                UpdateLabels();
                                UpdateDataGridView();
                                waitingForInput = true;
                                inputTextBox.Text = "Waiting for Input";
                                return;
                            }
                            if (T == RegisterMachine.ReturnType.END)
                            {
                                UpdateLabels();
                                UpdateDataGridView();
                                errorBox.Text = "Program execution finished!";

                                rM.ResetState();
                                return;
                            }
                        }
                        catch (Exception exc)
                        {
                            errorBox.Text = exc.Message;
                        }
                    }
                    else
                    {
                        try
                        {
                            RegisterMachine.ReturnType T = rM.ExecuteRegisterMachine(ref InputString);
                            if (T == RegisterMachine.ReturnType.OUTPUT)
                            {
                                errorBox.Text = InputString;
                            }
                            if (T == RegisterMachine.ReturnType.INPUT)
                            {
                                UpdateLabels();
                                UpdateDataGridView();
                                waitingForInput = true;
                                inputTextBox.Text = "Waiting for Input";
                                return;
                            }
                            while (T != RegisterMachine.ReturnType.END)
                            {
                                T = rM.ExecuteRegisterMachine(ref OutputString);
                                if (T == RegisterMachine.ReturnType.OUTPUT)
                                {
                                    errorBox.Text = OutputString;
                                }
                                if (T == RegisterMachine.ReturnType.INPUT)
                                {
                                    waitingForInput = true;
                                    inputTextBox.Text = "Waiting for Input";
                                    UpdateLabels();
                                    UpdateDataGridView();
                                    return;
                                }
                                if (T == RegisterMachine.ReturnType.END)
                                {
                                    UpdateLabels();
                                    UpdateDataGridView();
                                    errorBox.Text = "Program execution finished!";

                                    rM.ResetState();
                                    return;
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            errorBox.Text = exception.Message;
                        }

                        UpdateLabels();
                        UpdateDataGridView();

                        rM.ResetState();
                    }

                }
            }

        }

        private void InputTextBox_Enter(object sender, EventArgs e)
        {
            if (waitingForInput)
            {
                inputTextBox.Text = "";
            }
            else inputTextBox.Text = "No input required"; ;
        }

        private void InputTextBox_Leave(object sender, EventArgs e)
        {
            if (waitingForInput)
            {
                inputTextBox.Text = "Waiting for Input";
            }
            else
            {
                inputTextBox.ReadOnly = true;
                inputTextBox.Enabled = false;
                inputTextBox.Text = "No input required";
            }
        }

        void PictureBox1Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ToolTipText = displayText[index];
            index++;
            if (index >= qAnzahl) index = 0;
        }
        
        #endregion

        #region ScrollSync

        // Imported windows functions for controlling scrollbars of control elements
        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hWnd, int nbar, int nPos, bool bRedraw);

        [DllImport("user32.dll", EntryPoint = "PostMessageA")]
        static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern int GetScrollPos(IntPtr hWnd, int nBar);

        public void ScrollTo(int pos)
        {
            SetScrollPos(codelines.Handle, 0x1, pos, false);
            PostMessage(codelines.Handle, 0x0115, 4 + 0x10000 * pos, 0);
        }

        public void ScrollTo(IntPtr control, int pos)
        {
            SetScrollPos(control, 0x1, pos, false);
            PostMessage(control, 0x0115, 4 + 0x10000 * pos, 0);
        }

        #endregion


        /// <summary>
        /// Checks for changes, calls for execution afterwards
        /// <paramref name="task"/>Defines which task to execute afterwards.</param>
        /// </summary>
        void CheckSavedStatus(string task)
        {
            //Check if latest changes are saved, show MessageBox.
            if (!saved)
            {
                DialogResult dialogResult = MessageBox.Show("Änderungen am Code speichern?", "Ungespeicherte Änderungen",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                //Save changes
                if (dialogResult == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(null, null);
                    ToolbarExecution(task);
                }
                //Abort changes
                else if (dialogResult == DialogResult.No)
                    ToolbarExecution(task);

            }
            //else
               ToolbarExecution(task);
        }

        /// <summary>
        /// Executes the tasks
        /// </summary>
        /// <param name="task">Defines which task to execute.</param>
        void ToolbarExecution(string task)
        {
            //What's the task?
            //New File
            if (task == "new")
            {
                openPath = null;
                textEditorBox.Text = "";
                saved = true;
            }
            //Open File
            else if (task == "open")
            {
                // Get file path from LoadFileDialog, read file from path and set TextEditorBox.Text to Filetext
                string s = Dialog.LoadFileDialog();
                openPath = s;

                if (s != null)
                {
                    textEditorBox.Text = String.Join(System.Environment.NewLine, FileHandler.GetFileContent(s));
                    saved = true;
                }
            }
            //Close Application
            else if (task == "exit")
                Application.Exit();
        }


        /// <summary>
        /// Update indicator for current line for step by step
        /// </summary>
        private void Highlight()
        {
            UpdateCodelines();

            //Insert arrow after linenumber, add instructionPointer length to insertion position because arrow should be inserted after the digits
            codelines.Text = codelines.Text.Insert(codelines.Text.IndexOf((rM.InstructionPointer).ToString()) + rM.InstructionPointer.ToString().Length, " <--"); //Text selection highlighting too complex and prone to bugs
        }

        #region Updates

        /// <summary>
        /// Update Variable Labels
        /// </summary>
        private void UpdateLabels()
        {
            labelaccumulator.Text = rM.Accumulator.ToString();
            labeloperations.Text = rM.InstructionCounter.ToString();
        }


        // compare textEditorBox number of lines with codelines number of lines
        // add or remove linenumbers from codelinesTextBox if necessary
        private void UpdateCodelines()
        {
            if (textEditorBox.Lines.Length >= codelines.Lines.Length)
            {
                codelines.Text = "";
                codelines.Text += 1;
                for (int i = 2; i <= textEditorBox.Lines.Length; i++)
                    codelines.Text += Environment.NewLine + i;
            }

            else if (textEditorBox.Lines.Length < codelines.Lines.Length)
            {
                codelines.Text = "";
                codelines.Text += 1;
                for (int i = 2; i <= textEditorBox.Lines.Length; i++)
                    codelines.Text += Environment.NewLine + i;

                int previousPosition = GetScrollPos(textEditorBox.Handle, 1);
                ScrollTo(textEditorBox.Handle, GetScrollPos(codelines.Handle, 1));
                ScrollTo(textEditorBox.Handle, previousPosition);
            }
        }

        /// <summary>
        /// Updates DataGridView2 to show values of registers
        /// </summary>
        private void UpdateDataGridView()
        {
            dt.Clear();

            for (int i = 0; i < rM.Heap.Length; i++)
            {
                dt.Rows.Add(i.ToString(), rM.Heap[i]);
            }
        }
        #endregion
    }
}
