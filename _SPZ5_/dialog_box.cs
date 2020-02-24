using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentList
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();

            _textBoxes = new List< TextBox >();
            _radioButtons = new List< RadioButton >();
        }

        public void SetHeader(string header)
        {
            Text = header;
        }

        public void SetRange(int width, int lenght)
        {
            ClientSize = new Size(width, lenght);
        }

        public void AddInput(string name, int x, int y)
        {
            var label = new Label() { Text = name, Left = x, Top = y, Width = 150 };

            var input = new TextBox() { Left = x, Top = y + 30, Width = 190 };
            
            Controls.Add(label);
            Controls.Add(input);

            _textBoxes.Add(input);
        }

        public void AddLabel(string name, int x, int y)
        {
            var label = new Label() { Text = name, Left = x, Top = y, Width = 150 };

            Controls.Add(label);
        }

        public void AddRadioButton(string name, int x, int y)
        {
            var radioButton = new RadioButton() { Text = name, Left = x, Top = y, Width = 100 };

            Controls.Add(radioButton);

            _radioButtons.Add(radioButton);
        }

        public void AddButton(string name, int x, int y)
        {
            var button = new Button() { Text = name, Left = x, Top = y, Width = 90 };
            button.Click += (sender, e) => { Close(); };

            Controls.Add(button);
        }

        public List<TextBox> _textBoxes { get; private set; }

        public List<RadioButton> _radioButtons { get; private set; }
    }
}
