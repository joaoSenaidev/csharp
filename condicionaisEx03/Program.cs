// 3) Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

//    − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//    − Triângulo    Isóscele:    possui    2    lados    iguais.     
//    − Triângulo    Escaleno:    possui    3    lados    diferentes.

int lados;

Console.WriteLine($"Quantos lados iguais tem o triângulo (2, 3 ou 0)?");
lados = int.Parse(Console.ReadLine()!);

if(lados == 3) {
    Console.WriteLine($"Ele é um triângulo Equilátero");
}else if (lados == 2){
    Console.WriteLine($"Ele é um triângulo Isócele");
}else{
    Console.WriteLine($"Ele é umm  triângulo Escaleno");
} 





