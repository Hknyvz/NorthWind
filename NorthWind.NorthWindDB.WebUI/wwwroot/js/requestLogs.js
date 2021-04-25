let responseData = [];

$(document).ready(() => {
    get();
});

function createTable(response) {
    let trElement = "";
    let array = [...response];
    console.log(array);
    array.map(item => {

        trElement += `<tr id="${item.id}">
                    <td>${item.path}</td>
                    <td>${item.subQuery}</td>
                    <td>${item.method}</td>
                    <td>${item.body}</td>
                    <td>${item.createDate}</td>
                    
                  </tr>`
    })
    document.getElementById("tbody").innerHTML = trElement;
}

function get() {
    fetch(`http://localhost:61643/api/requestlog/`)
        .then(res => res.json())
        .then(res => {
            createTable(res);
            responseData = [...res];
            response = res;
        }).catch(err => console.log(err));
}