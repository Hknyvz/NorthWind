let responseData = [];

let editingData = {};

$(document).ready(() => {
    get();
});

function createTable(response) {
    let trElement = "";
    let array = [...response];
    array.map(item => {
        console.log(item);
        trElement += `<tr id="${item.id}">
                    <td>${item.name}</td>
                    <td>${item.supplierID}</td>
                    <td>${item.categoryID}</td>
                    <td>${item.quantityPerUnit}</td>
                    <td>${item.unitPrice}</td>
                    <td>${item.unitsInStock}</td>
                    <td>${item.unitsOnOrder}</td>
                    <td>${item.reorderLevel}</td>
                    <td>${item.discontinued}</td>
                    <td>
                     <button id="${item.id}-edit" class="btn btn-success btn-sm w-100" onclick="editRecord(${item.id})"><a href="#sendData" class="link">Edit</a></button>
                     <button id="${item.id}-delete" class="btn btn-danger btn-sm w-100" onclick="deleteRecord(${item.id})">Delete</button>
                    </td>
                  </tr>`
    })
    document.getElementById("tbody").innerHTML = trElement;
}

function get() {
    fetch(`http://localhost:61643/api/product`)
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
    $("#supplier-id").val(editingData.supplierID);
    $("#category-id").val(editingData.categoryID);
    $("#quantity-per-unit").val(editingData.quantityPerUnit);
    $("#unit-price").val(editingData.unitPrice);
    $("#unit-in-stock").val(editingData.unitsInStock);
    $("#units-on-order").val(editingData.unitsOnOrder);
    $("#reorder-level").val(editingData.reorderLevel);
    $("#discontinued").val(editingData.discontinued);
}

function deleteRecord(id) {
    fetch(`http://localhost:61643/api/product/?id=${id}`, {
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
    let name = $("#name").val();
    let supplierID = $("#supplier-id").val();
    let categoryID = $("#category-id").val();
    let quantityPerUnit = $("#quantity-per-unit").val();
    let unitPrice = $("#unit-price").val();
    let unitsInStock = $("#unit-in-stock").val();
    let unitsOnOrder = $("#units-on-order").val();
    let reorderLevel = $("#reorder-level").val();
    let discontinued = $("#discontinued").val();
    fetch(`http://localhost:61643/api/product`, {
        method: "put",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            supplierID: supplierID,
            name: name,
            categoryID: categoryID,
            quantityPerUnit: quantityPerUnit,
            unitsInStock: unitsInStock,
            unitPrice: unitPrice,
            reorderLevel: reorderLevel,
            unitsOnOrder: unitsOnOrder,
            discontinued: discontinued
        }),

    }).then(res => {
        if (res.ok) {
            $("#sendData").hide();
            get();
        }
    }).catch(err => {
        console.log(err);
    });
}

function add() {
    let name = $("#name").val();
    let supplierID = $("#supplier-id").val();
    let categoryID = $("#category-id").val();
    let quantityPerUnit = $("#quantity-per-unit").val();
    let unitPrice = $("#unit-price").val();
    let unitsInStock = $("#unit-in-stock").val();
    let unitsOnOrder = $("#units-on-order").val();
    let reorderLevel = $("#reorder-level").val();
    let discontinued = $("#discontinued").val();
    
    debugger;
    fetch(`http://localhost:61643/api/product`, {
        method: "post",
        headers: {
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            supplierID: supplierID,
            name: name,
            categoryID: categoryID,
            quantityPerUnit: quantityPerUnit,
            unitsInStock: unitsInStock,
            unitPrice: unitPrice,
            reorderLevel: reorderLevel,
            unitsOnOrder: unitsOnOrder,
            discontinued: discontinued,
            //supplier: null,
            //category:null
        }),

    }).then(res => {
        if (res.ok) {
            $("#sendData").hide();
            get();
        }
    }).catch(err => {
        console.log(err);
    });
}

function exit() {
    $("#sendData").hide();
    $("#name").val("");
    $("#supplier-id").val("");
    $("#category-id").val("");
    $("#quantity-per-unit").val("");
    $("#unit-price").val("");
    $("#unit-in-stock").val("");
    $("#reorder-level").val("");
    $("#discontinued").val("");
    $("#units-on-order").val("");
    $("#add-btn").show();
    $("#edit-btn").show();
}