var feretro, silleteria, cafeteria, coronas, disposicion = 0, finalPrice = 0;
var misa = 150000, despedida = 400000;


//Enums

//Assign cost of Service
function AssignValues(id) {
    switch (id) {

        case 1:
            feretro = 1500000;
            silleteria = 250000;
            cafeteria = 50000;
            coronas = 150000;
            break;

        case 2:
            feretro = 2500000;
            silleteria = 350000;
            cafeteria = 100000;
            coronas = 300000;
            break;

        case 3:
            feretro = 4000000;
            silleteria = 650000;
            cafeteria = 2500000;
            coronas = 4500000;
    }

    console.log("Case " + id + "has been assigned");
}



//Determine the final cost without discount

/**
 * @return {number}
 */
function CheckOut(id) {
    finalPrice = disposicion =0;
    if (id !== null && id !== 0) {
        finalPrice = feretro + silleteria + cafeteria + coronas + misa + despedida;

        switch (id) {
            case 1:
                disposicion = 2000000;
                break;
            case 2:
                disposicion = 3000000
                break;
            case 3:
                disposicion = 4000000;
                break;
        }
        console.log("disposicion = " + disposicion);
        finalPrice += disposicion;
    }

    return 0;
}


function DrawTables() {
    AssignValues();
    document.getElementById('Misa').innerHTML = misa;
    document.getElementById('Feretro').innerHTML = feretro;
    document.getElementById('Silleteria').innerHTML = silleteria;
    document.getElementById('Cafeteria').innerHTML = cafeteria;
    document.getElementById('Coronas').innerHTML = coronas;
    document.getElementById('Despedida').innerHTML = despedida;
    document.getElementById('Disposicion').innerHTML = disposicion;
    document.getElementById('Subtotal').innerHTML = finalPrice;
    document.getElementById('Descuento').innerHTML = finalPrice *0.05;
    document.getElementById('Total').innerHTML = finalPrice *0.95;



}

