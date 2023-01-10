function SelectSubItem() {
    var sehirlerDropdown = document.getElementsByClassName("sehirlerDropdown")[0];
    
    var selectedItemValue = sehirlerDropdown.options[sehirlerDropdown.selectedIndex].value;
    var seferSelect = document.getElementById("seferId");
    
 
    while (seferSelect.children[0]) {
        seferSelect.children[0].remove();
    }

    for (var i = 0; i < 5; i++) {
        var option = document.createElement("option");
        option.innerHTML = "asdasd";
        seferSelect.appendChild(option);
    }
    
    console.log(selectedItemValue);

    
}