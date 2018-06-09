namespace Library

open Microsoft.Azure.Documents

module Test =
    
    let printConsistencyLevel(level : ConsistencyLevel) = printfn "%A" level