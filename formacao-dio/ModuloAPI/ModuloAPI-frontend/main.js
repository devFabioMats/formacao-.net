const colaboratorsList = document.querySelector(".posts-list");
const addColaborator = document.querySelector(".add-post-form");
const nameValue = document.getElementById("name-value");
const phoneNumber = document.getElementById("phone-value");
const active = document.getElementById("active-value");

// const renderCards = (cards) => {
//   cards.forEach((card) => {
//     colaboratorsList.innerHTML += `
//         <div class="card mt-4 col-md-6 bg-ligt">
//             <div class="card-body">
//                 <h5 class="card-title">${card.nome}</h5>
//                 <h6 class="card-subtitle mb-2 text-muted">${card.telefone}</h6>
//                 <p class="card-text">${card.ativo}</p>
//                 <a href="#" class="card-link">Edit</a>
//                 <a href="#" class="card-link">Delete</a>
//             </div>
//         </div>
//        `;
//   });
// };

const url = "https://localhost:7198/Contato/ObterTodos";

// Get - Read the colaborators
// Method: GET

async function getAllColaborators() {
  await fetch("https://localhost:7198/Contato/ObterTodos") // fetch, faça  a requisição do servidor
    .then((response) => {
      // then, pegue a resposta do servidor e tranforme em json
      return response.json();
    })
    .then((data) => {
      // then, pegue o json e coloque no html
      console.log(data); //renderCards(data)
    });
}

fetch("https://localhost:7198/Contato/ObterTodos") // fetch, faça  a requisição do servidor
  .then((response) => {
    // then, pegue a resposta do servidor e tranforme em json
    return response.json();
  })
  .then((data) => {
    // then, pegue o json e faça algo com ele
    console.log(data); //renderCards(data)
  });

// // Create - Insert New Colaborator
// // Method: POST
// addColaborator.addEventListener("submit", (e) => {
//   e.preventDefault();

//   if (!nameValue.value || !phoneNumber.value || !active.value) {
//     console.error("One or more input values are empty");
//     return;
//   }

//   const newColaborator = {
//     nome: nameValue.value,
//     telefone: phoneNumber.value,
//     ativo: active.value,
//   };

//   console.log("Sending data:", newColaborator);

//   fetch("https://localhost:7198/Contato", {
//     method: "POST",
//     headers: {
//       "Content-Type": "application/json",
//     },
//     body: JSON.stringify(newColaborator),
//   })
//     .then((response) => {
//       if (!response.ok) {
//         return response.json().then((error) => {
//           throw new Error(error.message);
//         });
//       }
//       return response.json();
//     })
//     .then((data) => {
//       const dataArray = [];
//       dataArray.push(data);
//       renderCards(dataArray);
//     })
//     .catch((error) => {
//       console.error("Error:", error);
//     });
// });

// // const url = 'https://dummyjson.com/products';

// // async function chamarApi(){
// //     const response = await fetch(url);
// //     console.log(response);

// //     if(response.status == 200){
// //         const object = await response.json();
// //         console.log(object);
// //     } else {
// //         console.log('Erro ao chamar a API');
// //     }
// // }

// // chamarApi();
