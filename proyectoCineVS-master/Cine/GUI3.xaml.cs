using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Cine
{
    public partial class GUI3 : Window
    {
        public GUI3()
        {
            InitializeComponent();
            // Configuración inicial
            DatePickerFecha.SelectedDate = DateTime.Now; // Fecha actual por defecto
            CargarPeliculas(); // Cargar todas las películas al iniciar
        }

        private void CargarPeliculas()
        {
            // Simulación de datos: Lista de películas
            List<Pelicula> peliculas = new List<Pelicula>
            {
                new Pelicula { Titulo = "Pelicula 1", Genero = "Acción", Idioma = "Español", Horario = "14:00" },
                new Pelicula { Titulo = "Pelicula 2", Genero = "Comedia", Idioma = "Inglés", Horario = "16:00" },
                new Pelicula { Titulo = "Pelicula 3", Genero = "Drama", Idioma = "Francés", Horario = "18:00" }
            };

            DataGridPeliculas.ItemsSource = peliculas; // Mostrar datos en la tabla
        }

        private void ButtonConsultar_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para consultar películas del día seleccionado
            DateTime? fechaSeleccionada = DatePickerFecha.SelectedDate;

            if (fechaSeleccionada == null)
            {
                MessageBox.Show("Por favor, selecciona una fecha.");
                return;
            }

            MessageBox.Show($"Mostrando películas para el día: {fechaSeleccionada.Value.ToShortDateString()}");
            // Aquí puedes actualizar la lista según la fecha seleccionada
        }

        private void ButtonAplicarFiltros_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para aplicar filtros
            string generoSeleccionado = ((ComboBoxItem)ComboBoxGenero.SelectedItem)?.Content.ToString();
            string idiomaSeleccionado = ((ComboBoxItem)ComboBoxIdioma.SelectedItem)?.Content.ToString();

            MessageBox.Show($"Aplicando filtros: Género: {generoSeleccionado}, Idioma: {idiomaSeleccionado}");
            // Aquí puedes filtrar las películas según los criterios seleccionados
        }

        private void ButtonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            // Restaurar filtros a valores predeterminados
            ComboBoxGenero.SelectedIndex = 0; // "Todos"
            ComboBoxIdioma.SelectedIndex = 0; // "Todos"
            DatePickerFecha.SelectedDate = DateTime.Now;

            CargarPeliculas(); // Volver a cargar todas las películas
        }
    }

    // Clase para representar películas (puedes moverla a otro archivo)
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }
        public string Horario { get; set; }
    }
    private void ButtonAbrirGUI4_Click(object sender, RoutedEventArgs e)
    {
        // Obtener los criterios seleccionados
        string generoSeleccionado = ((ComboBoxItem)ComboBoxGenero.SelectedItem)?.Content.ToString();
        string idiomaSeleccionado = ((ComboBoxItem)ComboBoxIdioma.SelectedItem)?.Content.ToString();
        DateTime? fechaSeleccionada = DatePickerFecha.SelectedDate;

        // Filtrar las películas con los criterios seleccionados
        List<Pelicula> peliculasFiltradas = FiltrarPeliculas(generoSeleccionado, idiomaSeleccionado, fechaSeleccionada);

        if (peliculasFiltradas.Count > 0)
        {
            // Abre GUI4 pasando las películas filtradas
            GUI4 ventanaGUI4 = new GUI4(peliculasFiltradas);
            ventanaGUI4.ShowDialog(); // ShowDialog para que sea modal
        }
        else
        {
            MessageBox.Show("No hay películas que coincidan con los filtros seleccionados.", "Sin Resultados");
        }
    }

    // Método para filtrar películas
    private List<Pelicula> FiltrarPeliculas(string genero, string idioma, DateTime? fecha)
    {
        // Simulación de lista de películas (puedes usar tus datos reales)
        List<Pelicula> todasLasPeliculas = new List<Pelicula>
    {
        new Pelicula { Titulo = "Pelicula 1", Genero = "Acción", Idioma = "Español", Horario = "14:00" },
        new Pelicula { Titulo = "Pelicula 2", Genero = "Comedia", Idioma = "Inglés", Horario = "16:00" },
        new Pelicula { Titulo = "Pelicula 3", Genero = "Drama", Idioma = "Francés", Horario = "18:00" }
    };

        // Filtrado según los criterios seleccionados
        var peliculasFiltradas = todasLasPeliculas.FindAll(p =>
            (genero == "Todos" || p.Genero == genero) &&
            (idioma == "Todos" || p.Idioma == idioma) &&
            (!fecha.HasValue || p.Horario.Contains(fecha.Value.ToShortDateString()))
        );

        return peliculasFiltradas;
    }


}

