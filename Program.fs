type HTMLAttr =
    | [<Fable.Core.EraseAttribute>] Href of string
    | Custom of string

let a = Href "href" = Custom "custom" 