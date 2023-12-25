using Microsoft.CodeAnalysis;
using System.Text;

namespace ClassLibrary1;

[Generator]
public class SourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        System.Console.WriteLine("Test....");

        var sb = new StringBuilder();
        sb.AppendLine("namespace ClassLibrary1;");
        sb.AppendLine("public static partial class Class1");
        sb.AppendLine("{");
        sb.AppendLine("    private static partial string? GetS2(string s)");
        sb.AppendLine("    {");
        sb.AppendLine("        return \"Test\"");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        context.AddSource("Class1.g.cs", sb.ToString());
    }

    public void Initialize(GeneratorInitializationContext context)
    {
    }
}
