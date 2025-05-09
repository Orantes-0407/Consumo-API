using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiExplorerNew;

public partial class Form1 : Form
{
    private readonly HttpClient _httpClient;
    private string? _lastPokemonData;
    private string? _lastWeatherData;

    public Form1()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "ApiExplorer App");
    }

    private async Task SearchPokemon(string pokemonName)
    {
        try
        {
            // Mostrar indicador de carga
            lblStatusPokemon.Text = "Buscando...";
            Application.DoEvents();

            // Limpiar la información anterior
            lblPokemonInfo.Text = string.Empty;
            picPokemon.Image = null;

            // Convertir el nombre a minúsculas para la API
            pokemonName = pokemonName.ToLower().Trim();

            // Realizar la petición a la API
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{pokemonName}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                _lastPokemonData = content;

                // Parsear la respuesta JSON
                var pokemon = JObject.Parse(content);

                // Obtener datos básicos
                var id = pokemon["id"]?.Value<int>() ?? 0;
                var name = pokemon["name"]?.Value<string>() ?? "Desconocido";
                var height = (pokemon["height"]?.Value<int>() ?? 0) / 10.0; // Convertir a metros
                var weight = (pokemon["weight"]?.Value<int>() ?? 0) / 10.0; // Convertir a kg
                var imageUrl = pokemon["sprites"]?["front_default"]?.Value<string>();

                // Construir información
                var info = $"ID: {id}\r\nNombre: {char.ToUpper(name[0]) + name.Substring(1)}\r\n" +
                           $"Altura: {height} m\r\nPeso: {weight} kg\r\n\r\nEstadísticas:";

                // Añadir estadísticas
                var stats = pokemon["stats"];
                if (stats != null)
                {
                    foreach (var stat in stats)
                    {
                        var statName = stat["stat"]?["name"]?.Value<string>() ?? "Desconocido";
                        var statValue = stat["base_stat"]?.Value<int>() ?? 0;
                        if (!string.IsNullOrEmpty(statName))
                        {
                            info += $"\r\n- {char.ToUpper(statName[0]) + statName.Substring(1)}: {statValue}";
                        }
                    }
                }

                // Añadir tipos
                info += "\r\n\r\nTipos:";
                var types = pokemon["types"];
                if (types != null)
                {
                    foreach (var type in types)
                    {
                        var typeName = type["type"]?["name"]?.Value<string>() ?? "Desconocido";
                        if (!string.IsNullOrEmpty(typeName))
                        {
                            info += $"\r\n- {char.ToUpper(typeName[0]) + typeName.Substring(1)}";
                        }
                    }
                }

                // Mostrar información
                lblPokemonInfo.Text = info;

                // Cargar imagen
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    using var imageResponse = await _httpClient.GetAsync(imageUrl);
                    if (imageResponse.IsSuccessStatusCode)
                    {
                        using var stream = await imageResponse.Content.ReadAsStreamAsync();
                        picPokemon.Image = Image.FromStream(stream);
                    }
                }

                lblStatusPokemon.Text = "Pokémon encontrado";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                lblStatusPokemon.Text = "Pokémon no encontrado";
                MessageBox.Show($"No se encontró ningún Pokémon con el nombre \"{pokemonName}\"", 
                    "Pokémon no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatusPokemon.Text = "Error al buscar";
                MessageBox.Show($"Error al buscar el Pokémon: {response.StatusCode}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            lblStatusPokemon.Text = "Error";
            MessageBox.Show($"Error al buscar el Pokémon: {ex.Message}", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task SearchWeather(string city)
    {
        try
        {
            // Mostrar indicador de carga
            lblStatusWeather.Text = "Buscando...";
            Application.DoEvents();

            // Limpiar la información anterior
            lblWeatherInfo.Text = string.Empty;
            picWeather.Image = null;

            // API Key para OpenWeatherMap (normalmente esto debería estar en un archivo de configuración)
            var apiKey = "4331709ff3d1b3a62b7527e85e5de180"; // Esta es una API key de ejemplo, necesitarás una real

            // Realizar la petición a la API
            var response = await _httpClient.GetAsync(
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=es");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                _lastWeatherData = content;

                // Parsear la respuesta JSON
                var weather = JObject.Parse(content);

                // Obtener datos
                var cityName = weather["name"]?.Value<string>() ?? "Desconocido";
                var country = weather["sys"]?["country"]?.Value<string>() ?? "Desconocido";
                var temperature = weather["main"]?["temp"]?.Value<double>() ?? 0;
                var feelsLike = weather["main"]?["feels_like"]?.Value<double>() ?? 0;
                var humidity = weather["main"]?["humidity"]?.Value<int>() ?? 0;
                var windSpeed = weather["wind"]?["speed"]?.Value<double>() ?? 0;
                
                string? description = null;
                string? iconCode = null;
                
                if (weather["weather"] != null && weather["weather"]!.HasValues && weather["weather"]![0] != null)
                {
                    description = weather["weather"]![0]!["description"]?.Value<string>();
                    iconCode = weather["weather"]![0]!["icon"]?.Value<string>();
                }
                
                description ??= "Desconocido";

                // Construir información
                var info = $"Ciudad: {cityName}, {country}\r\n" +
                           $"Temperatura: {temperature:F1}°C\r\n" +
                           $"Sensación térmica: {feelsLike:F1}°C\r\n" +
                           $"Humedad: {humidity}%\r\n" +
                           $"Viento: {windSpeed} m/s\r\n";
                
                if (!string.IsNullOrEmpty(description))
                {
                    info += $"Descripción: {char.ToUpper(description[0]) + description.Substring(1)}";
                }

                // Mostrar información
                lblWeatherInfo.Text = info;

                // Cargar imagen del clima
                if (!string.IsNullOrEmpty(iconCode))
                {
                    var iconUrl = $"http://openweathermap.org/img/wn/{iconCode}@2x.png";
                    using var imageResponse = await _httpClient.GetAsync(iconUrl);
                    if (imageResponse.IsSuccessStatusCode)
                    {
                        using var stream = await imageResponse.Content.ReadAsStreamAsync();
                        picWeather.Image = Image.FromStream(stream);
                    }
                }

                lblStatusWeather.Text = "Clima encontrado";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                lblStatusWeather.Text = "Ciudad no encontrada";
                MessageBox.Show($"No se encontró ninguna ciudad con el nombre \"{city}\"", 
                    "Ciudad no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatusWeather.Text = "Error al buscar";
                MessageBox.Show($"Error al buscar el clima: {response.StatusCode}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            lblStatusWeather.Text = "Error";
            MessageBox.Show($"Error al buscar el clima: {ex.Message}", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveResultsToFile()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(_lastPokemonData) && string.IsNullOrWhiteSpace(_lastWeatherData))
            {
                MessageBox.Show("No hay datos para guardar. Realiza al menos una búsqueda primero.", 
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var saveDialog = new SaveFileDialog
            {
                Filter = "Archivo JSON (*.json)|*.json|Archivo de texto (*.txt)|*.txt",
                Title = "Guardar resultados",
                DefaultExt = "json"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveDialog.FileName;
                var isJson = Path.GetExtension(fileName).ToLower() == ".json";
                
                string content;
                if (isJson)
                {
                    // Crear un objeto combinado con ambos resultados
                    var results = new JObject();
                    
                    if (!string.IsNullOrWhiteSpace(_lastPokemonData))
                        results["pokemon"] = JObject.Parse(_lastPokemonData);
                    
                    if (!string.IsNullOrWhiteSpace(_lastWeatherData))
                        results["weather"] = JObject.Parse(_lastWeatherData);
                    
                    content = results.ToString(Formatting.Indented);
                }
                else
                {
                    // Formato texto plano
                    content = "RESULTADOS DE BÚSQUEDA\r\n\r\n";
                    
                    if (!string.IsNullOrWhiteSpace(_lastPokemonData))
                    {
                        content += "POKÉMON:\r\n" + _lastPokemonData + "\r\n\r\n";
                    }
                    
                    if (!string.IsNullOrWhiteSpace(_lastWeatherData))
                    {
                        content += "CLIMA:\r\n" + _lastWeatherData;
                    }
                }

                File.WriteAllText(fileName, content);
                MessageBox.Show($"Resultados guardados correctamente en {fileName}", 
                    "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar los resultados: {ex.Message}", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearAll()
    {
        // Limpiar campos de Pokémon
        txtPokemonSearch.Text = string.Empty;
        lblPokemonInfo.Text = string.Empty;
        picPokemon.Image = null;
        lblStatusPokemon.Text = string.Empty;

        // Limpiar campos del clima
        txtWeatherSearch.Text = string.Empty;
        lblWeatherInfo.Text = string.Empty;
        picWeather.Image = null;
        lblStatusWeather.Text = string.Empty;

        // Limpiar datos guardados
        _lastPokemonData = null;
        _lastWeatherData = null;
    }

    // Manejadores de eventos de los botones

    private async void btnSearchPokemon_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPokemonSearch.Text))
        {
            MessageBox.Show("Por favor, ingrese un nombre de Pokémon", 
                "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        await SearchPokemon(txtPokemonSearch.Text);
    }

    private async void btnSearchWeather_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtWeatherSearch.Text))
        {
            MessageBox.Show("Por favor, ingrese el nombre de una ciudad", 
                "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        await SearchWeather(txtWeatherSearch.Text);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveResultsToFile();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearAll();
    }
}
