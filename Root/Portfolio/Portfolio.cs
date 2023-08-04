
using StaticSharp;

namespace MyWebStudio.Root.Portfolio {

    public partial class Portfolio : MyWebStudio.Root.PageBase
    {
        public override Blocks Content => new() {"Portfolio"};

        public override string Title => "Portfolio";

        public override Inlines? Description => "Portfolio";
    }
}
