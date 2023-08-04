
using StaticSharp;

namespace MyWebStudio.Root.Contacts {

    public partial class Contacts : MyWebStudio.Root.PageBase
    {
        public override Blocks Content => new (){"Contacts"};

        public override string Title => "Contacts";

        public override Inlines? Description => "";
    }
}
