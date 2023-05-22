//Grilla de generos

document.addEventListener('DOMContentLoaded', ShowGenerosGrid())


function ShowGenerosGrid() {
    console.log("Enter ShowGenerosGrid")
    const grid = new Grid({
        columns: ['Id', 'Nombre'],
        server: {
            url: '/generos/list',
            then: data => data.results.map(gen =>
                [gen.id, gen.nombre]
            )
        },
        className: {
            table: 'table-body'
        },
        language: {
            'search': {
                'placeholder': '🔎 Search name, email...'
            },
            'pagination': {
                'previous': '⏮',
                'next': '⏭',
                'showing': '👀 Displaying',
                'results': () => 'Records'
            }
        }
    }).render(document.getElementById("generos"));
}


//new gridjs.Grid({
//    columns: ["Name", "Email", "Phone Number", "Gender"],
//    search: true,
//    sort: true,
//    height: '200px',
//    pagination: {
//        limit: 3
//    },
//    data: () => {
//        return new Promise(resolve => {
//            setTimeout(() =>
//                resolve([
//                    ["Dirk", "ah@com.com", "(646) 3432270", "Male"],
//                    ["Maryl", "dev@dailymail.co.uk", "(980) 3335235", "Female"],
//                    ["Stefan", "anupam@smh.com.au", "(180) 3532257", "Male"],
//                    ["Stephanie", "medium@outlook.com", "(904) 3434423", "male"],
//                    ["Emeline", "joomla@cyber.com", "(308) 2345432", "Female"],
//                    ["Gavra", "roman@Hal.com", "(383) 4909639", "Female"],
//                    ["Roxi", "business@insider.com", "(980) 3335235", "Male"],
//                    ["Jamey", "my@personal.com", "(773) 5233571", "Male"],
//                    ["Maye", "hey@howareyou.com", "(895) 9997017", "Female"]
//                ]), 2000);
//        });
//    },
//    className: {
//        table: 'table-body'
//    },
//    language: {
//        'search': {
//            'placeholder': '🔎 Search name, email...'
//        },
//        'pagination': {
//            'previous': '⏮',
//            'next': '⏭',
//            'showing': '👀 Displaying',
//            'results': () => 'Records'
//        }
//    }
//}).render(document.getElementById("generos"));
