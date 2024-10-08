// F#
// -> Linguagem multiparadigma. Paradigmas suportados: funcional, imperativo e orientado a objetos
// -> Open source e cross-plataform

// -> Exemplo de código:
// -------------------------------------
open System

// definição de função
let hello() = 
    // Indentação é relevante
    // Printf parecido com o de C: %i %s %b %A %M (números grandes)
    printf "Digite o seu nome :"

    let name = Console.ReadLine()

    printfn "Hello %s" name

// chamada da função
hello()
// -------------------------------------
// Variáveis mutáveis
let v_mutaveis() = 
    let mutable peso = 175
    peso <- 170

    printfn "Peso: %i" peso

v_mutaveis()
// -------------------------------------
let do_func() =
    // (Passagem de parâmetros e retorno)
    let get_sum (x: int, y:int) : int = x + y
    printf "5 + 7 = %i" (get_sum(5,7))
    
do_func()
// -------------------------------------
// Função recursiva
let rec fat x =
    if x < 1 then 1
    else x * fat(x - 1)
    
printfn "%i" (fat 5)
// -------------------------------------

// "Switch case super poderoso"
let describeNumber x =
    match x with
    | 1 -> "One"
    | 2 -> "Two"
    | _ -> "Other"

printfn "%s" (describeNumber 2)
// -------------------------------------
// While
let mutable i = 1
while i <= 5 do
    printfn "%d" i
    i <- i + 1
// -------------------------------------
// -> Apresenta registros:
type R = 
        { Name : string 
         Age : int }

// -> Apresenta uniões descriminadas:
type Forma =
  | Retangulo of Largura: float * Comprimento: float
  | Circulo of Raio: float
  | Prisma of Largura: float * Altura: float * Profundidade: float

// Uso de uma união descriminada:
let retangulo = Retangulo(Largura = 10.0, Comprimento = 5.0)
let circulo = Circulo(Raio = 3.0)
let prisma = Prisma(Largura = 7.0, Altura = 4.0, Profundidade = 6.0)
