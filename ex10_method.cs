using System;


namespace csharp_basic
{
    public class ex10_method
    {
        public static void ex10() {
            // String name = "John";
            // int sex = 0;
            // String sport= "hockey";

            // displayBio(name, sex, sport);
            // displayBio("Janifer", 1, "swimming");
            // displayBio("Carl", 0, "football");
            Console.WriteLine("aaa = " + getSum(10));

            int a = 10;
            int b = 25;
            Console.WriteLine(getText(a) + getSum(a));
            Console.WriteLine(getText(b) + getSum(b));
            Console.WriteLine(getEndText());


        }
        
        // สร้างฟังก์ชั่นย่อยไว้ด้านล่าง
          static void displayBio(String n, int s, String sp) {
              if (s == 0) {
                  Console.WriteLine(n + " has " + sp + " as his favorite sport.");
              } else {
                  Console.WriteLine(n + " has " + sp + " as her favorite sport.");
              }
          }  

          static String getText(int n) {
              return "Sum bewteen 1-" + n + " is ";
          }
          
          static int getSum(int n) {
              int sum = 0;
              for (int i = 1; i <= n; i++) {
                  sum += i;
              }
              return sum;
          }
          
          static String getEndText() {
            return "Program ended.";
        }
    }
}