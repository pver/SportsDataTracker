namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("SportsDataTracker")>]
[<assembly: AssemblyProductAttribute("SportsDataTracker")>]
[<assembly: AssemblyDescriptionAttribute("An application and library that allows analyzing sports data.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
