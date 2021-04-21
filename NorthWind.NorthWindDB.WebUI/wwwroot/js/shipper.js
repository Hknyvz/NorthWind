let responseData = [];

let editingData = {};

$(document).ready(() => {
    getData();
});

function createTable(response) {
    let trElement = "";
    let array = [...response];
    array.map(item => {

        trElement += `<tr id="${item.id}">
                    <td>${item.companyName}</td>
                    <td>${item.phone}</td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord(${item.id})"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord(${item.id})">Delete</button>
                    </td>
                  </tr>`
    })
    document.getElementById("tbody").innerHTML = trElement;
}

function getData() {
    $.ajax({
        url: `http://localhost:61643/api/shipper`,
        method: "get",
        dataType: "json",
        success: (result) => {
            createTable(result);
            responseData = [...result];
        }
    });
}

function addRecord() {
    openSendData("add");
}

function editRecord(id) {
    editingData = responseData.filter(p => p.id == id)[0];
    openSendData("edit");
    $("#company-name").val(editingData.companyName);
    $("#phone").val(editingData.phone);

}

function deleteRecord(id) {
    console.log(id);
    $.ajax({
        url: `http://localhost:61643/api/shipper/?id=${id}`,

        method: "delete",
        success: (res) => {
            $(`#${id}`).remove();
        }
    })
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
    let companyName = $("#company-nama").val();
    let phone = $("#phone").val();

    $.ajax({
        url: `http://localhost:61643/api/shipper`,
        method: "put",
        data: { id: editingData.id, companyName: companyName, phone: phone },
        success: (res) => {
            $("#sendData").hide();
            getData();
        },

        error: (err) => {
            $("#errorName").html("Can't edit");
            console.log(err.statusCode());
        },
        dataType: "json"
    })

}

function add() {
    let companyName = $("#company-name").val();
    let phone = $("#phone").val();

    $.ajax({
        url: `http://localhost:61643/api/shipper`,
        method: "post",
        data: { companyName: companyName, phone: phone },
        success: (res) => {
            $("#sendData").hide();
            getData();
        },

        error: (err) => {
            $("#errorName").html("Can't record");
            console.log(err.statusCode());
        },
        dataType: "json"
    })

}

function exit() {
    $("#sendData").hide();
    $("#company-name").val("");
    $("#phone").val("");
    $("#add-btn").show();
    $("#edit-btn").show();
}