//Вариант 9 Уровень сложности средний
//bool Simm(string S)
//{
//    if (S.Length <= 1)
//    {
//        return true;
//    }
//    else if (S[0] == S[S.Length - 1])
//    {
//        return Simm(S.Substring(1, S.Length - 2));
//    }
//    else
//    {
//        return false;
//    }
//}

//string[] Rick = new string[5] {"radar" , "levle" , "deified" , "hello" , "world"};

//foreach (string R in Rick) 
//{
//    if (Simm(R))
//    {
//        Console.WriteLine($"{R} является симметричной");
//    }
//    else
//    {
//        Console.WriteLine($"{R} не является симметричной");
//    }
//}

