// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    Library.Test.printConsistencyLevel(Microsoft.Azure.Documents.ConsistencyLevel.Eventual)
    0 // return an integer exit code
