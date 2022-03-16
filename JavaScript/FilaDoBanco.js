const testCases = parseInt(gets());
let clients = [];
let numbers = [];

for (let n = 0; n < testCases; n++) {
    clients[n] = parseInt(gets());
    numbers[n] = gets().split(' ');

    let orderedNumbers = Array.from(numbers[n]).sort((a, b) => b - a);
    let unchangedNumbers = 0;

    for (let i = 0; i < numbers[n].length; i++) {
        numbers[n][i] === orderedNumbers[i] && (unchangedNumbers++);
    }
    console.log(unchangedNumbers);

}
