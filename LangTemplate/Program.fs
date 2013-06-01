// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module LangTemplate

open Microsoft.FSharp.Text.Lexing

[<EntryPoint>]
let main argv = 
    let tree = Parser.Start Lexer.tokenstream (LexBuffer<char>.FromString "...")
    printfn "%A" tree
    0 // return an integer exit code
