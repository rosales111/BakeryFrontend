const cinnamonRollButton = document.getElementById("cinnamonRollButton");
const cakeButton = document.getElementById("cakeButton");
const coffeeButton = document.getElementById("coffeeButton");
const resultElement = document.getElementById("result");

function handleButtonClick(event) {
    const url = "/bakery/" + event.target.id;
    fetch(url)
        .then(response => response.text())
        .then(data => {
            resultElement.textContent = data;
        });
}

cinnamonRollButton.addEventListener("click", handleButtonClick);
cakeButton.addEventListener("click", handleButtonClick);
coffeeButton.addEventListener("click", handleButtonClick);