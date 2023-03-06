// Menu function
function menu_responsive() {
     var x = document.getElementById("menu_principal");
     if (x.className === "menu") {
          x.className += " responsive"
     } else {
          x.className = "menu";
     }
}