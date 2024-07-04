// F#
// -> Linguagem multiparadigma. Paradigmas suportados: funcional, imperativo e orientado a objetos
// -> Open source e cross-plataform
// -> Apresenta registros:
// -------------------------
// Exemplo de registro:
type R = 
        { Name : string 
         Age : int }
// -------------------------
// -> Apresenta uniões descriminadas:
// -------------------------------------------------------------------
// Exemplo de união descriminada
type Forma =
  | Retangulo of Largura: float * Comprimento: float
  | Circulo of Raio: float
  | Prisma of Largura: float * Altura: float * Profundidade: float
// -------------------------------------------------------------------
