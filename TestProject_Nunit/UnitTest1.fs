module TestProject_Nunit

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()
