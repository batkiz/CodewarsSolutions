# CodewarsSolutions

Codewars 部分题目个人题解。

## csharp

大部分的题是使用 C# 来解的。

我使用了 [dotnet-script](https://github.com/filipw/dotnet-script) 来管理与写代码，因此大部分的文件扩展名会是 `.csx`，请使用 vscode (with c# ext) 打开。

不知道是 Ominisharp 还是 dotnet-script 的 bug，不是所有的 System 下的包都会被识别、导入与自动提示，因此有些代码中会有 `#r "System"` 的声明，无视即可。

## fsharp

目前也有在用 F# 来学习函数式编程，所以也提供了一些 F# 的题解。

F# 这边的 fsi 个人感觉有点难用，所以是新建了一个解决方案来写代码（& 代码补全）。

得益于函数式编程的特性，每道题基本都只是一个函数，因此很容易将其组织起来。

目前是每个等级的题都给放到一起，由于我还是个初学者，因此低等级的题可能会比较多，还望见谅。

## go

由于 vscode 的 go 扩展使用体验不是太好，使用了 Goland 写代码。

## rust
由于单 rust 文件的支持不太好，所以也是新建了一个项目。