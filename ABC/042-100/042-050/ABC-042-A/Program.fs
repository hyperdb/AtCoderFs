// For more information see https://aka.ms/fsharp-console-apps
#nowarn "0025"
let [|a;b;c|] = stdin.ReadLine().Split() |> Array.map int |> Array.sort

if a + b + c = 17 && a = 5 && b = 5 then "YES" else "NO"
|> stdout.WriteLine
