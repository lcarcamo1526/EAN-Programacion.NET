function CheckCost(price, tax) {
    price = parseFloat((document.getElementById(price).value));
    tax = parseFloat(document.getElementById(tax).value);
    tax /= 100;
    price += price * tax;
    document.getElementById('price').innerText = "Precio final : " + price;

}


function CheckStringInput(text) {
    text = document.getElementById(text).value;
    document.getElementById('text-length').innerText = "Longitud del texto: " + text.length;
    document.getElementById('text-inverse').innerText = "Texto invertido: " + text.split("").reverse().join("");
    document.getElementById('text-upper').innerText = "Texto en mayuscula: " + text.toUpperCase();

}


function SecondOrderEcuation(a, b, c) {
    a = document.getElementById(a).value;
    b = document.getElementById(b).value;
    c = document.getElementById(c).value;
    root1 = parseFloat((-b + Math.sqrt(b ** 2 - 4 * a * c)) / 2 * a);
    root2 = parseFloat((-b - Math.sqrt(b ** 2 - 4 * a * c)) / 2 * a);
    document.getElementById("root1").innerText = "Por la derecha " + root1.toFixed(2);
    document.getElementById("root2").innerText = "Por la izquierda " + root2.toFixed(2);


}


function lastExercise(a, b) {
    a = parseInt(document.getElementById(a).value);
    b = parseInt(document.getElementById(b).value);
    for (let i = a + 1; i < b; i++) alert(i);

    let c = 0;
    do {
        c = c + a;
        a += 1;
    } while (a < b);

    document.getElementById('sumatoria').innerText = "Sumatoria  entre los valores = " + c;

}
