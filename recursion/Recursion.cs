namespace CsharpMethods{
    public class Recursion{
        private int a;
        public Recursion(int a){
            this.a = a;
        }
        public void rec(int n){
            if( n == 10){
                return;
            }
            Console.WriteLine($" Выыодим число: {n} ");
            n++;
            rec(n);
        }
    }
}