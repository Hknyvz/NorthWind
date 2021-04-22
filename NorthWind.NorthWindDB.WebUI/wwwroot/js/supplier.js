let responseData = [];

let editingData = {};

$(document).ready(() => {
    get();
});

function createTable(response) {
    let trElement = "";
    let array = [...response];
    array.map(item => {
        trElement += `<tr id="${item.id}">
                    <td>${item.companyName}</td>
                    <td>${item.contactName}</td>
                    <td>${item.contactTitle}</td>
                     <td>
                        ${item.address.street} ${item.address.city} ${item.address.country} ${item.address.region === "Null" ? item.address.region : " "}
                    </td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord('${item.id}')"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord('${item.id}')">Delete</button>
                    </td>
                  </tr>`
    })
    console.log(trElement);
    document.getElementById("tbody").innerHTML = trElement;
}

function get() {
    fetch(`http://localhost:61643/api/supplier`)
        .then(res => res.json())
        .then(res => {
            createTable(res);
            responseData = [...res];
            response = res;
        }).catch(err => console.log(err));
    
}

function addRecord() {
    openSendData("add");
}

function editRecord(id) {
    editingData = responseData.filter(p => p.id == id)[0];
    openSendData("edit");
    $("#company-name").val(editingData.companyName);
    $("#contact-name").val(editingData.contactName);
    $("#contact-title").val(editingData.contactTitle);

    $("#phone").val(editingData.address.phone);
    $("#street").val(editingData.address.street);
    $("#region").val(editingData.address.region);
    $("#city").val(editingData.address.city);
    $("#country").val(editingData.address.country);
    $("#postal-code").val(editingData.address.postalCode);
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

function edit() {
    let companyName = $("#company-name").val();
    let contactName = $("#contact-name").val();
    let contactTitle = $("#contact-title").val();

    let phone = $("#phone").val();
    let street = $("#street").val();
    let region = $("#region").val();
    let city = $("#city").val();
    let country = $("#country").val();
    let postalCode = $("#postal-code").val();
    fetch(`http://localhost:61643/api/supplier`, {
        method: "put",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            id: editingData.id,
            companyName: companyName,
            contactName: contactName,
            contactTitle: contactTitle,
            "address": {
                "phone": phone,
                "street": street,
                "region": region,
                "city": city,
                "country": country,
                "postalCode": postalCode,
            }
        }),

    }).then(res => {
        if (res.ok) {
            $("#sendData").hide();
            getData();
        }
    }).catch(err => {
        $("#errorName").html("Can't record");
        console.log(err);
    });

}

function add() {

    let companyName = $("#company-name").val();
    let contactName = $("#contact-name").val();
    let contactTitle = $("#contact-title").val();

    let phone = $("#phone").val();
    let street = $("#street").val();
    let region = $("#region").val();
    let city = $("#city").val();
    let country = $("#country").val();
    let postalCode = $("#postal-code").val();
    fetch(`http://localhost:61643/api/supplier`, {
        method: "post",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            companyName: companyName,
            contactName: contactName,
            contactTitle: contactTitle,
            "address": {
                "phone": phone,
                "street": street,
                "region": region,
                "city": city,
                "country": country,
                "postalCode": postalCode,
            },
        }),

    }).then(res => {
        if (res.ok) {
            $("#sendData").hide();
            getData();
        }
    }).catch(err => {
        $("#errorName").html("Can't record");
        console.log(err);
    });
    
}

function exit() {
    $("#sendData").hide();

    $("#company-name").val("");
    $("#contact-name").val("");
    $("#contact-title").val("");

    $("#phone").val("");
    $("#street").val("");
    $("#region").val("");
    $("#city").val("");
    $("#country").val("");
    $("#postal-code").val("");

    $("#add-btn").show();
    $("#edit-btn").show();
}

function deleteRecord(id) {
    fetch(`http://localhost:61643/api/supplier/?id=${id}`, {
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