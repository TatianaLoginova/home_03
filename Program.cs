// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void IsNumberPalindromVoid()
{
    int num, current_number, current_divider, i, num1, num2;

    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());

    current_divider = 10000;
    current_number = num / current_divider;
    i = 1;
    num1 = 0;
    num2 = 0;
    
    while( i <= 5 ) {
       
        
        Console.WriteLine( i + ". current_number = " +  current_number + ". Текущий делитель = " + current_divider + " num = " + num );            
        
       
        if(i == 1 ){
            num1 = current_number * 10;
        };
        if(i == 2){
            num1 = num1 + current_number;
        };
        if(i == 3){
                // ничего не делаем
        };
        if(i == 4){
            num2 = current_number;
        };
        if(i == 5){
            num2 = num2 + (current_number * 10);
            if (num1 == num2){
                Console.WriteLine("Число является палиндромом");
                };
        };
        
        current_divider = current_divider / 10;
        if (current_divider > 0){
            current_number = (num / current_divider)%10;
        };
        
       
       i ++; 
       
    };    

}


//IsNumberPalindromVoid(); 

/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

void TablaCubNumberVoid(){

    int num, i;

    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());

      i = 1;

    while( i <= num) {
        Console.Write(Cube(i) + " ");            
        i++;
    };

};

    int Cube(int num){
        return num * num * num;
    };


 

//IsNumberPalindromVoid(); 
TablaCubNumberVoid();