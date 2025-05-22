using TeaShop.Presenters;
using TeaShop.Views;

namespace TeaApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Вместо ApplicationConfiguration.Initialize()
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Показываем форму регистрации
            using (var registrationForm = new RegistrationForm())
            {
                if (registrationForm.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Для входа в магазин необходимо зарегистрироваться!",
                        "Вход отменен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Создаем презентер с данными пользователя
                var presenter = new TeaShopPresenter(registrationForm.RegisteredCustomer);

                // Создаем главную форму, передавая только презентер
                var mainForm = new MainForm(presenter);
                presenter.SetView(mainForm); // Связываем презентер с формой
                Application.Run(mainForm);
            }
        }
    }
}