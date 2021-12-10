// int K = 8;
// int M = 20;
// int N = 8; //N[0] = 5, N[1]=10, N[X]=N[x-2]+N[x-1]...;

// string FirstNofKPlusMSequence(int K, int M, int N)
// {
//     if (N == 1) return $"{K}";
//     else return $"{K} {FirstNofKPlusMSequence(M, K + M, N-1)}";
// }

// Console.WriteLine(FirstNofKPlusMSequence(K, M, N));


int [][] arrayOfArrays = new int[5][];
int[] newArr = {2,5,6,7};
arrayOfArrays[0] = newArr;
int[] newArr1 = {5,6,7};
arrayOfArrays[1] = newArr1;
int[] newArr2 = {6,7};
arrayOfArrays[2] = newArr2;
int[] newArr3 = {15,2,5,6,7};
arrayOfArrays[3] = newArr3;
int[] newArr4 = {2,5,6,7};
arrayOfArrays[4] = newArr4;

for (int i = 0 ; i< arrayOfArrays.Length;i++)
{
        Console.WriteLine(String.Join('|',arrayOfArrays[i]));
}

Console.WriteLine();

arrayOfArrays[0] = arrayOfArrays[3];

for (int i = 0 ; i< arrayOfArrays.Length;i++)
{
        Console.WriteLine(String.Join('|',arrayOfArrays[i]));
}








// double a = 3;
// double b = 2;
// double c = a/b;
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// char[] aiLetters = { 'a', 'b', 'c', 'd' };
// int maxWordLen = 3;

// int combinations(int alphLen, int maxWordLen)
// {
//     if (maxWordLen == 0) return 1;
//     else if (maxWordLen % 2 == 0) return combinations(alphLen * alphLen, maxWordLen / 2);
//     else return combinations(alphLen, maxWordLen - 1) * alphLen;
// }

// // Console.WriteLine(combinations(alphLen, 1));
// // Console.WriteLine(combinations(alphLen, 2));
// // Console.WriteLine(combinations(alphLen, 3));
// // Console.WriteLine(combinations(alphLen, 4));

// string[] allWords(char[] letters, int maxWordLength) //delimitered by ' '
// {
//     for (int i = 0; i <= maxWordLength; i++)
//     {

//     }
// // }

// IEnumerable<String> GenerateStrings (IEnumerable<char> characters, int length) {
//     if(length > 0) {
//         foreach(char c in characters) {
//             foreach(String suffix in GenerateStrings(characters,length-1)) {
//                 yield return c+suffix;
//             }
//         }
//     } else {
//         yield return string.Empty;
//     }
// }

// foreach(string aiword in GenerateStrings(aiLetters,maxWordLen))
// {
//     Console.WriteLine(aiword);
// }

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet,word,length+1);
//     }
// }

// FindWords("abcd", new char[3]);
// Console.WriteLine(allWords(aiLetters,maxWordLen));

// // Метод подсчёта наибольшей суммыочков с заданных карт, на входе массив карт заданных как числа (2-14)
// // Для определения блэкджека от суммы 21, результат при блэкджеке =99 (недостижимый простым подсчётом карт)
// int CardsScore(int[] cardsArray)
// {
//     int len = cardsArray.Length;
//     int aceCount = 0;
//     int totalScore = 0;
//     for (int i = 0; i < len; i++)
//     {
//         switch (cardsArray[i])
//         {
//             case < 11:                               //для карт 2-10 по номиналу
//                 totalScore += cardsArray[i];
//                 break;
//             case 11:
//                 totalScore += cardsArray[i];
//                 aceCount++;
//                 break;

//             case > 11:                               //все карты с картинками как 10
//                 totalScore += 10;
//                 break;
//         }
//     }
//     if (totalScore == 21 && len == 2) { return 99; } //
//     while (totalScore > 21 && aceCount > 0)         //если по итогам получили перебор за каждого туза вычитам 10 (начинаем считать его как 1), пока не закончатся тузы или не окажемся ниже 21
//     {
//         totalScore -= 10;
//         aceCount--;
//     }
//     return totalScore;
// }
// // int[] cards = { 10, 11 };
// // Console.WriteLine(CardsScore(cards));
// // int[] cards6 = { 11, 10 };
// // Console.WriteLine(CardsScore(cards6));
// // int[] cards2 = { 3, 8, 10 };
// // Console.WriteLine(CardsScore(cards2));
// // int[] cards3 = { 10, 11, 10 };
// // Console.WriteLine(CardsScore(cards3));
// // int[] cards4 = { 10, 11, 5, 6, 11 };
// // Console.WriteLine(CardsScore(cards4));
// // int[] cards5 = { 10, 11, 11, 3 };
// // Console.WriteLine(CardsScore(cards5));


// //метод возвращает изменения баланса игрока, по очкам их карт и величине ставки
// //переборы игрока сюда не попадают
// int CompareCardsResult(int playerScoreValue, int dealerScoreValue) //-1 проигра, 0 - ничья, 1 выиграл, 2 выиграл по блэкджеку
// {
//     //условие ничьей
//     if (dealerScoreValue == playerScoreValue) return 0; //сумма карт поровну (при этом никто не перебрал)
//     //условия победы
//     if (playerScoreValue == 99) {return 2;} //победа по блэкджеку (у же не ничья т.е. у крупье не блэкджек)
//     if ((dealerScoreValue > 21 && dealerScoreValue != 99) || playerScoreValue > dealerScoreValue) return 1; //простая победа, у дилера перебор или у игрока сумма выше
//     //все остальные варианты проигрыш
//     return -1; //у крупье больше чем у игрока (нету переборов и блэджеков и т.п.)
// }

