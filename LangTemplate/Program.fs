module LangTemplate

open Microsoft.FSharp.Text.Lexing

[<EntryPoint>]
let main argv = 
    let tree = Parser.Start Lexer.tokenstream (LexBuffer<char>.FromString "...")
    printfn "%A" tree
    0
