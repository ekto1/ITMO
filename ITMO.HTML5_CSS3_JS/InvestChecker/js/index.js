let mainElement = document.querySelector("main");
let resultElement = document.querySelector("#results"); 

function checkPortfolio(name, age, riskProfile, stockPercentage, bondPercentage, cashPercentage) {
    console.log(name, age, riskProfile, stockPercentage, bondPercentage, cashPercentage);

    let portfolioResult;

    switch (riskProfile) {
        case "Консервативный":
            if (stockPercentage > 30) portfolioResult = "<p>" + name + ", " + "вам стоит увеличить долю облигаций в портфеле</p>";
            else portfolioResult = "<p>" + name + ", " + "ваш портфель идеально сбалансирован, поздравляем!</p>";
            break;
        case "Умеренный":
            if (stockPercentage > 50) portfolioResult = "<p>" + name + ", " + "вам стоит увеличить долю облигаций в портфеле</p>";
            else portfolioResult = "<p>" + name + ", " + "ваш портфель идеально сбалансирован, поздравляем!</p>";
            break;
        case "Агрессивный":
            if (stockPercentage > 80) portfolioResult = "<p>" + name + ", " + "вам стоит увеличить долю облигаций в портфеле</p>";
            else portfolioResult = "<p>" + name + ", " + "ваш портфель идеально сбалансирован, поздравляем!</p>";
            break;
    }
    
    resultElement.innerHTML = portfolioResult; 
}


window.onload = function() {
    // Проверка портфеля
    const button = document.querySelector("#portfolio-check-button");

    button.addEventListener("click", function() {
        event.preventDefault();

        const name = document.querySelector("#name-input").value;
        const age = document.querySelector("#age-input").value;
        const riskProfile = document.querySelector("#risk-input").value;
        const stockPercentage = document.querySelector("#stocks-input").value;
        const bondPercentage = document.querySelector("#bonds-input").value;
        const cashPercentage = document.querySelector("#cash-input").value;

        checkPortfolio(name, age, riskProfile, stockPercentage, bondPercentage, cashPercentage);
    });

    // Web-Storage
    let inputs = document.querySelectorAll("input");

    for (var i = 0; i < inputs.length; i++) {
        let id = inputs[i].id;
        let value = localStorage.getItem(id);
        if (value) {
            inputs[i].value = value;
        }
    }

    inputs.forEach(function(input) {
        input.addEventListener("input", function() {
            localStorage.setItem(input.id, input.value);
        });
      });
};

const conservativePortfolio = {
    labels: ["TGLD", "LQDT", "SBGB", "SBRB", "OBLG", "SBMX", "TMOS", "EQMX"],
    data: [10, 15, 15, 15, 15, 10, 12, 8],
    colors: ["yellow", "green", "green", "green", "green", "orange", "orange", "orange"]
};

const moderatePortfolio = {
    labels: ["TGLD", "LQDT", "SBGB", "SBRB", "OBLG", "SBMX", "TMOS", "EQMX"],
    data: [10, 10, 10, 10, 10, 15, 20, 15],
    colors: ["yellow", "green", "green", "green", "green", "orange", "orange", "orange"]
};

const aggressivePortfolio = {
    labels: ["TGLD", "LQDT", "SBGB", "SBRB", "OBLG", "SBMX", "TMOS", "EQMX"],
    data: [10, 5, 5, 5, 5, 25, 30, 20],
    colors: ["yellow", "green", "green", "green", "green", "orange", "orange", "orange"]
};

let myChart = null; 

document.getElementById("portfolio-constructor-form").addEventListener("submit", function(event) {
    event.preventDefault();
    let riskProfile = document.getElementById("risk-input").value;
    let portfolioData = null;

    switch (riskProfile) {
        case "Консервативный":
            portfolioData = conservativePortfolio;
            break;
        case "Умеренный":
            portfolioData = moderatePortfolio;
            break;
        case "Агрессивный":
            portfolioData = aggressivePortfolio;
            break;
        default:
            alert("Выберите риск-профиль");
            return;
    }

    if (myChart !== null) myChart.destroy(); 

    let ctx = document.getElementById("portfolio-chart").getContext("2d");
    myChart = new Chart(ctx, {
        type: "pie",
        data: {
            labels: portfolioData.labels,
            datasets: [{
                data: portfolioData.data,
                backgroundColor: portfolioData.colors
            }]
        }
    });

    let name = document.querySelector("name-input");
    document.querySelector("portfolio-conclusions").innerHTML("<p>" + name + ", мы рекомендуем вам составить портфель следующим образом:</p>");
});