// //метод изменения баланса игрока
// //при переборе в процессе добора вызываем BalanceChange(-1,betValue), при этом обнуляем положение ставки
// //для всех не выбывших игроков у которых в Bets != 0, производим BalanceChange(CompareCardsResult(playerScore,dealerScore),betValue);
// int BalanceChange(int WinLossValue, int betValue)
// {
//     switch (WinLossValue)
//     {
//         case -1:
//             return -betValue; //результат проигрыш
//         case 0:
//             return 0;         //результат ничья
//         case 1:
//             return betValue;  //результат выигрышь 1 к 1  
//         case 2:         
//             return betValue * 3 / 2;    //результат выигрышь 3 к 2 (по Блэкджеку), копейки остаются у казино
//         default:
//             return 0; //результат которого не должно быть!
//     }
// }

// Console.WriteLine(BalanceChange(-1,200));
// Console.WriteLine(BalanceChange(-1,1));
// Console.WriteLine(BalanceChange(0,200));
// Console.WriteLine(BalanceChange(1,200));
// Console.WriteLine(BalanceChange(2,55));

// Console.WriteLine();

// Console.WriteLine(BalanceChange(CompareCardsResult(99,99),100)); //два блэка
// Console.WriteLine(BalanceChange(CompareCardsResult(99,21),100)); //блэк у игрока, 21 у дилера
// Console.WriteLine(BalanceChange(CompareCardsResult(21,99),100)); //21 у игрока, блэк у дилера
// Console.WriteLine(BalanceChange(CompareCardsResult(21,21),100)); //по 21 у каждого
// Console.WriteLine(BalanceChange(CompareCardsResult(17,17),100)); //по 17 у каждого
// Console.WriteLine(BalanceChange(CompareCardsResult(4,25),100));  //диллер перебор игрок минимум
// Console.WriteLine(BalanceChange(CompareCardsResult(18,17),100)); //у игрока больше чем у дилера
// Console.WriteLine(BalanceChange(CompareCardsResult(16,17),100)); //у дилера больше чем у игрока

// // int number = 123;
// string str = Convert.ToString(number);
// for (int i = 0; i < str.Length; i++)
// {
//     string letter = "";
//     letter = str[i];
//     Console.WriteLine(str[i]);
//     Console.WriteLine((int)str[i]);
//     Console.WriteLine(Convert.ToInt32('1'));
//     Console.WriteLine(Convert.ToInt32("1"));
// }

// bool numIsPalendrome3(int N) //без декомпозиции числа на массив из его цифр
// {
//     int cropN = Math.Abs(N);
//     int revertN = 0;
//     int numCount = 0;
//     while (cropN > 0) //выворачиваем число
//     {
//         revertN = revertN * 10 + cropN % 10;
//         cropN = cropN / 10;
//         numCount++;
//     }
//     cropN = 10;
//     for (int i = 0; i < numCount/2 - 1; i++)    
//     {
//         cropN = cropN*10 ;
//     }
//     if (N/cropN == revertN / cropN)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.WriteLine(numIsPalendrome3(12344321));
// double N = -423432.2325;
// double numsSum (double n)
// {
//     n = Math.Abs(n);
//     double result = 0;
//     while (n!=0)
//     {
//         Console.WriteLine(n);
//         Console.WriteLine(result);
//         result = result + n % 10;
//         n /= 10;
//     }
//     return result;
// }

// Console.WriteLine(numsSum(N));

// int sumN(int N)
// {
//     int sum = 0;
//     for (int i = 3; i <= N; i += 3) {sum += i;}
//     for (int i = 5; i <= N; i += 5) {if (i % 3 != 0) { sum += i; }}
//     return sum;
// }

// Console.WriteLine(sumN(1000 - 1));

// int bruteFsumN(int N, int divA, int divB = 1)
// {
//     int sum = 0;
//     for (int i = divA; i <= N; i += divA) { sum += i; }
//     if (divB > 1)
//     {
//         for (int i = divB; i <= N; i += divB)
//         {
//             if (i % divA != 0)
//             {
//                 sum += i;
//             }
//         }
//     }
//     return sum;
// }

// for (int i = 100; i < 1000001; i *= 10)
// {
//     Console.Write(i + " sum: ");
//     Console.WriteLine(bruteFsumN(i, 3, 5));
// }
// int sumNOpt(int N, int divA, int divB)
// {
//     int a = divA * divB;
//     int ba = 0;
//     int b2 = 0;
//     int c = 0;
//     int cb = 0;
//     int cc = 0;
//     ba = bruteFsumN(a, divA, divB);
//     b2 = bruteFsumN(2 * a, divA, divB);
//     c = N / a;
//     cb = b2 - 2 * ba;
//     cc = bruteFsumN(c - 1, 1);
//     //Console.WriteLine(a + " " + ba + " " + b2 + " " + c + " " + cb + " " + cc );
//     return c * ba + cc * cb;
// }
// for (int K = 15; K < 999; K += 15)
// {
//     Console.Write(bruteFsumN(K, 3, 5) + "   ");
//     Console.WriteLine(sumNOpt(K, 3, 5));
// }


