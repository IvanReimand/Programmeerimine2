
using KooliProjekt.WinFormsApp.Api;

namespace KooliProjekt.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OrderGrid.SelectionChanged += OrderGrid_SelectionChanged;

            NewButton.Click += NewButton_Click;
            SaveButton.Click += SaveButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
           throw new NotImplementedException();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TodoListsGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (OrderGrid.SelectedRows.Count == 0)
            {
                return;
            }

            var order = (Order)OrderGrid.SelectedRows[0].DataBoundItem;

            if(order == null)
            {
                IdField.Text = string.Empty;
                TitleField.Text = string.Empty;
            }
            else
            {
                IdField.Text = order.Id.ToString();
                TitleField.Text = order.Title;
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var apiClient = new ApiClient();
            var response = await apiClient.List();

            OrderGrid.AutoGenerateColumns = true;
            OrderGrid.DataSource = response.Value;
            
        }
    }
}
