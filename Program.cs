int weekday; 
Console.Write("Введите номер дня (1-7): "); 
weekday = Convert.ToInt32(Console.ReadLine()); 
switch (weekday) 
    { 
        case 1: 
            Console.WriteLine("Понедельник"); 
            break; 
        case 2: 
            Console.WriteLine("вторник"); 
            break; 
        case 3: 
            Console.WriteLine("среда"); 
            break; 
        case 4: 
            Console.WriteLine("четверг"); 
            break; 
        case 5: 
            Console.WriteLine("пятница"); 
            break; 
        case 6: 
            Console.WriteLine("суббота"); 
            break; 
        case 7: 
            Console.WriteLine("воскресенье"); 
            break;        
        default: 
            Console.WriteLine("неправильный номер"); 
            break; 
    } 