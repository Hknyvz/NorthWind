let responseData = [];

let editingData = {};

$(document).ready(() => {
    getData();
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

function getData() {
    $.ajax({
        url: `http://localhost:61643/api/product`,
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
    console.log(id);
    $.ajax({
        url: `http://localhost:61643/api/product/?id=${id}`,

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
    let name = $("#name").val();
    let supplierID = $("#supplier-id").val();
    let categoryID = $("#category-id").val();
    let quantityPerUnit = $("#quantity-per-unit").val();
    let unitPrice = $("#unit-price").val();
    let unitsInStock = $("#unit-in-stock").val();
    let unitsOnOrder = $("#units-on-order").val();
    let reorderLevel = $("#reorder-level").val();
    let discontinued = $("#discontinued").val();

    $.ajax({
        url: `http://localhost:61643/api/category`,
        method: "put",
        data: {
            supplierID: supplierID,
            name: name,
            categoryID: categoryID,
            quantityPerUnit: quantityPerUnit,
            unitsInStock: unitsInStock,
            unitPrice: unitPrice,
            reorderLevel: reorderLevel,
            unitsOnOrder: unitsOnOrder,
            discontinued: discontinued
        },
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
    let name = $("#name").val();
    let supplierID = $("#supplier-id").val();
    let categoryID = $("#category-id").val();
    let quantityPerUnit = $("#quantity-per-unit").val();
    let unitPrice = $("#unit-price").val();
    let unitsInStock = $("#unit-in-stock").val();
    let unitsOnOrder = $("#units-on-order").val();
    let reorderLevel = $("#reorder-level").val();
    let discontinued = $("#discontinued").val();

    $.ajax({
        url: `http://localhost:61643/api/product`,
        method: "post",
        data: {
            supplierID: supplierID,
            name: name,
            categoryID: categoryID,
            quantityPerUnit: quantityPerUnit,
            unitsInStock: unitsInStock,
            unitPrice: unitPrice,
            reorderLevel: reorderLevel,
            unitsOnOrder: unitsOnOrder,
            discontinued: discontinued
        },
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