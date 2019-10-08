using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLitePCL;
using PCLExt.FileStorage.Folders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProvectoLogia
{
    public partial class App : Application
    {

        //conexao com o banco de dados
        public SQLite.SQLiteConnection conexao { get; private set; }
        
        public App()
        {
            //Local do banco

            var pasta = new LocalRootFolder();

            //crio o arquivo do banco
            //se ele existir, abro ele

            var arquivo = pasta.CreateFile("BancoProvectoLogia.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);

            //faço a "Conexão"

            conexao = new SQLite.SQLiteConnection(arquivo.Path);

            //criar tabela, se ela não existir

            conexao.Execute("CREATE TABLE IF NOT EXISTS Usuarios (id INTEGER PRIMARY KEY AUTOINCREMENT, NomeDeUsuario TEXT, SenhaDeUsuario TEXT)");

            conexao.Execute("CREATE TABLE IF NOT EXISTS DataHora (id INTEGER PRIMARY KEY AUTOINCREMENT, Horarios TEXT, Opcao TEXT)");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
