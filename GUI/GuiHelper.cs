namespace GUI
{
    internal class GuiHelper
    {
        public int StartingSortedColumnIndex { get; set; }
        private bool sortingDirection;

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        /// <summary>
        /// Recursive method that unlocks all textboxes inside the Control specified in the parameters.
        /// Use the boolean 'unlock' to set the lock or unlock state.
        /// </summary>
        public static void UnlockProfileForEditing(Control control, bool unlock)
        {
            if (control is TextBox)
            {
                control.Enabled = unlock;
                control.TabStop = unlock;
                if (unlock)
                {
                    control.BackColor = SystemColors.Window;
                }
                else
                {
                    control.BackColor = SystemColors.ControlLight;
                }
            }
            if (control.HasChildren)
            {
                // Recursively call this method for all controls inside the control passed in the parameter.
                // Ex. all controls inside another group box.
                foreach (Control childControl in control.Controls)
                {
                    UnlockProfileForEditing(childControl, unlock);
                }
            }
        }

        /// <summary>
        /// Async Task that turns on the visibility of the label provided in the parameters,
        /// shows the given message in the given color, for the given time. /Dennis Kempf
        /// </summary>
        public async Task FeedBackMessage(Label label, string message, Color? color = null, int milliseconds = 5000)
        {
            label.Text = message;
            label.ForeColor = color ?? Color.Black;
            label.Visible = true;
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();

            await Task.Delay(milliseconds, _cancellationTokenSource.Token);
            label.Text = string.Empty;
            label.ForeColor = Color.Black;
            label.Visible = false;
        }

        /// <summary>
        /// Meant to be placed inside a DataGridViewColumnHeader Click Event. Takes in the DataGridView, its mouse events
        /// and the list meant to be the datasource for the DataGridView. Keeps track of sorting direction. If your lists are sorted
        /// by a specific column from the beginning, set the GUIHelpers StartingSortedColumnIndex property.
        /// </summary>
        public void ReorderDataGridViewColumnHeaderClickEvent<T>(DataGridView dataGridView, DataGridViewCellMouseEventArgs click, List<T> dataSourceList)
        {
            string columnPropertyName = dataGridView.Columns[click.ColumnIndex].DataPropertyName;
            if (click.ColumnIndex == StartingSortedColumnIndex) { sortingDirection ^= true; }
            dataGridView.DataSource = SortData(dataSourceList, columnPropertyName, sortingDirection);
            StartingSortedColumnIndex = click.ColumnIndex;
        }

        /// <summary>
        /// Allows sorting for the DataGridViews according to a boolean that switches when the columns get clicked. /Dennis Kempf
        /// </summary>
        private List<T> SortData<T>(List<T> list, string column, bool ascending)
        {
            if (list is null) { return list; }
            return ascending ?
                list.OrderBy(_ => _.GetType().GetProperty(column)?.GetValue(_)).ToList() :
                list.OrderByDescending(_ => _.GetType().GetProperty(column)?.GetValue(_)).ToList();
        }

        /// <summary>
        /// Auto-sizes the datagridview columns to look nice after the data binding complete event. /Dennis Kempf
        /// </summary>
        public static void DataGridViewDataBindingCompleteResize(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView && dataGridView.ColumnCount != 0)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                foreach (DataGridViewColumn Column in dataGridView.Columns)
                {
                    Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                dataGridView.ClearSelection();
            }
        }
    }
}