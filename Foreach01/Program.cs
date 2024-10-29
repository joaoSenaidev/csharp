string[] frutas = {"Melancia","Carambola", "Maracuja", "Morango", "Laranja", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pessego" ,"Banana"};

Console.Write($"Sua sacola contem {frutas.Length} frutas:  ");


// percorre todo o array e exibe cada fruta
foreach (string f in frutas)
{
    Console.Write($"{f}, "); 
}



