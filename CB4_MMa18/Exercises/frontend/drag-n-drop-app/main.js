function main() {
    const items = document.querySelectorAll("[draggable=true]");
    for (let i = 0; i < items.length; i++) {
        items[i].addEventListener("dragstart", function(e) {
            console.log(e);
            e.dataTransfer.setData('text', e.currentTarget.id);
            e.currentTarget.style.color = "#ef3434";
            e.effectAllowed = "move";
        });
        items[i].addEventListener("dragend", function(e) {
            console.log(e);
            e.target.style.color = "#000000";
            e.dataTransfer.clearData();
        });
    }
    const lists = document.querySelectorAll("ul");
    for (let i = 0; i < lists.length; i++) {
        lists[i].addEventListener("drop", function(e) {
            console.log(e);
            e.preventDefault();
            const id = e.dataTransfer.getData('text');
            const item = document.getElementById(id);
            item.parentElement.removeChild(item);
            e.currentTarget.appendChild(item);
        });
        lists[i].addEventListener("dragover", function(e) {
            e.preventDefault();
        });
    }
}

window.addEventListener("load", main);