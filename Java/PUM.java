import java.io.IOException;
import java.util.Scanner;

class Triangulo {

    public static void main(String[] args) throws IOException {
        Scanner sc = new Scanner(System.in);

        int n, aux = 1;

        n = sc.nextInt();

        for (int i = 1; i <= n; i++) {
            System.out.printf("%d %d %d PUM\n", aux, aux + 1, aux + 2);
            aux += 4;
        }
    }
}