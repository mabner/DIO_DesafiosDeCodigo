let line = gets();
let matricula;
let quantidadeAlunos = line;
let nota = 0;

for(var i = 0; i < quantidadeAlunos; i++){
  line = gets();
  line = line.split(" ")
  if(parseFloat(line[1]) >= nota){
    matricula = line[0];
    nota = line[1];
  }
}

if(nota >= 8)
 print(matricula);
else
  print("Minimum note not reached");
