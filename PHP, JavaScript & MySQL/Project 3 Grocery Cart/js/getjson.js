/**
 * Gets a JSON-encoded list of user objects.
 * 
 */
window.addEventListener("load", function() {
    loadData();
    
    function loadData() {
        let url = "userlist.php";
        // // do the fetch
        fetch(url, { credentials: 'include' })
            .then(response => response.json())
            .then(data => {
                
                let html = "<ul>";
                
                data.forEach(async function(row) {
                    console.log(row);

                    html += "<li>" + row.ItemName + " " + row.ItemQuantity + "</li>";                   
                  });
                   
                html += "</ul>";
                document.getElementById("Items").innerHTML = html;
                }
            )
    }

    let button = document.getElementById("button");
    button.addEventListener("click", function() {

        // // get the name
        let name = document.getElementById("name").value;
        let itemsNumber = document.getElementById("itemsNumber").value;

        // // construct the url
        
        let url = "additems.php?name="+ name +"&itemsNumber="+itemsNumber;


        // // do the fetch
        fetch(url, { credentials: 'include' })
            .then(response => response.json())
            .then(data => {
                console.log('Success:', data);
            })     
        loadData();
    });
});