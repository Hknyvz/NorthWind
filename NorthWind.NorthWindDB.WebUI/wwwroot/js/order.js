let responseData = [];
let editingData = {};
let productList = [];

$(document).ready(() => {
    get();
});
function createTable(response) {
    let trElement = "";
    let array = [...response];
    console.log(array);
    array.map(item => {
        let orderDate = item.orderDate;
        let requiredDate = item.requiredDate;
        let shippedDate = item.shippedDate;
        orderDate = orderDate != null && orderDate.substring(0, 10);
        requiredDate = requiredDate != null && requiredDate.substring(0, 10);
        shippedDate = shippedDate != null && shippedDate.substring(0, 10);


        let fullAddress
        if (item.shipAddress != null) {
            fullAddress = `${item.shipAddress.street} ${item.shipAddress.city} ${item.shipAddress.country} ${item.shipAddress.region === "Null" ? item.shipAddress.region : " "}`
        }

        trElement += `<tr id="${item.id}">
                    <td>${item.customerId}</td>
                    <td>${item.employeeId}</td>
                    <td>${orderDate}</td>
                    <td>${requiredDate}</td>
                    <td>${shippedDate}</td>
                    <td>${item.shipVia}</td>
                    <td>${item.freight}</td>
                    <td>${item.shipName}</td>
                    <td>${fullAddress}</td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord('${item.id}')"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord(${item.id})">Delete</button>
                    </td>
                  </tr>`
    })

    document.getElementById("tbody").innerHTML = trElement;
}
function get() {
    let headers = new Headers();
    headers.append("ClientType", "Web");
    fetch(`http://localhost:61643/api/order`, {
        headers: headers,
        method: "Get",
        mode: "cors",
        
    })
        .then(res => res.json())
        .then(res => {
            createTable(res);
            responseData = [...res];
            response = res;
        }).catch(err => console.log(err));
}

function openSendData(type) {
    $("#sendData").removeAttr("hidden");
    $("#sendData").show();
    switch (type) {
        case "edit":
            $("#add-btn").hide();
            break;
        case "add":
            $("#edit-btn").hide();
            break;
        default:
    }
}

function addRecord() {
    openSendData("add");
}

function editRecord(id) {
    editingData = responseData.filter(p => p.id == id)[0];
    productList = [...editingData.details];
    openSendData("edit");

    $("#customer-id").val(editingData.customerId);
    $("#employee-id").val(editingData.employeeId);
    $("#order-date").val(editingData.orderDate);
    $("#required-date").val(editingData.requiredDate);
    $("#shipped-date").val(editingData.shippedDate);
    $("#ship-via").val(editingData.shipVia);
    $("#freight").val(editingData.freight);
    $("#ship-name").val(editingData.shipName);

    $("#street").val(editingData.shipAddress.street);
    $("#region").val(editingData.shipAddress.region);
    $("#city").val(editingData.shipAddress.city);
    $("#country").val(editingData.shipAddress.country);
    $("#postal-code").val(editingData.shipAddress.postalCode);

}

function deleteRecordProduct(id) {
    let index = productList.findIndex(p => p.id === id)
    productList.splice(index, 1);
    createProductTable(productList);
}

function edit() {
    let customerId = $("#customer-id").val();
    let employeeId = $("#employee-id").val();
    let orderDate = $("#order-date").val();
    let requiredDate = $("#required-date").val();
    let shippedDate = $("#shipped-date").val();
    let shipVia = $("#ship-via").val();
    let freight = $("#freight").val();
    let shipName = $("#ship-name").val();

    let street = $("#street").val();
    let region = $("#region").val();
    let city = $("#city").val();
    let country = $("#country").val();
    let postalCode = $("#postal-code").val();
    fetch(`http://localhost:61643/api/order`, {
        method: "put",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            "id": editingData.id,
            "customerId": customerId,
            "employeeId": employeeId,
            "orderDate": orderDate,
            "requiredDate": requiredDate,
            "shippedDate": shippedDate,
            "shipVia": shipVia,
            "freight": freight,
            "shipName": shipName,
            "address": {
                "street": street,
                "region": region,
                "city": city,
                "country": country,
                "postalCode": postalCode
            },
            "details": productList

        }),

    }).then(res => {
        if (res.ok) {
            $("#sendData").hide();
            get();
        }
    }).catch(err => {
        $("#errorName").html("Can't record");
        console.log(err);
    });
}

function add() {
    debugger;
    let customerId = $("#customer-id").val();
    let employeeId = $("#employee-id").val();
    let orderDate = $("#order-date").val();
    let requiredDate = $("#required-date").val();
    let shippedDate = $("#shipped-date").val();
    let shipVia = $("#ship-via").val();
    let freight = $("#freight").val();
    let shipName = $("#ship-name").val();

    let street = $("#street").val();
    let region = $("#region").val();
    let city = $("#city").val();
    let country = $("#country").val();
    let postalCode = $("#postal-code").val();
    fetch(`http://localhost:61643/api/order`, {
        method: "post",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            "customerId": customerId,
            "employeeId": employeeId,
            "orderDate": orderDate,
            "requiredDate": requiredDate,
            "shippedDate": shippedDate,
            "shipVia": shipVia,
            "freight": freight,
            "shipName": shipName,
            "shipAddress": {
                "street": street,
                "region": region,
                "city": city,
                "country": country,
                "postalCode": postalCode
            },
            //"details": productList

        }),

    }).then(res => {
        if (res.ok) {
            $("#sendData").hide();
            get();
        }
    }).catch(err => {
        $("#errorName").html("Can't record");
        console.log(err);
    });
}

function exit() {
    $("#sendData").hide();

    $("#customer-id").val("");
    $("#employee-id").val("");
    $("#order-date").val("");
    $("#require-date").val("");
    $("#shipped-date").val("");
    $("#ship-via").val("");
    $("#freight").val("");
    $("#ship-name").val("");

    $("#street").val("");
    $("#region").val("");
    $("#city").val("");
    $("#country").val("");
    $("#postal-code").val("");

    $("#add-btn").show();
    $("#edit-btn").show();
}

function deleteRecord(id) {
    console.log();
    fetch(`http://localhost:61643/api/order/?id=${id}`, {
        method: "delete",
        headers: {
            "Content-Type": 'application/json',
        },

    }).then(res => {
        if (res.ok) {
            $(`#${id}`).remove();
        }
    }).catch(err => {
        console.log(err);
    });
}
