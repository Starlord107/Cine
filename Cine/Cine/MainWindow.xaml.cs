using Cine.Usuario;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using GUICine2Vista.Peliculas;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Cine
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> listUsers { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            listUsers = new ObservableCollection<User>();
            listUsers.Add(new User("Paco", "Paco@gmail.com", "123",Role.User));
            listUsers.Add(new User("Jose", "Jose@gmail.com", "12", Role.User));
            listUsers.Add(new User("a", "a", "a", Role.Admin));


            

            // Crear la lista de películas
            Peliculas = new List<Pelicula>
        {
            new Pelicula()
            {
                Titulo = "La Aventura Espacial",
                Idioma = "Español",
                Genero = new List<string> { "Ciencia Ficción", "Aventura" },
                Duracion = 120,
                FechaInicio = new DateTime(2024, 10, 10),
                FechaFin = new DateTime(2024, 10, 20)
            },
            new Pelicula()
            {
                Titulo = "El Último Samurai",
                Idioma = "Inglés",
                Genero = new List<string> { "Acción", "Drama" },
                Duracion = 150,
                FechaInicio = new DateTime(2024, 10, 15),
                FechaFin = new DateTime(2024, 10, 30)
            },
            new Pelicula()
            {
                Titulo = "Cazadores de Sombras",
                Idioma = "Español",
                Genero = new List<string> { "Fantasía", "Aventura" },
                Duracion = 130,
                FechaInicio = new DateTime(2024, 10, 12),
                FechaFin = new DateTime(2024, 10, 28)
            },
            new Pelicula()
            {
                Titulo = "La Vida es Bella",
                Idioma = "Italiano",
                Genero = new List<string> { "Drama", "Comedia" },
                Duracion = 116,
                FechaInicio = new DateTime(2024, 10, 5),
                FechaFin = new DateTime(2024, 10, 15)
            },
            new Pelicula()
            {
                Titulo = "Inception",
                Idioma = "Inglés",
                Genero = new List<string> { "Ciencia Ficción", "Thriller" },
                Duracion = 148,
                FechaInicio = new DateTime(2024, 10, 20),
                FechaFin = new DateTime(2024, 11, 5)
            }
        };

            DataContext = this;
        

    }

        public User verifyUser(string name , string email , string password)
        {
            foreach(User user in listUsers)
            {
                if(user.user == name && user.email == email && user.password == password)
                {
                    return user;
                }
            }

            return null;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameUser = LoginUserTB.Text;
            string email = LoginEmailTB.Text;
            string pass = LoginPassTB.Text;

            User usuarioVerificado = verifyUser(nameUser, email, pass);

            if (usuarioVerificado!= null)
            {
                Role rolUsuario = usuarioVerificado.GetRole();
                TablasUser tablasuser = new TablasUser(Peliculas, rolUsuario);
                tablasuser.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
  
        }
 

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginPassTB_Copiar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginPassTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginPassTB_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
       


    }
}
