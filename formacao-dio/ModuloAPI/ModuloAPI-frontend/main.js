const url = 'https://localhost:7198/Contato/ObterTodos';

const colaborator = {
  nome: document.getElementById('name').value,
  telefone: document.getElementById('phone').value,
  ativo: document.getElementById('active').checked
};

function postColaborator() {
  console.log(colaborator);
  fetch('https://localhost:7198/Contato', {
    method: 'POST',
    headers: {
      Accept: 'application.json',
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(colaborator)
  }).then((response) => {   // then, pegue a resposta do servidor
    if (!response.ok) {
      console.log(response)
      return new Error('falhou a requisição');
    }
    return response.json()
  }).then((dados) => console.log(dados))
}

async function getAllColaborators() {
  let colaborators = await fetch(url)
    .then((response) => response.json());

  console.log(colaborators);
}

async function getColaborator() {
  const idColaborator = document.getElementById('idColaborator').value;

  const dados = await fetch(`https://localhost:7198/Contato/${idColaborator}`)
    .then((response) => {   // then, pegue a resposta do servidor
      if (!response.ok) {
        throw new Error('Falha na requisição');
      }
      return response.json();
    })
  console.log(dados)
}

let alterColaborator = {
  id: "20",
  nome: "Github Silva",
  telefone: "54321",
  ativo: true
};

function putColaborator() {
  const idColaboratorToAlter = Number(document.getElementById('idColaboratorToAlter').value);
  console.log(idColaboratorToAlter);
  fetch(`https://localhost:7198/Contato/${idColaboratorToAlter}`, {
    method: 'PUT',
    headers: {
      Accept: 'application.json',
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(alterColaborator),
  }).then((response) => {
      if (!response.ok) {
        console.log(response)
        return new Error('falhou a requisição');
      }
    })
}

function deleteColaborator() {
  const idColaboratorToDelete = document.getElementById('idColaboratorToDelete').value;

  fetch(`https://localhost:7198/Contato/${idColaboratorToDelete}`, {
    method: 'DELETE'
  })
    .then(response => {
      if (!response.ok) {
        return new Error('falhou a requisição');
      }
    })
    console.log('Deletado com sucesso')
}


































// await fetch(url) // fetch, faça a requisição do servidor
//   .then((response) => {
//     // then, pegue a resposta do servidor e tranforme em json
//     return response.json();
//   }).then((data) => {
//     // then, pegue o json e faça algo com ele
//     const colaboratorsElement = document.getElementById('colaborator');
//     colaboratorsElement.innerHTML = ''; // Limpa o conteúdo anterior

//     data.forEach((item) => {
//       // Cria um novo elemento <p> para cada nome
//       let name = document.createElement('p');
//       name.textContent = item.nome;
//       colaboratorsElement.appendChild(name);

//       // Cria um novo elemento <p> para cada numero
//       let phone = document.createElement('p');
//       phone.textContent = item.telefone;
//       colaboratorsElement.appendChild(phone);

//       // Cria um novo elemento <p> para cada status
//       let status = document.createElement('p');
//       status.textContent = item.ativo;
//       colaboratorsElement.appendChild(status);
//       colaboratorsElement.appendChild(document.createElement('br'));
//     });
//   });

