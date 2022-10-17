
function textShow(id) {
    let test = document.getElementById("pic-" + id);
    test.classList.remove("hidden");
    test.classList.remove("anim");
    console.log(1);
}

function textClose(id) {
    let test = document.getElementById("pic-" + id);
    test.classList.add("hidden");
    test.classList.add("anim");
    console.log(2);
}

function categoryShow(id) {
    let test = document.getElementById("category-" + id);
    test.classList.remove("hidden");
    test.classList.add("anim");
    console.log(3);
}

function categoryClose(id) {
    let test = document.getElementById("category-" + id);
    test.classList.add("hidden");
    console.log(4);
}

function sizeChoose(id) {
    let s = document.getElementById("size-s");
    let m = document.getElementById("size-m");
    let l = document.getElementById("size-l");

    s.classList.remove("active");
    m.classList.remove("active");
    l.classList.remove("active");

    switch (id) {
        case 0:
            s.classList.add("active");
            break;
        case 1:
            m.classList.add("active");
            break;
        case 2:
            l.classList.add("active");
            break;
    }
}

let submitBtn = document.getElementById("submit");
let itemInputName = document.querySelector(".itemInputName");
let itemInputDesc = document.querySelector(".itemInputDesc");

submitBtn.addEventListener("click", function (e) {
    if (itemInputName.value == "" || itemInputDesc.value == ""){
        e.preventDefault();
        alert("Заполните все поля перед отправкой");
    }
    
});
