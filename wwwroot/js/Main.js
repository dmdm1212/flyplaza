var element = document.getElementById('phone');
var maskOptions = {
    mask: '+7(000)000-00-00',
    lazy: false
}

var mask = new IMask(element, maskOptions);

var elmnt2 = document.getElementById('tablenumber');

for (let i = 1; i <= 10; i++) {
    document.getElementById('btn' + i).onclick = function () {
        elmnt2.setAttribute('value', i)
        display = document.getElementById('win1').style.display;
        if (display == "none") {
            document.getElementById('win1').style.display = "inline-block";
        }
    }
}

function openbox(win1) {
    alert('Сперва нужно войти в профиль!');
}

function closebutton() {
    document.getElementById('win1').style.display = "none";
}

dragElement(document.getElementById("win1"));

function dragElement(elmnt) {
    var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
    if (document.getElementById(elmnt.id + "header")) {
        // если присутствует, заголовок - это место, откуда вы перемещаете DIV:
        document.getElementById(elmnt.id + "header").onmousedown = dragMouseDown;
    } else {
        // в противном случае переместите DIV из любого места внутри DIV:
        elmnt.onmousedown = dragMouseDown;
    }

    function dragMouseDown(e) {
        e = e || window.event;
        e.preventDefault();
        // получить положение курсора мыши при запуске:
        pos3 = e.clientX;
        pos4 = e.clientY;
        document.onmouseup = closeDragElement;
        // вызов функции при каждом перемещении курсора:
        document.onmousemove = elementDrag;
    }

    function elementDrag(e) {
        e = e || window.event;
        e.preventDefault();
        // вычислить новую позицию курсора:
        pos1 = pos3 - e.clientX;
        pos2 = pos4 - e.clientY;
        pos3 = e.clientX;
        pos4 = e.clientY;
        // установите новое положение элемента:
        elmnt.style.top = (elmnt.offsetTop - pos2) + "px";
        elmnt.style.left = (elmnt.offsetLeft - pos1) + "px";
    }

    function closeDragElement() {
        // остановка перемещения при отпускании кнопки мыши:
        document.onmouseup = null;
        document.onmousemove = null;
    }
}

