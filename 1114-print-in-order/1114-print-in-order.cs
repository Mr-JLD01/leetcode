public class Foo {
    int count = 1;

    public Foo() {
        
    }

    public void First(Action printFirst) {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        
        count++;
    }

    public void Second(Action printSecond) {
        while(true){
            if(count == 2){
                break;
            }
        }
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        
        count++;
    }

    public void Third(Action printThird) {
        while(true){
            if(count == 3){
                break;
            }
        }
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
        
        count++;
    }
}