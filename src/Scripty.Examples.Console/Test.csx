using Microsoft.CodeAnalysis;

foreach (Document document in Project.Analysis.Documents)
{
    Output[$"{document.FilePath}" +"1.cs"].WriteLine($"// {document.FilePath}");
}
//Output["other.cs"].WriteLine("// Another file");