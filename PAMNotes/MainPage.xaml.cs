namespace PAMNotes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Notes.txt");

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                NoteEditor.Text = File.ReadAllText(filePath);
            }
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            string text = NoteEditor.Text;

            File.WriteAllText(filePath,
                text);
            DisplayAlert("Arquivo salvo");

        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                DisplayAlert("Alerta", "Arquivo foi deletado");

            }
            else
            {
                DisplayAlert("Alerta", "Arquivo não encontrado", "Ok");
            }
        }

    }
}
