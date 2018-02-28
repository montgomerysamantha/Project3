using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project3
{
    public partial class uxUserInterface : Form
    {
        WeatherList _current; //when the user loads an input file, add to here
        Stack<WeatherList> wlists = new Stack<WeatherList>(); //our stack of WeatherLists
        public uxUserInterface()
        {
            InitializeComponent();
            uxUndoButton.Enabled = false;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxOpenFile.ShowDialog() == DialogResult.OK)
            {
                //read in the file and put it into the listbox
                WeatherList temp = new WeatherList();
                char[] delims = { ' ' };
                using (StreamReader sr = new StreamReader(uxOpenFile.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] pieces = (sr.ReadLine()).Split(delims, StringSplitOptions.RemoveEmptyEntries);
                        int year = Convert.ToInt32(pieces[2]);
                        int month = Convert.ToInt32(pieces[0]);
                        int day = Convert.ToInt32(pieces[1]);
                        double temperature = Convert.ToDouble(pieces[3]);
                        DateTime date = new DateTime(year, month, day);
                        WeatherData weather = new WeatherData(date, temperature);
                        temp.Add(weather);
                    }
                }

                _current = temp;
                uxWeatherListBox.DataSource = _current;

                DateTime d = new DateTime(1996, 5, 16);
                DateTime da = new DateTime(1997, 5, 16);
                //_current.FilterRange(d, da);
            }
        }

        private void FilterClick(object sender, EventArgs e)
        {
            if (uxDateRangeButton.Checked)
            {               
                _current.FilterRange(uxMonthCalendar.SelectionStart, uxMonthCalendar.SelectionEnd);
            }
            else if (uxBelowTempButton.Checked)
            {
                _current.FilterTemp(Convert.ToInt32(uxNumericUpDown.Value), true);
            }
            else if (uxAboveTempButton.Checked)
            {
                _current.FilterTemp(Convert.ToInt32(uxNumericUpDown.Value), false);
            }
            else if (uxDateHistory.Checked)
            {
                _current.FilterDateHistory(uxMonthCalendar.SelectionStart);
            }
            else
            {
                MessageBox.Show("Error: Please select a filter first!");
                return;
            }
            WeatherList copy = new WeatherList(_current);
            wlists.Push(copy); //pushing the copy onto the stack;
            uxWeatherListBox.DataSource = null;
            uxWeatherListBox.DataSource = _current;

            uxUndoButton.Enabled = true; //we can now undo changes, so make button avaliable
        }

        private void UndoClick(object sender, EventArgs e)
        {
            
            _current = wlists.Pop(); //_current is now the list that we just popped off
            uxWeatherListBox.DataSource = null;
            uxWeatherListBox.DataSource = _current; //updating ListBox
            if (wlists.Count == 0) //if we popped off the last list, disable the undo button
            {
                uxUndoButton.Enabled = false;
            }
        }
    }
}
