using Microsoft.CodeAnalysis;

namespace RestEase.Implementation.Analysis
{
    internal partial class AllowAnyStatusCodeAttributeModel
    {
        private readonly INamedTypeSymbol namedTypeSymbol;

        public AllowAnyStatusCodeAttributeModel(AllowAnyStatusCodeAttribute attribute, INamedTypeSymbol namedTypeSymbol, AttributeData attributeData)
            : base(attribute, attributeData)
        {
            this.namedTypeSymbol = namedTypeSymbol;
        }

        public bool IsDefinedOn(TypeModel typeModel) => SymbolEqualityComparer.Default.Equals(this.namedTypeSymbol, typeModel.NamedTypeSymbol);
    }
}