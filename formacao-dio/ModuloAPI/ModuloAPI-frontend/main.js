const postslist = document.querySelector('.posts-list');

const url = 'https://localhost:7198/Contato/ObterTodos';

// Get - Read the Posts
// Method: GET
fetch(url)
    .then(response => response.json())
    .then(data => console.log(data))
    


// const url = 'https://dummyjson.com/products';

// async function chamarApi(){
//     const response = await fetch(url);
//     console.log(response);

//     if(response.status == 200){
//         const object = await response.json();
//         console.log(object);
//     } else {
//         console.log('Erro ao chamar a API');
//     }
// }

// chamarApi();