import java.util.Scanner;

public class DIO {
	public static void main(String[] args) {
		Scanner inp = new Scanner(System.in);

		int x = inp.nextInt();
		int y = inp.nextInt();

		int intervalo, z = 0;

		if (x > y) {
			// Inverting the values, like playing the cup game :)
			z = x;
			x = y;
			y = z;
		}
		for (int i = x + 1; i < y; i++) {
			if (i % 5 == 2 || i % 5 == 3) {
				System.out.printf("%d\n", i);
			}
		}
	}
}