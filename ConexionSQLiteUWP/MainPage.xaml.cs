using Connection;
using Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ConexionSQLiteUWP
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        SQLiteConnection connection;
        private SQLiteConnections _sqlite = new SQLiteConnections();
        public MainPage()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sales_system");
            connection = new SQLiteConnection(path);
        }
        private void Conectar(object sender, RoutedEventArgs e)
        {

        }
        private void Desconectar(object sender, RoutedEventArgs e)
        {

        }
        private void Insertar(object sender, RoutedEventArgs e)
        {
            AddStock(connection,TxtName.Text, TxtUrl.Text);
        }
        public static void AddStock(SQLiteConnection db, string name, string url)
        {
            var product = new TExample()
            {
                Name = name,
                URL = url
            };
            db.Insert(product);
            Console.WriteLine("{0} == {1}", product.ID, product.Name);
        }
    }
}
