/*
Crie um programa onde você receberá valores inteiros não negativos como entrada.

Ordene estes valores de acordo com o seguinte critério:
    - Primeiro os Pares
    - Depois os Ímpares
Você deve exibir os pares em ordem crescente e na sequência os ímpares em ordem decrescente.
*/

let totalItems = parseInt(gets());
let pares = [];
let impares = [];

for (let i = 0; i < totalItems; i++) {
  let number = parseInt(gets());
  if (number % 2 == 0){
    pares.push(number);
  }
  else {
    impares.push(number);
  }
}
pares.sort((a, b) => a - b);
impares.sort((a, b) => b - a);

for(let i = 0; i < pares.length;i++){
  print(pares[i]);
}
for(let i = 0; i < impares.length;i++){
  print(impares[i]);
}
