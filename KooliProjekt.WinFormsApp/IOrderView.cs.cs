using KooliProjekt.WinFormsApp.Api;

namespace KooliProjekt.WinFormsApp
{
    public interface ITodoView
    {
        IList<Order> Order { get; set; }
        Order SelectedItem { get; set; }
        string Title { get; set; }
        int Id { get; set; }
        OrderPresenter Presenter { get; set; }
    }
}
