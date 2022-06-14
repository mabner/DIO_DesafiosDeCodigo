/*
Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence.

Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
DDD nao cadastrado
*/

const DDD = parseInt(gets());

switch (DDD) {
	case 61: print("Brasilia"); break;
	case 71: print("Salvador"); break;
	case 11: print("Sao Paulo"); break;
	case 21: print("Rio de Janeiro"); break;
	case 32: print("Juiz de Fora"); break;
	case 19: print("Campinas"); break;
	case 27: print("Vitoria"); break;
	case 31: print("Belo Horizonte"); break;
    default: print("DDD nao cadastrado");
}
