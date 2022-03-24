let line = gets().split(' ');
let totalCoxinha = parseInt(line[0]);
let totalParticipantes = parseInt(line[1]);
let media = parseFloat(totalCoxinha / totalParticipantes).toFixed(2);
print(media);
