using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var baseRoot = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.ToString() ?? string.Empty;
var htmlBuilderRoot = Path.Combine(baseRoot, "HtmlBuilder");

var tagsFolder = Path.Combine(htmlBuilderRoot, "Tags");
var utiltyFolder = Path.Combine(htmlBuilderRoot, "Utility", "Extensions");
var files = Directory.GetFiles(tagsFolder, "*.cs", SearchOption.AllDirectories);
foreach (var file in files)
{
    var text = File.ReadAllText(file);
    var syntaxTree = CSharpSyntaxTree.ParseText(text);
    var root = syntaxTree.GetRoot();
    var rewriter = new Rewriter();
    var newRoot = rewriter.Visit(root);
    if (newRoot != null)
    {
        var className = Path.GetFileNameWithoutExtension(file);
        var directoryName = Path.GetDirectoryName(file)?.Split(Path.DirectorySeparatorChar).Last()!;
        var newFileName = Path.Combine(utiltyFolder, directoryName, $"{className}Extensions.cs");
        var newFileText = newRoot.NormalizeWhitespace().ToFullString();
        if (!Directory.Exists(Path.GetDirectoryName(newFileName)))
            Directory.CreateDirectory(Path.GetDirectoryName(newFileName)!);
        File.WriteAllText(newFileName, newFileText);
    }

}




public class Rewriter : CSharpSyntaxRewriter
{

    public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var className = node.Identifier.Text;

        var classNameWithExtensions = $"{className}Extensions";


        var staticMethodExtension = SyntaxFactory.MethodDeclaration(
                SyntaxFactory.ParseTypeName("DoubleTagWithChildren"), className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .AddParameterListParameters(
                SyntaxFactory.Parameter(SyntaxFactory.Identifier("tag"))
                    .WithType(SyntaxFactory.ParseTypeName("DoubleTagWithChildren")),
                SyntaxFactory.Parameter(SyntaxFactory.Identifier("action"))
                    .WithType(SyntaxFactory.ParseTypeName($"Action<{className}>"))
            )
            .WithBody(
                SyntaxFactory.Block(
                    SyntaxFactory.LocalDeclarationStatement(
                        SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName("var"))
                            .AddVariables(
                                SyntaxFactory.VariableDeclarator(className.ToLower())
                                    .WithInitializer(
                                        SyntaxFactory.EqualsValueClause(
                                            SyntaxFactory
                                                .ObjectCreationExpression(SyntaxFactory.ParseTypeName(className))
                                                .WithArgumentList(SyntaxFactory.ArgumentList())
                                        )
                                    )
                            )
                    ),
                    SyntaxFactory.ExpressionStatement(
                        SyntaxFactory.InvocationExpression(
                            SyntaxFactory.IdentifierName("action")
                        ).AddArgumentListArguments(
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName(className.ToLower()))
                        )
                    ),
                    SyntaxFactory.ExpressionStatement(
                        SyntaxFactory.InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName("tag"),
                                SyntaxFactory.IdentifierName("AddChild")
                            )
                        ).AddArgumentListArguments(
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName(className.ToLower()))
                        )
                    ),
                    SyntaxFactory.ReturnStatement(SyntaxFactory.IdentifierName("tag"))
                )
            );

        var classDeclaration = SyntaxFactory.ClassDeclaration(classNameWithExtensions)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .AddMembers(staticMethodExtension);
        return classDeclaration;

    }
}
