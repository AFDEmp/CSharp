function main() {
    document.querySelector("#start-tripping").addEventListener("click", function() {
        Blink(document.body.children);
    });
}

function Blink(collection) {
    for (let i = 0; i < collection.length; i++) {
        setInterval(function() {
            collection[i].style.backgroundColor = getRandomColor();
            collection[i].style.color = getRandomColor();
        }, 100);
        Blink(collection[i].children);
    }
}

function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
      color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
  }

window.addEventListener("load", main);