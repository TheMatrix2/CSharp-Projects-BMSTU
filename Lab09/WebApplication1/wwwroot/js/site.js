let selectCityObject = document.getElementById("select-city-object");
const WeatherInformationContentObj = document.getElementById("weather-information-content");
cities = getAllCities();

async function getAllCities() {
    let response = await fetch("http://localhost:8080/get-cities");
    cities = await response.json();

    for (var item of cities) {
        var optionObj = document.createElement("option");
        optionObj.innerHTML = item.name;
        selectCityObject.appendChild(optionObj);
    }
    return cities;
}

async function loadCurrentWeather() {
    if (cities.length === 0) {
        console.error("No cities available.");
        return;
    }
    
    let city = cities[selectCityObject.selectedIndex];

    var response = await fetch(
        `http://localhost:8080/get-weather?latitude=${city.latitude}&longitude=${city.longitude}`
    );

    response = await response.json();

    WeatherInformationContentObj.innerHTML =
        `
            <p>Country: ${response.country}</p>
            <p>Name: ${response.name}</p>
            <p>Temperature: ${response.temp}</p>
            <p>Description: ${response.description}</p>
        `;
}
