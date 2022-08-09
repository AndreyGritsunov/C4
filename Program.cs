Console.WriteLine("Введите число");
int number_one = Convert.ToInt32(Console.ReadLine());
int i = 2;

while(i < number_one){
    if(i % 2 == 0) Console.WriteLine(i);
    i++;
}
