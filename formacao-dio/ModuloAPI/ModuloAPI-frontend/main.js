const url = 'https://localhost:7198/Contato/ObterTodos';

fetch(url) // fetch, faça a requisição do servidor
  .then((response) => {
    // then, pegue a resposta do servidor e tranforme em json
    return response.json();
  }).then((data) => {
    // then, pegue o json e faça algo com ele
    const colaboratorsElement = document.getElementById('colaborators');
    colaboratorsElement.innerHTML = ''; // Limpa o conteúdo anterior

    data.forEach((item) => {
      // Cria um novo elemento <p> para cada nome
      const p = document.createElement('p');
      p.textContent = item.nome;
      colaboratorsElement.appendChild(p);
    });
  });
