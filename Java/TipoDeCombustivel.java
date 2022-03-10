import java.io.IOException;import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args)  throws IOException {
		Scanner sc = new Scanner(System.in);
		
		
		int combustivel, stop=1;
		int soma1=0, soma2=0, soma3=0;

		
		while (stop != 2){
			if (stop == 1){
				combustivel = sc.nextInt();
				if (combustivel == 1){
					soma1 = soma1 + 1;
				}
				else if ( combustivel == 2 ){
					soma2 = soma2 + 1;
				}
				else if ( combustivel == 3  ){
					soma3 = soma3 + 1;
				}
				else if ( combustivel == 4 ){
					stop = 2;
				}
				else {
					continue;
				}
			}
			if (stop == 2){
				System.out.println("MUITO OBRIGADO");
				System.out.printf("Alcool: %d\n",soma1);
				System.out.printf("Gasolina: %d\n",soma2);
				System.out.printf("Diesel: %d\n",soma3);
			}
		} 
		sc.close();
	}
}