

var API_KEY = "359aef2f88e92c15bfe1418da9361186";

var cityInput    = document.getElementById("cityInput");
var searchBtn    = document.getElementById("searchBtn");
var weatherCard  = document.getElementById("weatherCard");
var errorBox     = document.getElementById("errorBox");
var loadingBox   = document.getElementById("loadingBox");
var lastSearched = document.getElementById("lastSearched");
var lastCitySpan = document.getElementById("lastCity");
var reloadBtn    = document.getElementById("reloadBtn");

function getWeatherIcon(weather) {
  if (weather == "Clear")        return "☀️";
  if (weather == "Clouds")       return "☁️";
  if (weather == "Rain")         return "🌧️";
  if (weather == "Drizzle")      return "🌦️";
  if (weather == "Thunderstorm") return "⛈️";
  if (weather == "Snow")         return "❄️";
  if (weather == "Mist")         return "🌫️";
  if (weather == "Fog")          return "🌫️";
  return "🌤️";
}


async function getWeather(city) {

  if (city == "") {
    cityInput.focus();
    return;
  }
  weatherCard.classList.add("hidden");
  errorBox.classList.add("hidden");
  loadingBox.classList.remove("hidden");

  var url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=" + API_KEY + "&units=metric";

  try {
    var response = await fetch(url);

    if (response.ok == false) {
      loadingBox.classList.add("hidden");
      errorBox.classList.remove("hidden");
      return;
    }

    var data = await response.json();

    document.getElementById("cityName").textContent   = data.name + ", " + data.sys.country;
    document.getElementById("condition").textContent  = data.weather[0].description;
    document.getElementById("weatherIcon").textContent = getWeatherIcon(data.weather[0].main);
    document.getElementById("tempValue").textContent  = Math.round(data.main.temp);
    document.getElementById("humidity").textContent   = data.main.humidity + "%";
    document.getElementById("wind").textContent       = data.wind.speed + " m/s";
    document.getElementById("feelsLike").textContent  = Math.round(data.main.feels_like) + "°C";

    localStorage.setItem("lastCity", data.name);
    lastCitySpan.textContent = data.name;
    lastSearched.classList.remove("hidden");

    loadingBox.classList.add("hidden");
    weatherCard.classList.remove("hidden");

  } catch (error) {
    loadingBox.classList.add("hidden");
    errorBox.classList.remove("hidden");
  }

}


searchBtn.addEventListener("click", function() {
  getWeather(cityInput.value);
});

cityInput.addEventListener("keyup", function(event) {
  if (event.key == "Enter") {
    getWeather(cityInput.value);
  }
});

reloadBtn.addEventListener("click", function() {
  var lastCity = localStorage.getItem("lastCity");
  cityInput.value = lastCity;
  getWeather(lastCity);
});

var savedCity = localStorage.getItem("lastCity");
if (savedCity) {
  lastCitySpan.textContent = savedCity;
  lastSearched.classList.remove("hidden");
}
