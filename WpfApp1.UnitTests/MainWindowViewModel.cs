namespace WpfApp1.UnitTests
{
    internal class MainWindowViewModel
    {
        public MainWindowViewModel(object @object)
        {
        }

        public object NewCommand { get; internal set; }
        public object SelectedItem { get; internal set; }
        public object SaveCommand { get; internal set; }
        public object DeleteCommand { get; internal set; }
    }
}