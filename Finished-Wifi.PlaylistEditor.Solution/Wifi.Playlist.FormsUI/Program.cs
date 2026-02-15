using Autofac;
using System;
using System.Windows.Forms;
using Wifi.Playlist.CoreTypes;
using Wifi.Playlist.Factories;
using Wifi.Playlist.WeatherExtension;

namespace Wifi.Playlist.FormsUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //builder erzeugen
            var builder = new ContainerBuilder();

            //typen registrieren
            //builder.RegisterType<DummyEditor>().As<INewPlaylistDataProvider>();
            builder.RegisterType<NewPlaylistForm>().As<INewPlaylistDataProvider>();
            
            builder.RegisterType<PlaylistItemFactory>().As<IPlaylistItemFactory>();
            builder.RegisterType<RepositoryFactory>().As<IRepositoryFactory>();
            builder.RegisterType<PlaylistFactory>().As<IPlaylistFactory>();

            //builder.RegisterType<CurrentWeatherService>().As<ICurrentWeatherService>();
            builder.RegisterType<CurrentWeatherProxy>().As<ICurrentWeatherService>();

            builder.RegisterType<MainForm>();

            //container erzeugen
            var container = builder.Build();

            //Typen erzeugen lassen
            var mainForm = container.Resolve<MainForm>();
                        
            if(args.Length == 1)
            {
                mainForm.LoadPlaylist(args[0]);
            }            

            Application.Run(mainForm);
        }
    }
}
