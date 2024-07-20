namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        public static readonly BindableProperty ConditionAProperty = BindableProperty.Create(nameof(ConditionA), typeof(bool), typeof(MainPage));
        public bool ConditionA
        {
            get => (bool)GetValue(ConditionAProperty);
            private set => SetValue(ConditionAProperty, value);
        }

        public static readonly BindableProperty ConditionBProperty = BindableProperty.Create(nameof(ConditionB), typeof(bool), typeof(MainPage));
        public bool ConditionB
        {
            get => (bool)GetValue(ConditionBProperty);
            private set => SetValue(ConditionBProperty, value);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
