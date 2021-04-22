

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
                    <td>${item.name}</td>
                    <td>${item.description}</td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord(${item.id})"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord(${item.id})">Delete</button>
                    </td>
                  </tr>`
    })
    document.getElementById("tbody").innerHTML = trElement;
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

function get() {
    fetch(`http://localhost:61643/api/category`)
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
    $("#name").val(editingData.name);
    $("#description").val(editingData.description);

}

function deleteRecord(id) {
    fetch(`http://localhost:61643/api/category/?id=${id}`, {
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

function edit() {
    let name = $("#name").val();
    let description = $("#description").val();
    fetch(`http://localhost:61643/api/category`, {
        method: "put",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({ id: editingData.id, description: description, name: name }),

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
    let name = $("#name").val();
    let description = $("#description").val();
    fetch(`http://localhost:61643/api/category`, {
        method: "Post",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({ description: description, name: name }),

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

function exit() {
    $("#sendData").hide();
    $("#name").val("");
    $("#description").val("");
    $("#add-btn").show();
    $("#edit-btn").show();
}