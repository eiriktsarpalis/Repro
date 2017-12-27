module Test

open System.Configuration

let test() = System.Configuration.ConfigurationManager.AppSettings.["foobar"]