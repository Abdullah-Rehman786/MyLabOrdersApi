const uri = 'api/webpatreqs';

function getItems() {
    fetch(uri)
        .then(response => response.json())
        /*.then(data => _displayItems(data))*/
        .catch(error => console.error('Unable to get items.', error));
}


function addItem() {
    const fNameTextbox = document.getElementById('fName');

    const item = {
        fname: fNameTextbox.value.trim()
    };

    fetch(uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(item)
        })
        .then(response => response.json())
        .then(() => {
            fNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}
