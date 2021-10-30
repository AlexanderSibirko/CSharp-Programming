// ====
// Разложите натуральное число n на простые множители и определите

// сколько раз встречается множитель 2 в произведении
// наименьший множитель произведения
// сколько различных множителей в произведении
// ===

//1. Натуральное число
//2. Простые множители
//3. Разложение на множители
//4. подсчёт || поиск наименьшего || подсчёт различных

//как ввести число типданных n = 12;
//как получить разбиение на просты множители ?
//как сделать подсчёт нужного множителя ?

int Counter(int n)
{
    int [] simplenumber= {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};
    int count = 0;
    int index = 0;
    while (n > 1)
    {
            if (n % simplenumber[index] == 0)
            {
                if (simplenumber[index]==2){count++;}
                n = n / simplenumber[index];
            }
            else
            {
                index++;
            }
    }
    return count;
}

int DiffCounter(int n)
{
    int [] simplenumber= {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};
    int count = 0;
    bool newcount = true;
    int index = 0;
    while (n > 1)
    {
            if (n % simplenumber[index] == 0)
            {
                n = n / simplenumber[index];
                //Console.WriteLine(simplenumber[index]);
                if (newcount)
                {
                    count = count + 1;
                    newcount = false;
                    //Console.WriteLine(simplenumber[index]);
                }
            }
            else
            {
                newcount = true;
                index++;
            }
    }
    return count;
}

int MinCounter(int n)
{
    int [] simplenumber= {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};
    int index = 0;
    while (n > 1)
    {
        if (n % simplenumber[index] == 0)
        {
            break;
        }
        else
        {
            index++;
        }
    }
    return simplenumber[index];
}



int number = 637;
Console.WriteLine($"Количество множиетлей '2' составляет: {Counter(number)}");
Console.WriteLine($"Минимальный делитель равен: {MinCounter(number)}");
Console.WriteLine($"Количество различных множителей составляет: {DiffCounter(number)}");