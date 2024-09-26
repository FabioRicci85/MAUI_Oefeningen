namespace LeetTranslatorApp
{
    public partial class MainPage : ContentPage
    {

        LeetTranslator leetTranslator = new LeetTranslator();

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTranslate_Clicked(object sender, EventArgs e)
        {
            LblResult.Text = leetTranslator.ToLeet(EntryText.Text, mySlider.Value);
        }

       
    }

}
