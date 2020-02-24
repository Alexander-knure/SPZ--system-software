using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Xml.Serialization;
using System.IO;

namespace StudentList
{
    public partial class MainForm : Form
    {
        private enum SortMode
        {
            Surname,
            Subject,
            Achievement
        }
        private SortMode _sortMode;
        private StudentList _list;
        public int _studentCounter;

        public MainForm()
        {
            InitializeComponent();
            _list = new StudentList();
            _sortMode = SortMode.Surname;
            var columns = new List<string>() { "ID", "Name", "Surname", "Subject Name", "Subject Mark" };
            AddColumns(ref columns);
        }

        private void AddColumns(ref List<string> columns)
        {
            _mainListView.View = View.Details;
            foreach ( var item in columns )
            {
                _mainListView.Columns.Add(item, -2, HorizontalAlignment.Left);
            }
        }

        private void StudentIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _sortMode = SortMode.Surname;
        }

        private void _subjectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _sortMode = SortMode.Subject;
        }

        private void SubjectNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _sortMode = SortMode.Achievement;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var dialogBox = new DialogBox();

            dialogBox.SetHeader("Add Student");
            dialogBox.SetRange(250, 200);

            dialogBox.AddInput("Input Name:", 30, 20);
            dialogBox.AddInput("Input Surname:", 30, 80);
            dialogBox.AddButton("OK", 30, 140);

            dialogBox.ShowDialog();

            try
            {
                _studentCounter = _list.GetCount();
                _studentCounter++;

                _list.AddStudent(
                  new Student(
                      dialogBox._textBoxes[0].Text,
                      dialogBox._textBoxes[1].Text,
                      _studentCounter
                  )
              );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                --_studentCounter;
            }
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            var dialogBox = new DialogBox();

            dialogBox.SetHeader("Remove Student");
            dialogBox.SetRange(250, 200);

            dialogBox.AddInput("Input ID:", 30, 20);
            dialogBox.AddButton("OK", 30, 80);

            dialogBox.ShowDialog();

            try
            {
                _list.RemoveStudent( int.Parse(dialogBox._textBoxes[0].Text) );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            var dialogBox = new DialogBox();

            dialogBox.SetHeader("Add Student");
            dialogBox.SetRange(250, 250);

            dialogBox.AddInput("Input Student ID:", 30, 20);
            dialogBox.AddInput("Input Subject Name:", 30, 80);
            dialogBox.AddInput("Input Mark:", 30, 140);
            dialogBox.AddButton("OK", 30, 200);

            dialogBox.ShowDialog();

            try
            {
                _list.AddSubject(
                    int.Parse(dialogBox._textBoxes[0].Text),
                    new Subject(
                        dialogBox._textBoxes[1].Text,
                        int.Parse(dialogBox._textBoxes[2].Text)
                  )
              );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveSubjectButton_Click(object sender, EventArgs e)
        {
            var dialogBox = new DialogBox();

            dialogBox.SetHeader("Remove subject");
            dialogBox.SetRange(250, 200);

            dialogBox.AddInput("Input ID:", 20, 20);
            dialogBox.AddInput("Input subject:", 20, 80);
            dialogBox.AddButton("OK", 20, 140);

            dialogBox.ShowDialog();

            try
            {
                _list.RemoveSubject(int.Parse(dialogBox._textBoxes[0].Text), dialogBox._textBoxes[1].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateListButton_Click(object sender, EventArgs e)
        {
            _mainListView.Items.Clear();

            var students = _list.GetStudents();
            var rows = new List<Row>();

            foreach( var student in students )
            {
                var subjects = student.GetSubjects();
                if ( subjects.Count > 0 )
                {
                    foreach (var Subject in subjects)
                    {
                        var row = new Row();
                        row.Name = student._name;
                        row.Surname = student._surname;
                        row.ID = student._id.ToString();
                        row.Subject = Subject._name;
                        row.Mark = Subject._mark.ToString();
                        rows.Add(row);
                    }
                }
                else
                {
                    var row = new Row();
                    row.Name = student._name;
                    row.Surname = student._surname;
                    row.ID = student._id.ToString();
                    rows.Add(row);
                }
            }

            SortList( ref rows );
            ShowList( ref rows );
        }

        private void MainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListView)
            {
                var dialogBox = new DialogBox();

                dialogBox.SetHeader("Change Value");
                dialogBox.SetRange(250, 220);

                dialogBox.AddLabel("Choose:", 30, 20);
                dialogBox.AddRadioButton("Name", 30, 50);
                dialogBox.AddRadioButton("Surname", 30, 80);
                dialogBox.AddInput("Input:", 30, 110);
                dialogBox.AddButton("OK", 30, 170);

                dialogBox.ShowDialog();

                var listView = (ListView)sender;
                
                var ID = int.Parse( listView.SelectedItems[0].Text );
                var student = _list.GetStudent(ID);

                for (int i = 0; i < dialogBox._radioButtons.Count; ++i )
                {
                    if (dialogBox._radioButtons[i].Checked)
                    {
                        switch (i)
                        {
                            case 0:
                                student._name = dialogBox._textBoxes.Last().Text;
                                break;

                            case 1:
                                student._surname = dialogBox._textBoxes.Last().Text;
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void SortList(ref List<Row> rows)
        {
            switch (_sortMode)
            {
                case SortMode.Surname:
                    rows = rows.OrderBy( obj => obj.Surname).ToList();
                    break;


                case SortMode.Subject:
                    rows = rows.OrderBy(obj => obj.Subject).ToList();
                    break;

                case SortMode.Achievement:
                    rows = rows.OrderBy(obj => obj.Surname).ThenByDescending(obj => obj.Mark).ToList();
                    break;

                default:
                    break;
            }
        }

        private void ShowList(ref List<Row> rows)
        {
            foreach(var item in rows)
            {
                var viewItem = new ListViewItem(item.ID);

                viewItem.SubItems.Add(item.Name);
                viewItem.SubItems.Add(item.Surname);
                viewItem.SubItems.Add(item.Subject);
                viewItem.SubItems.Add(item.Mark);

                _mainListView.Items.Add(viewItem);
            }
        }

        private class Row
        {
            public Row()
            {
                Name = "";
                Surname = "";
                ID = "";
                Subject = "";
                Mark = "";
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public string ID { get; set; }
            public string Subject { get; set; }
            public string Mark { get; set; }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void _editStudentButton_Click(object sender, EventArgs e)
        {
            var dialogBox = new DialogBox();

            dialogBox.SetHeader("Change student");
            dialogBox.SetRange(250, 220);

            dialogBox.AddInput("Choose id:", 20, 20);
            dialogBox.AddRadioButton("Name", 20, 80);
            dialogBox.AddRadioButton("Surname", 120, 80);
            dialogBox.AddInput("Input:", 20, 110);
            dialogBox.AddButton("OK", 20, 170);

            dialogBox.ShowDialog();
            
            try
            {
                var ID = int.Parse(dialogBox._textBoxes[0].Text);
                var student = _list.GetStudent(ID);
                var changeData = dialogBox._textBoxes[1].Text;

                for (int i = 0; i < dialogBox._radioButtons.Count; ++i)
                {
                    if (dialogBox._radioButtons[i].Checked)
                    {
                        switch (i)
                        {
                            case 0:
                                student._name = changeData;
                                break;

                            case 1:
                                student._surname = changeData;
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _editSubjectButton_Click(object sender, EventArgs e)
        {
           var dialogBox = new DialogBox();
          
           dialogBox.SetHeader("Change subject");
           dialogBox.SetRange(250, 220);

           dialogBox.AddInput("Choose id:", 20, 10);
           dialogBox.AddInput("Choose subject:", 20, 70);
           dialogBox.AddInput("Change:", 20, 130);
           dialogBox.AddButton("OK", 20, 190);
          
           dialogBox.ShowDialog();

            try
            {
                var ID = int.Parse(dialogBox._textBoxes[0].Text);
                var subjectName = dialogBox._textBoxes[1].Text;
                var changeData = dialogBox._textBoxes[2].Text;

                var student = _list.GetStudent(ID);
                student.SetSubject(subjectName, changeData);
                student._subjects[subjectName]._name = changeData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Binary files|*.bin";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                switch (dialog.FilterIndex)
                {
                    case 1:
                        var bin = new BinaryFormatter();
                        using (var file = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                        {
                            bin.Serialize(file, _list);
                        }
                        break;
                }
            }
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Binary files|*.bin";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (dialog.FilterIndex)
                {
                    case 1:
                        var bin = new BinaryFormatter();
                        using (var file = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            _list.Clear();
                            _list = (StudentList)bin.Deserialize(file);
                        }
                        break;
                }
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {

        }
    }
}
