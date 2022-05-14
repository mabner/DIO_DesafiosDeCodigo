let R = parseInt(gets());
let V;

while (true) {
	V = parseInt(gets());
	if (V > R) {
		break;
	}
}

let cont = 1;
let it = R;
let sum = R;

while (true) {
	cont++;
	it++;
	sum += it;
	if (sum > V) {
		print(cont);
		break;
	}
}
