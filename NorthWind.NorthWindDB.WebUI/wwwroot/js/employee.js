let responseData = [];

let editingData = {};

$(document).ready(() => {
    get();
});

function createTable(response) {

    let trElement = "";
    let array = [...response];
    array.map(item => {
        let birthDate = item.birthDate;
        let hireDate = item.hireDate;
        if (item.birthDate != null && item.hireDate != null) {
            birthDate = birthDate.substring(0, 10);
            hireDate = hireDate.substring(0, 10);
        }
        let territoryIdText = "";
        let territoryIds = [...item.territoryIds];
        for (var i = 0; i < territoryIds.length; i++) {
            territoryIdText += `${territoryIds[i]}-`;
        }
        territoryIdText = territoryIdText.substring(0, territoryIdText.length - 1);
        let fullAddress = "";
        debugger;
        if (item.address != null) {
            fullAddress = `${item.address.street} ${item.address.city} ${item.address.country} ${item.address.region === "Null" ? item.address.region : " "}`
        }
        trElement += `<tr id="${item.id}">
                    <td>${item.firstName}</td>
                    <td>${item.lastName}</td>
                    <td>${item.title}</td>
                    <td>${item.titleOfCourtesy}</td>
                    <td>${birthDate}</td>
                    <td>${hireDate}</td>
                     <td>
                        ${fullAddress}
                    </td>
                    <td>${item.notes}</td>
                    <td>${item.reportsTo != "NULL" ? item.reportsTo : ""}</td>
                    <td>${territoryIdText}</td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord('${item.id}')"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord('${item.id}')">Delete</button>
                    </td>
                  </tr>`
    })
    document.getElementById("tbody").innerHTML = trElement;
}

function get() {

    fetch(`http://localhost:61643/api/employee`)
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
    $("#first-name").val(editingData.firstName);
    $("#last-name").val(editingData.lastName);
    $("#title").val(editingData.title);
    $("#title-of-courtesy").val(editingData.titleOfCourtesy);

    $("#birth-date").val(editingData.birthDate);
    $("#hire-date").val(editingData.hireDate);

    $("#phone").val(editingData.address.phone);
    $("#street").val(editingData.address.street);
    $("#region").val(editingData.address.region);
    $("#city").val(editingData.address.city);
    $("#country").val(editingData.address.country);
    $("#postal-code").val(editingData.address.postalCode);

    $("#reports-to").val(editingData.reportsTo);
    $("#territory-ids").val(editingData.territoryIds);
    $("#notes").val(editingData.notes);
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
    let firstName = $("#first-name").val();
    let lastName = $("#last-name").val();
    let title = $("#title").val();
    let titleOfCourtesy = $("#title-of-courtesy").val();

    let birthDate = $("#birth-date").val();
    let hireDate = $("#hire-date").val();

    let phone = $("#phone").val();
    let street = $("#street").val();
    let region = $("#region").val();
    let city = $("#city").val();
    let country = $("#country").val();
    let postalCode = $("#postal-code").val();

    let reportsTo = $("#reports-to").val();
    let territoryIds = $("#territory-ids").val();
    let notes = $("#notes").val();

    let territoryIdArray = territoryIds.split(",");
    fetch(`http://localhost:61643/api/employee`, {
        method: "put",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            "id": editingData.id,
            "firstName": firstName,
            "lastName": lastName,
            "title": title,
            "titleOfCourtesy": titleOfCourtesy,
            "birthDate": birthDate,
            "hireDate": hireDate,
            "address": {
                "phone": phone,
                "street": street,
                "region": region,
                "city": city,
                "country": country,
                "postalCode": postalCode,
            },
            "reportsTo": reportsTo,
            "territoryIds": territoryIdArray,
            "notes": notes
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

    let firstName = $("#first-name").val();
    let lastName = $("#last-name").val();
    let title = $("#title").val();
    let titleOfCourtesy = $("#title-of-courtesy").val();

    let birthDate = $("#birth-date").val();
    let hireDate = $("#hire-date").val();

    let phone = $("#phone").val();
    let street = $("#street").val();
    let region = $("#region").val();
    let city = $("#city").val();
    let country = $("#country").val();
    let postalCode = $("#postal-code").val();

    let reportsTo = $("#reports-to").val();
    let territoryIds = $("#territory-ids").val();
    let notes = $("#notes").val();

    let territoryIdArray = territoryIds.split(",");
    console.log(territoryIdArray);
    fetch(`http://localhost:61643/api/employee`, {
        method: "post",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            "firstName": firstName,
            "lastName": lastName,
            "title": title,
            "titleOfCourtesy": titleOfCourtesy,
            "birthDate": birthDate,
            "hireDate": hireDate,
            "address": {
                "phone": phone,
                "street": street,
                "region": region,
                "city": city,
                "country": country,
                "postalCode": postalCode,
            },
            "reportsTo": reportsTo,
            "territoryIds": territoryIdArray,
            "notes": notes
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

    $("#first-name").val("");
    $("#last-name").val("");
    $("#title").val("");
    $("#title-of-courtesy").val("");

    $("#birth-date").val("");
    $("#hire-date").val("");

    $("#phone").val("");
    $("#street").val("");
    $("#region").val("");
    $("#city").val("");
    $("#country").val("");
    $("#postal-code").val("");

    $("#reports-to").val("");
    $("#territory-ids").val("");
    $("#notes").val("");

    $("#add-btn").show();
    $("#edit-btn").show();
}

function deleteRecord(id) {
    console.log(id);
    fetch(`http://localhost:61643/api/employee/?id=${id}`, {
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