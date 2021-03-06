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
                    <td>${item.phone}</td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord(${item.id})"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord(${item.id})">Delete</button>
                    </td>
                  </tr>`
    })
    document.getElementById("tbody").innerHTML = trElement;
}

function get() {
    fetch(`http://localhost:61643/api/shipper`)
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
    $("#phone").val(editingData.phone);

}

function deleteRecord(id) {
    fetch(`http://localhost:61643/api/shipper/?id=${id}`, {
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
    fetch(`http://localhost:61643/api/shipper`, {
        method: "put",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({ id: editingData.id, companyName: companyName, phone: phone }),

    }).then(res => {
        debugger
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
    let companyName = $("#company-name").val();
    let phone = $("#phone").val();
    fetch(`http://localhost:61643/api/shipper`, {
        method: "post",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({ companyName: companyName, phone: phone }),

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
    $("#company-name").val("");
    $("#phone").val("");
    $("#add-btn").show();
    $("#edit-btn").show();
}