var feretro, silleteria, cafeteria, coronas, disposicion = 0;
var misa = 150000, despedida = 400000;


//Enums
const ServiceLevel = {
    BRONCE: 'Bronce',
    PLATA: 'Plata',
    ORO: 'Oro'
}


//Assign cost of Service
function AssignValues(Service) {
    switch (Service) {

        case ServiceLevel.BRONCE:
            feretro = 1500000;
            silleteria = 250000;
            cafeteria = 50000;
            coronas = 150000;
            break;

        case ServiceLevel.PLATA:
            feretro = 2500000;
            silleteria = 350000;
            cafeteria = 100000;
            coronas = 300000;
            break;

        case ServiceLevel.ORO:
            feretro = 4000000;
            silleteria = 650000;
            cafeteria = 2500000;
            coronas = 4500000;
    }


}


//Determine the final cost without discount

/**
 * @return {number}
 */
function CheckOut(id) {

    if (id !== null && id !== 0) {
        var finalPrice = feretro + silleteria + cafeteria + coronas + misa + despedida;
        disposicion = 0;

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

        return finalPrice += disposicion;
    }

    return 0;

}

